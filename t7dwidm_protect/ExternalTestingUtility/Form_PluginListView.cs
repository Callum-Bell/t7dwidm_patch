using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static t7dwidm_protect.Form_Dashboard;

namespace t7dwidm_protect
{
    public partial class Plugins : Form
    {
        private GamePlugins gamePlugins;
        private PlayerSettings settings;
        private Form_Dashboard parentForm;

        public Plugins(GamePlugins plugins, PlayerSettings playerSettings, Form_Dashboard form)
        {
            InitializeComponent();
            gamePlugins = plugins;
            settings = playerSettings;
            parentForm = form;

            chk_FriendsOnly.Checked = settings.IsFriendsOnly;
        }

        private void chk_FriendsOnly_CheckedChanged(object sender, EventArgs e)
        {
            settings.IsFriendsOnly = chk_FriendsOnly.Checked;
            parentForm.CommitSettings();

            if (chk_FriendsOnly.Checked) { chk_FriendsOnly.ForeColor = Color.LightGreen; }
            else { chk_FriendsOnly.ForeColor = Color.Red; }
        }


        private bool mouseDown;
        private Point lastLocation;

        private void Plugins_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Plugins_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Plugins_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Plugins_Load(object sender, EventArgs e)
        {
            DisplayPluginFileNames();
        }

        private void DisplayPluginFileNames()
        {
            listBox_Plugins.Items.Clear();
            foreach (var pluginPath in gamePlugins.GetPlugins())
            {
                string fileName = Path.GetFileName(pluginPath);
                listBox_Plugins.Items.Add(fileName);
            }
        }

        private void addPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlugin();
        }

        private void AddPlugin()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a DLL Plugin";

                openFileDialog.Filter = "DLL Files (*.dll)|*.dll";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    gamePlugins.AddPlugin(selectedFilePath);

                    gamePlugins.SaveToFile();

                    DisplayPluginFileNames();
                }
            }
        }

        private void removePluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePlugin();
        }

        private void RemovePlugin()
        {
            if (listBox_Plugins.SelectedItem != null)
            {
                string selectedPluginName = listBox_Plugins.SelectedItem.ToString();

                string selectedPluginPath = gamePlugins.GetPlugins().FirstOrDefault(p => Path.GetFileName(p) == selectedPluginName);

                if (selectedPluginPath != null)
                {
                    gamePlugins.RemovePlugin(selectedPluginPath);

                    listBox_Plugins.Items.Remove(listBox_Plugins.SelectedItem);

                    gamePlugins.SaveToFile();
                }
                else
                {
                    MessageBox.Show("The selected plugin could not be found in the list.");
                }
            }
            else
            {
                MessageBox.Show("Please select a plugin to remove.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void listBox_Plugins_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listBox_Plugins.SelectedItem != null)
                {
                    string selectedPluginName = listBox_Plugins.SelectedItem.ToString();

                    string selectedPluginPath = gamePlugins.GetPlugins().FirstOrDefault(p => Path.GetFileName(p) == selectedPluginName);

                    if (selectedPluginPath != null)
                    {
                        gamePlugins.RemovePlugin(selectedPluginPath);

                        listBox_Plugins.Items.Remove(listBox_Plugins.SelectedItem);

                        gamePlugins.SaveToFile();
                    }
                    else
                    {
                        MessageBox.Show("The selected plugin could not be found in the list.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a plugin to remove.");
                }
            }
        }

        private void listBox_Plugins_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) { e.Effect = DragDropEffects.Copy; }
            else { e.Effect = DragDropEffects.None; }
        }

        private void listBox_Plugins_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files)
            {
                foreach (var file in files)
                {
                    if (Path.GetExtension(file).Equals(".dll", StringComparison.OrdinalIgnoreCase))
                    {
                        string fileName = Path.GetFileName(file);

                        if (!listBox_Plugins.Items.Contains(fileName))
                        {
                            listBox_Plugins.Items.Add(fileName);

                            gamePlugins.AddPlugin(file);

                            gamePlugins.SaveToFile();
                        }
                    }
                }
            }
        }

        private void btn_AddPlugin_Click(object sender, EventArgs e)
        {
            AddPlugin();
        }

        private void btn_RemovePlugin_Click(object sender, EventArgs e)
        {
            RemovePlugin();
        }
    }
}
