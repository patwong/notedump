namespace notedump
{
    partial class NotedumpMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabMainMusic = new System.Windows.Forms.TabPage();
            this.tabControlMusic = new System.Windows.Forms.TabControl();
            this.tabMusicAll = new System.Windows.Forms.TabPage();
            this.tabMusicPlus = new System.Windows.Forms.TabPage();
            this.tabMainLinks = new System.Windows.Forms.TabPage();
            this.tabControlLinks = new System.Windows.Forms.TabControl();
            this.tabLinksAll = new System.Windows.Forms.TabPage();
            this.tabLinksPlus = new System.Windows.Forms.TabPage();
            this.tabMainPlus = new System.Windows.Forms.TabPage();
            this.NDtextBox = new System.Windows.Forms.TextBox();
            this.NDFlushButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabMainMusic.SuspendLayout();
            this.tabControlMusic.SuspendLayout();
            this.tabMainLinks.SuspendLayout();
            this.tabControlLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(58, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAllAndExitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveAllAndExitToolStripMenuItem
            // 
            this.saveAllAndExitToolStripMenuItem.Name = "saveAllAndExitToolStripMenuItem";
            this.saveAllAndExitToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.saveAllAndExitToolStripMenuItem.Text = "Save All and Exit";
            this.saveAllAndExitToolStripMenuItem.Click += new System.EventHandler(this.saveAllAndExitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabMainMusic);
            this.tabControlMain.Controls.Add(this.tabMainLinks);
            this.tabControlMain.Controls.Add(this.tabMainPlus);
            this.tabControlMain.Location = new System.Drawing.Point(16, 55);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(959, 264);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabMainMusic
            // 
            this.tabMainMusic.Controls.Add(this.tabControlMusic);
            this.tabMainMusic.Location = new System.Drawing.Point(4, 29);
            this.tabMainMusic.Name = "tabMainMusic";
            this.tabMainMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainMusic.Size = new System.Drawing.Size(951, 231);
            this.tabMainMusic.TabIndex = 0;
            this.tabMainMusic.Text = "Music";
            this.tabMainMusic.UseVisualStyleBackColor = true;
            // 
            // tabControlMusic
            // 
            this.tabControlMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMusic.Controls.Add(this.tabMusicAll);
            this.tabControlMusic.Controls.Add(this.tabMusicPlus);
            this.tabControlMusic.Location = new System.Drawing.Point(-4, 0);
            this.tabControlMusic.Name = "tabControlMusic";
            this.tabControlMusic.SelectedIndex = 0;
            this.tabControlMusic.Size = new System.Drawing.Size(959, 235);
            this.tabControlMusic.TabIndex = 0;
            this.tabControlMusic.SelectedIndexChanged += new System.EventHandler(this.tabControlMusic_SelectedIndexChanged);
            this.tabControlMusic.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlMusic_Selecting);
            this.tabControlMusic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControlMusic_MouseDoubleClick);
            // 
            // tabMusicAll
            // 
            this.tabMusicAll.Location = new System.Drawing.Point(4, 29);
            this.tabMusicAll.Name = "tabMusicAll";
            this.tabMusicAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusicAll.Size = new System.Drawing.Size(951, 202);
            this.tabMusicAll.TabIndex = 0;
            this.tabMusicAll.Text = "All";
            this.tabMusicAll.UseVisualStyleBackColor = true;
            this.tabMusicAll.Click += new System.EventHandler(this.tabMusicAll_Click);
            this.tabMusicAll.DoubleClick += new System.EventHandler(this.tabMusicAll_DoubleClick);
            // 
            // tabMusicPlus
            // 
            this.tabMusicPlus.Location = new System.Drawing.Point(4, 29);
            this.tabMusicPlus.Name = "tabMusicPlus";
            this.tabMusicPlus.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusicPlus.Size = new System.Drawing.Size(951, 202);
            this.tabMusicPlus.TabIndex = 1;
            this.tabMusicPlus.Text = "+";
            this.tabMusicPlus.UseVisualStyleBackColor = true;
            // 
            // tabMainLinks
            // 
            this.tabMainLinks.Controls.Add(this.tabControlLinks);
            this.tabMainLinks.Location = new System.Drawing.Point(4, 29);
            this.tabMainLinks.Name = "tabMainLinks";
            this.tabMainLinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainLinks.Size = new System.Drawing.Size(951, 231);
            this.tabMainLinks.TabIndex = 1;
            this.tabMainLinks.Text = "Links";
            this.tabMainLinks.UseVisualStyleBackColor = true;
            // 
            // tabControlLinks
            // 
            this.tabControlLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlLinks.Controls.Add(this.tabLinksAll);
            this.tabControlLinks.Controls.Add(this.tabLinksPlus);
            this.tabControlLinks.Location = new System.Drawing.Point(-4, 0);
            this.tabControlLinks.Name = "tabControlLinks";
            this.tabControlLinks.SelectedIndex = 0;
            this.tabControlLinks.Size = new System.Drawing.Size(959, 235);
            this.tabControlLinks.TabIndex = 0;
            this.tabControlLinks.SelectedIndexChanged += new System.EventHandler(this.tabControlLinks_SelectedIndexChanged);
            // 
            // tabLinksAll
            // 
            this.tabLinksAll.Location = new System.Drawing.Point(4, 29);
            this.tabLinksAll.Name = "tabLinksAll";
            this.tabLinksAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabLinksAll.Size = new System.Drawing.Size(951, 202);
            this.tabLinksAll.TabIndex = 0;
            this.tabLinksAll.Text = "All";
            this.tabLinksAll.UseVisualStyleBackColor = true;
            // 
            // tabLinksPlus
            // 
            this.tabLinksPlus.Location = new System.Drawing.Point(4, 29);
            this.tabLinksPlus.Name = "tabLinksPlus";
            this.tabLinksPlus.Padding = new System.Windows.Forms.Padding(3);
            this.tabLinksPlus.Size = new System.Drawing.Size(958, 202);
            this.tabLinksPlus.TabIndex = 1;
            this.tabLinksPlus.Text = "+";
            this.tabLinksPlus.UseVisualStyleBackColor = true;
            // 
            // tabMainPlus
            // 
            this.tabMainPlus.Location = new System.Drawing.Point(4, 29);
            this.tabMainPlus.Name = "tabMainPlus";
            this.tabMainPlus.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPlus.Size = new System.Drawing.Size(951, 231);
            this.tabMainPlus.TabIndex = 2;
            this.tabMainPlus.Text = "+";
            this.tabMainPlus.UseVisualStyleBackColor = true;
            // 
            // NDtextBox
            // 
            this.NDtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NDtextBox.Location = new System.Drawing.Point(16, 337);
            this.NDtextBox.Multiline = true;
            this.NDtextBox.Name = "NDtextBox";
            this.NDtextBox.Size = new System.Drawing.Size(803, 98);
            this.NDtextBox.TabIndex = 2;
            // 
            // NDFlushButton
            // 
            this.NDFlushButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NDFlushButton.Location = new System.Drawing.Point(854, 355);
            this.NDFlushButton.Name = "NDFlushButton";
            this.NDFlushButton.Size = new System.Drawing.Size(117, 80);
            this.NDFlushButton.TabIndex = 3;
            this.NDFlushButton.Text = "Flush";
            this.NDFlushButton.UseVisualStyleBackColor = true;
            // 
            // NotedumpMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 447);
            this.Controls.Add(this.NDFlushButton);
            this.Controls.Add(this.NDtextBox);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotedumpMainForm";
            this.Text = "Notedump";
            this.Resize += new System.EventHandler(this.NotedumpMainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabMainMusic.ResumeLayout(false);
            this.tabControlMusic.ResumeLayout(false);
            this.tabMainLinks.ResumeLayout(false);
            this.tabControlLinks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabMainMusic;
        private System.Windows.Forms.TabPage tabMainLinks;
        private System.Windows.Forms.TextBox NDtextBox;
        private System.Windows.Forms.Button NDFlushButton;
        private System.Windows.Forms.TabControl tabControlMusic;
        private System.Windows.Forms.TabPage tabMusicAll;
        private System.Windows.Forms.TabPage tabMusicPlus;
        private System.Windows.Forms.TabControl tabControlLinks;
        private System.Windows.Forms.TabPage tabLinksAll;
        private System.Windows.Forms.TabPage tabLinksPlus;
        private System.Windows.Forms.TabPage tabMainPlus;
        private System.Windows.Forms.ToolStripMenuItem saveAllAndExitToolStripMenuItem;
    }
}

