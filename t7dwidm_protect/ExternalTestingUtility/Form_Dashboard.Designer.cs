namespace t7dwidm_protect
{
    partial class Form_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_MainButtons = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_NetworkPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.NameChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.netpasstimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_Status = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_LaunchGame = new System.Windows.Forms.Button();
            this.btn_Settings = new FontAwesome.Sharp.IconButton();
            this.panel_MainButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(432, 1);
            this.panel_TitleBar.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(12, 17);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(322, 40);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Black Ops 3 - Zombies";
            // 
            // panel_MainButtons
            // 
            this.panel_MainButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel_MainButtons.Controls.Add(this.btn_Settings);
            this.panel_MainButtons.Controls.Add(this.btn_LaunchGame);
            this.panel_MainButtons.Controls.Add(this.label3);
            this.panel_MainButtons.Controls.Add(this.panel2);
            this.panel_MainButtons.Controls.Add(this.label2);
            this.panel_MainButtons.Controls.Add(this.panel1);
            this.panel_MainButtons.Location = new System.Drawing.Point(21, 62);
            this.panel_MainButtons.Name = "panel_MainButtons";
            this.panel_MainButtons.Size = new System.Drawing.Size(389, 198);
            this.panel_MainButtons.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "PASSWORD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.txt_NetworkPassword);
            this.panel2.Location = new System.Drawing.Point(16, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 38);
            this.panel2.TabIndex = 7;
            // 
            // txt_NetworkPassword
            // 
            this.txt_NetworkPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.txt_NetworkPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NetworkPassword.ForeColor = System.Drawing.Color.White;
            this.txt_NetworkPassword.Location = new System.Drawing.Point(11, 11);
            this.txt_NetworkPassword.Name = "txt_NetworkPassword";
            this.txt_NetworkPassword.PasswordChar = '*';
            this.txt_NetworkPassword.Size = new System.Drawing.Size(333, 16);
            this.txt_NetworkPassword.TabIndex = 4;
            this.txt_NetworkPassword.TextChanged += new System.EventHandler(this.txt_NetworkPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "USERNAME";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Location = new System.Drawing.Point(16, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 38);
            this.panel1.TabIndex = 1;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.White;
            this.txt_Username.Location = new System.Drawing.Point(11, 11);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(333, 16);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(100)))), ((int)(((byte)(54)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(399, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 31);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NameChangeTimer
            // 
            this.NameChangeTimer.Interval = 500;
            // 
            // netpasstimer
            // 
            this.netpasstimer.Interval = 1500;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Status.ForeColor = System.Drawing.Color.White;
            this.lbl_Status.Location = new System.Drawing.Point(4, 266);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(120, 15);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "Game Not Launched";
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginsToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(114, 26);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            this.pluginsToolStripMenuItem.Click += new System.EventHandler(this.pluginsToolStripMenuItem_Click);
            // 
            // btn_LaunchGame
            // 
            this.btn_LaunchGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_LaunchGame.FlatAppearance.BorderSize = 0;
            this.btn_LaunchGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LaunchGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_LaunchGame.ForeColor = System.Drawing.Color.White;
            this.btn_LaunchGame.Location = new System.Drawing.Point(16, 145);
            this.btn_LaunchGame.Name = "btn_LaunchGame";
            this.btn_LaunchGame.Size = new System.Drawing.Size(313, 38);
            this.btn_LaunchGame.TabIndex = 9;
            this.btn_LaunchGame.Text = "Play Black Ops 3 - Zombies";
            this.btn_LaunchGame.UseVisualStyleBackColor = false;
            this.btn_LaunchGame.Click += new System.EventHandler(this.btn_LaunchGame_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btn_Settings.IconColor = System.Drawing.Color.White;
            this.btn_Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Settings.IconSize = 26;
            this.btn_Settings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Settings.Location = new System.Drawing.Point(335, 145);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(34, 38);
            this.btn_Settings.TabIndex = 6;
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(432, 287);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel_MainButtons);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.panel_TitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T7Patch Loader";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Dashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Dashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Dashboard_MouseUp);
            this.panel_MainButtons.ResumeLayout(false);
            this.panel_MainButtons.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_MainButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_NetworkPassword;
        private System.Windows.Forms.Timer NameChangeTimer;
        private System.Windows.Forms.Timer netpasstimer;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.Button btn_LaunchGame;
        private FontAwesome.Sharp.IconButton btn_Settings;
    }
}