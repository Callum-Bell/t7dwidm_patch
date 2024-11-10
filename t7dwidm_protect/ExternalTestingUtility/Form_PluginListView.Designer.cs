namespace t7dwidm_protect
{
    partial class Plugins
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
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.listBox_Plugins = new System.Windows.Forms.ListBox();
            this.context_Plugins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.chk_FriendsOnly = new System.Windows.Forms.CheckBox();
            this.btn_AddPlugin = new FontAwesome.Sharp.IconButton();
            this.btn_RemovePlugin = new FontAwesome.Sharp.IconButton();
            this.context_Plugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(432, 1);
            this.panel_TitleBar.TabIndex = 1;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(12, 17);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(118, 40);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Plugins";
            // 
            // listBox_Plugins
            // 
            this.listBox_Plugins.AllowDrop = true;
            this.listBox_Plugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.listBox_Plugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Plugins.ContextMenuStrip = this.context_Plugins;
            this.listBox_Plugins.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.listBox_Plugins.ForeColor = System.Drawing.Color.White;
            this.listBox_Plugins.FormattingEnabled = true;
            this.listBox_Plugins.ItemHeight = 21;
            this.listBox_Plugins.Location = new System.Drawing.Point(19, 65);
            this.listBox_Plugins.Name = "listBox_Plugins";
            this.listBox_Plugins.Size = new System.Drawing.Size(393, 147);
            this.listBox_Plugins.TabIndex = 3;
            this.listBox_Plugins.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_Plugins_DragDrop);
            this.listBox_Plugins.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_Plugins_DragEnter);
            this.listBox_Plugins.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_Plugins_KeyDown);
            // 
            // context_Plugins
            // 
            this.context_Plugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPluginToolStripMenuItem,
            this.removePluginToolStripMenuItem});
            this.context_Plugins.Name = "context_Plugins";
            this.context_Plugins.Size = new System.Drawing.Size(155, 48);
            // 
            // addPluginToolStripMenuItem
            // 
            this.addPluginToolStripMenuItem.Name = "addPluginToolStripMenuItem";
            this.addPluginToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addPluginToolStripMenuItem.Text = "Add Plugin";
            this.addPluginToolStripMenuItem.Click += new System.EventHandler(this.addPluginToolStripMenuItem_Click);
            // 
            // removePluginToolStripMenuItem
            // 
            this.removePluginToolStripMenuItem.Name = "removePluginToolStripMenuItem";
            this.removePluginToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removePluginToolStripMenuItem.Text = "Remove Plugin";
            this.removePluginToolStripMenuItem.Click += new System.EventHandler(this.removePluginToolStripMenuItem_Click);
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
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chk_FriendsOnly
            // 
            this.chk_FriendsOnly.AutoSize = true;
            this.chk_FriendsOnly.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.chk_FriendsOnly.ForeColor = System.Drawing.Color.White;
            this.chk_FriendsOnly.Location = new System.Drawing.Point(19, 218);
            this.chk_FriendsOnly.Name = "chk_FriendsOnly";
            this.chk_FriendsOnly.Size = new System.Drawing.Size(119, 25);
            this.chk_FriendsOnly.TabIndex = 5;
            this.chk_FriendsOnly.Text = "Friends Only";
            this.chk_FriendsOnly.UseVisualStyleBackColor = true;
            this.chk_FriendsOnly.CheckedChanged += new System.EventHandler(this.chk_FriendsOnly_CheckedChanged);
            // 
            // btn_AddPlugin
            // 
            this.btn_AddPlugin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_AddPlugin.FlatAppearance.BorderSize = 0;
            this.btn_AddPlugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPlugin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_AddPlugin.ForeColor = System.Drawing.Color.White;
            this.btn_AddPlugin.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btn_AddPlugin.IconColor = System.Drawing.Color.White;
            this.btn_AddPlugin.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btn_AddPlugin.IconSize = 18;
            this.btn_AddPlugin.Location = new System.Drawing.Point(386, 218);
            this.btn_AddPlugin.Name = "btn_AddPlugin";
            this.btn_AddPlugin.Size = new System.Drawing.Size(26, 25);
            this.btn_AddPlugin.TabIndex = 11;
            this.btn_AddPlugin.UseVisualStyleBackColor = false;
            this.btn_AddPlugin.Click += new System.EventHandler(this.btn_AddPlugin_Click);
            // 
            // btn_RemovePlugin
            // 
            this.btn_RemovePlugin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_RemovePlugin.FlatAppearance.BorderSize = 0;
            this.btn_RemovePlugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemovePlugin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_RemovePlugin.ForeColor = System.Drawing.Color.White;
            this.btn_RemovePlugin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_RemovePlugin.IconColor = System.Drawing.Color.White;
            this.btn_RemovePlugin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RemovePlugin.IconSize = 18;
            this.btn_RemovePlugin.Location = new System.Drawing.Point(354, 218);
            this.btn_RemovePlugin.Name = "btn_RemovePlugin";
            this.btn_RemovePlugin.Size = new System.Drawing.Size(26, 25);
            this.btn_RemovePlugin.TabIndex = 12;
            this.btn_RemovePlugin.UseVisualStyleBackColor = false;
            this.btn_RemovePlugin.Click += new System.EventHandler(this.btn_RemovePlugin_Click);
            // 
            // Plugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(432, 254);
            this.Controls.Add(this.btn_RemovePlugin);
            this.Controls.Add(this.chk_FriendsOnly);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBox_Plugins);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.btn_AddPlugin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Plugins";
            this.Text = "Plugins";
            this.Load += new System.EventHandler(this.Plugins_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Plugins_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Plugins_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Plugins_MouseUp);
            this.context_Plugins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ListBox listBox_Plugins;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip context_Plugins;
        private System.Windows.Forms.ToolStripMenuItem addPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePluginToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_FriendsOnly;
        private FontAwesome.Sharp.IconButton btn_AddPlugin;
        private FontAwesome.Sharp.IconButton btn_RemovePlugin;
    }
}