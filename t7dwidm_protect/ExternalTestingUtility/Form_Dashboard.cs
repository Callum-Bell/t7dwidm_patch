using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using t7dwidm_protect.Cheats;

namespace t7dwidm_protect
{
    public partial class Form_Dashboard : Form
    {
        private Action UpdateProtection;
        private PlayerSettings Settings = new PlayerSettings();

        public Form_Dashboard()
        {
            InitializeComponent();
        }


        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            UpdateProtection = __updateprotection;
            if (!File.Exists("settings.json"))
            {
                CommitSettings();
            }
            LoadSettings();
            new Task(() =>
            {
                try
                {
                    PollProcesses();
                }
                catch (Exception ex)
                {
                    // Log or display the exception
                    MessageBox.Show(ex.Message);
                }
            }).Start();

            NameChangeTimer.Tick += NameChangeTimer_Tick;
            netpasstimer.Tick += Netpasstimer_Tick;
            DoubleBuffered = true;
        }

        private void Netpasstimer_Tick(object sender, EventArgs e)
        {
            Settings.NetworkPassword = txt_NetworkPassword.Text;
            CommitSettings();
            if (BlackOps3.IsGamePresent() && moduleHandle != null)
            {
                BlackOps3.Game.Call(moduleHandle["SetNetworkPassword"], Settings.NetworkPassword);
            }
            netpasstimer.Stop();
        }

        private void NameChangeTimer_Tick(object sender, EventArgs e)
        {
            Settings.Playername = txt_Username.Text;
            if (Settings.Playername.Length >= 16)
            {
                Settings.Playername = Settings.Playername.Substring(0, 15);
            }
            CommitSettings();
            if (BlackOps3.IsGamePresent() && moduleHandle != null)
            {
                BlackOps3.Game.Call(moduleHandle["SetPlayerName"], Settings.Playername);
            }
            NameChangeTimer.Stop();
        }

        private void CommitSettings()
        {
            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = new LowerNamePol(),
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };
            File.WriteAllBytes("settings.json", Encoding.ASCII.GetBytes(JsonSerializer.Serialize(Settings, typeof(PlayerSettings), serializeOptions)));
        }

        private void LoadSettings()
        {
            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = new LowerNamePol(),
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };
            Settings = (PlayerSettings)JsonSerializer.Deserialize(File.ReadAllBytes("settings.json"), typeof(PlayerSettings), serializeOptions);

            if (Settings.Playername.Length >= 16)
            {
                Settings.Playername = Settings.Playername.Substring(0, 15);
            }

            txt_Username.Text = Settings.Playername;
            txt_NetworkPassword.Text = Settings.NetworkPassword;
        }

        private void PollProcesses()
        {
            while (true)
            {
                UpdateProtection?.Invoke();
                System.Threading.Thread.Sleep(250);
            }
        }

        private static byte[] ExtractResource(String filename)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            using (Stream resFilestream = a.GetManifestResourceStream(filename))
            {
                if (resFilestream == null) return null;
                byte[] ba = new byte[resFilestream.Length];
                resFilestream.Read(ba, 0, ba.Length);
                return ba;
            }
        }

        ProcessModuleEx moduleHandle = null;

        private List<int> pidsOwned = new List<int>();
        private void __updateprotection()
        {
            try
            {
                if (BlackOps3.Game != null)
                {

                    // check if the game has exited
                    if (BlackOps3.Game.BaseProcess.HasExited)
                    {
                        throw new Exception("Black Ops 3 process");
                    }

                    do
                    {
                        // protect a new process if found
                        if (!pidsOwned.Contains(BlackOps3.Game.BaseProcess.Id))
                        {
                            if (BlackOps3.Game.GetValue<long>(BlackOps3.Game[BlackOps3.Constants.OFF_GAME_READY]) == 0)
                            {
                                break;
                            }

                            if (!(BlackOps3.Game["zbr.dll"] is null)) // dont inject when its a zbr process
                            {
                                break;
                            }

                            //if((BlackOps3.Game.GetValue<byte>(BlackOps3.Game[0x162E4410]) & 1) != 1) // ui loaded once
                            //{
                            //    break;
                            //}

                            //// disable voice packet dispatching
                            BlackOps3.SetDvar("maxvoicepacketsperframe", "0");

                            //// disable callvote
                            BlackOps3.SetDvar("sv_mapswitch", "0");

                            if (true)
                            {
                                var bytes = ExtractResource("t7dwidm_protect.discord_game_sdk.dll");
                                File.WriteAllBytes(Path.Combine(Path.GetDirectoryName(BlackOps3.Game.BaseProcess.MainModule.FileName), "discord_game_sdk.dll"), bytes);
                                moduleHandle = BlackOps3.Game.LoadAndRegisterDllRemote(Path.Combine(Environment.CurrentDirectory, "t7patch.dll"));
                                BlackOps3.Game.LoadAndRegisterDllRemote(Path.Combine(Environment.CurrentDirectory, "zbr2.dll"));
                                BlackOps3.Game.LoadAndRegisterDllRemote(Path.Combine(Environment.CurrentDirectory, "BO3-Mod-Check-Patch.dll"));
                            }
                            BlackOps3.Game.Call(moduleHandle["zbr_run_gamemode_lui"], "serious_anticrash_2023");
                            BlackOps3.Game.Call(moduleHandle["SetPlayerName"], Settings.Playername);
                            BlackOps3.Game.Call(moduleHandle["SetFriendsOnly"], Settings.IsFriendsOnly);
                            BlackOps3.Game.Call(moduleHandle["SetNetworkPassword"], Settings.NetworkPassword);

                            this.Invoke((MethodInvoker)(() =>
                            {
                                lbl_Status.Text = "Protected Process with ID: " + BlackOps3.Game.BaseProcess.Id;
                            }));
                            pidsOwned.Add(BlackOps3.Game.BaseProcess.Id);
                        }
                    } while (false);
                }
            }
            catch (Exception e)
            {
                moduleHandle = null;
                if (!e.ToString().Contains("Black Ops 3 process"))
                {
                    if (e.ToString().Contains("Cannot process request because the process") && e.ToString().Contains("has exited."))
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            lbl_Status.Text = "Process has been exited.";
                        }));
                    }
                    else
                    {
                        File.AppendAllText("errors.txt", e.ToString() + "\n\n");
                        this.Invoke((MethodInvoker)(() =>
                        {
                            lbl_Status.Text = "An error has occurred. Please Check `errors.txt`";
                        }));
                    }
                }
                else
                {
                    // Update status label on the UI thread
                    this.Invoke((MethodInvoker)(() =>
                    {
                        lbl_Status.Text = "No game process found.";
                    }));
                }
            }
        }


        private bool mouseDown;
        private Point lastLocation;

        private void Form_Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class PlayerSettings
        {
            public string Playername { get; set; }
            public bool IsFriendsOnly { get; set; }
            public bool IsMTLPatchEnabled { get; set; }
            public string NetworkPassword { get; set; }

            public PlayerSettings()
            {
                Playername = "";
                IsFriendsOnly = true;
                IsMTLPatchEnabled = false;
                NetworkPassword = "";
            }
        }

        internal class LowerNamePol : JsonNamingPolicy
        {
            public override string ConvertName(string name) =>
                name.ToLower();
        }
    }
}
