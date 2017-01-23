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
            this.MenuStrip_GetStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_saveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_saveAllExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabMainTD = new System.Windows.Forms.TabPage();
            this.tabControlTD = new System.Windows.Forms.TabControl();
            this.tabTDRemind = new System.Windows.Forms.TabPage();
            this.tabTDTD = new System.Windows.Forms.TabPage();
            this.tabMainMusic = new System.Windows.Forms.TabPage();
            this.tabControlMusic = new System.Windows.Forms.TabControl();
            this.tabMusicAll = new System.Windows.Forms.TabPage();
            this.tabMusicIndie = new System.Windows.Forms.TabPage();
            this.tabMusicMetal = new System.Windows.Forms.TabPage();
            this.tabMusicPlus = new System.Windows.Forms.TabPage();
            this.tabMainLinks = new System.Windows.Forms.TabPage();
            this.tabControlLinks = new System.Windows.Forms.TabControl();
            this.tabLinksAll = new System.Windows.Forms.TabPage();
            this.tabLinksYT = new System.Windows.Forms.TabPage();
            this.tabLinksArticles = new System.Windows.Forms.TabPage();
            this.tabLinksPlus = new System.Windows.Forms.TabPage();
            this.tabMainMovies = new System.Windows.Forms.TabPage();
            this.tabMainPlus = new System.Windows.Forms.TabPage();
            this.NDtextBox = new System.Windows.Forms.TextBox();
            this.NDFlushButton = new System.Windows.Forms.Button();
            this.NDstatusStrip = new System.Windows.Forms.StatusStrip();
            this.NDstatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMainGet = new System.Windows.Forms.TabPage();
            this.tabControlGet = new System.Windows.Forms.TabControl();
            this.tabGetMovies = new System.Windows.Forms.TabPage();
            this.tabGetGames = new System.Windows.Forms.TabPage();
            this.tabGetAnime = new System.Windows.Forms.TabPage();
            this.tabGetBooks = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabMainTD.SuspendLayout();
            this.tabControlTD.SuspendLayout();
            this.tabMainMusic.SuspendLayout();
            this.tabControlMusic.SuspendLayout();
            this.tabMainLinks.SuspendLayout();
            this.tabControlLinks.SuspendLayout();
            this.NDstatusStrip.SuspendLayout();
            this.tabMainGet.SuspendLayout();
            this.tabControlGet.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_GetStatus,
            this.MenuStrip_saveAll,
            this.MenuStrip_saveAllExit,
            this.MenuStrip_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // MenuStrip_GetStatus
            // 
            this.MenuStrip_GetStatus.Name = "MenuStrip_GetStatus";
            this.MenuStrip_GetStatus.Size = new System.Drawing.Size(226, 30);
            this.MenuStrip_GetStatus.Text = "Get Status";
            this.MenuStrip_GetStatus.Click += new System.EventHandler(this.get_active_tab);
            // 
            // MenuStrip_saveAll
            // 
            this.MenuStrip_saveAll.Name = "MenuStrip_saveAll";
            this.MenuStrip_saveAll.Size = new System.Drawing.Size(226, 30);
            this.MenuStrip_saveAll.Text = "Save All";
            this.MenuStrip_saveAll.Click += new System.EventHandler(this.saveAllClick);
            // 
            // MenuStrip_saveAllExit
            // 
            this.MenuStrip_saveAllExit.Name = "MenuStrip_saveAllExit";
            this.MenuStrip_saveAllExit.Size = new System.Drawing.Size(226, 30);
            this.MenuStrip_saveAllExit.Text = "Save All and Exit";
            this.MenuStrip_saveAllExit.Click += new System.EventHandler(this.saveAllAndExitToolStripMenuItem_Click);
            // 
            // MenuStrip_exit
            // 
            this.MenuStrip_exit.Name = "MenuStrip_exit";
            this.MenuStrip_exit.Size = new System.Drawing.Size(226, 30);
            this.MenuStrip_exit.Text = "Exit";
            this.MenuStrip_exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabMainTD);
            this.tabControlMain.Controls.Add(this.tabMainMusic);
            this.tabControlMain.Controls.Add(this.tabMainLinks);
            this.tabControlMain.Controls.Add(this.tabMainGet);
            this.tabControlMain.Controls.Add(this.tabMainMovies);
            this.tabControlMain.Controls.Add(this.tabMainPlus);
            this.tabControlMain.Location = new System.Drawing.Point(12, 43);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(963, 283);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControls_SelectedIndexChanged);
            this.tabControlMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControlMain_MouseDoubleClick);
            // 
            // tabMainTD
            // 
            this.tabMainTD.Controls.Add(this.tabControlTD);
            this.tabMainTD.Location = new System.Drawing.Point(4, 29);
            this.tabMainTD.Name = "tabMainTD";
            this.tabMainTD.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainTD.Size = new System.Drawing.Size(955, 250);
            this.tabMainTD.TabIndex = 4;
            this.tabMainTD.Text = "To Do";
            this.tabMainTD.UseVisualStyleBackColor = true;
            // 
            // tabControlTD
            // 
            this.tabControlTD.Controls.Add(this.tabTDRemind);
            this.tabControlTD.Controls.Add(this.tabTDTD);
            this.tabControlTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTD.Location = new System.Drawing.Point(3, 3);
            this.tabControlTD.Name = "tabControlTD";
            this.tabControlTD.SelectedIndex = 0;
            this.tabControlTD.Size = new System.Drawing.Size(949, 244);
            this.tabControlTD.TabIndex = 0;
            this.tabControlTD.SelectedIndexChanged += new System.EventHandler(this.tabControls_SelectedIndexChanged);
            this.tabControlTD.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabSub_MouseDoubleClick);
            // 
            // tabTDRemind
            // 
            this.tabTDRemind.Location = new System.Drawing.Point(4, 29);
            this.tabTDRemind.Name = "tabTDRemind";
            this.tabTDRemind.Padding = new System.Windows.Forms.Padding(3);
            this.tabTDRemind.Size = new System.Drawing.Size(941, 211);
            this.tabTDRemind.TabIndex = 0;
            this.tabTDRemind.Text = "Reminders";
            this.tabTDRemind.UseVisualStyleBackColor = true;
            // 
            // tabTDTD
            // 
            this.tabTDTD.Location = new System.Drawing.Point(4, 29);
            this.tabTDTD.Name = "tabTDTD";
            this.tabTDTD.Padding = new System.Windows.Forms.Padding(3);
            this.tabTDTD.Size = new System.Drawing.Size(941, 211);
            this.tabTDTD.TabIndex = 1;
            this.tabTDTD.Text = "To Do";
            this.tabTDTD.UseVisualStyleBackColor = true;
            // 
            // tabMainMusic
            // 
            this.tabMainMusic.Controls.Add(this.tabControlMusic);
            this.tabMainMusic.Location = new System.Drawing.Point(4, 29);
            this.tabMainMusic.Name = "tabMainMusic";
            this.tabMainMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainMusic.Size = new System.Drawing.Size(955, 250);
            this.tabMainMusic.TabIndex = 0;
            this.tabMainMusic.Text = "Music";
            this.tabMainMusic.UseVisualStyleBackColor = true;
            // 
            // tabControlMusic
            // 
            this.tabControlMusic.Controls.Add(this.tabMusicAll);
            this.tabControlMusic.Controls.Add(this.tabMusicIndie);
            this.tabControlMusic.Controls.Add(this.tabMusicMetal);
            this.tabControlMusic.Controls.Add(this.tabMusicPlus);
            this.tabControlMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMusic.Location = new System.Drawing.Point(3, 3);
            this.tabControlMusic.Name = "tabControlMusic";
            this.tabControlMusic.SelectedIndex = 0;
            this.tabControlMusic.Size = new System.Drawing.Size(949, 244);
            this.tabControlMusic.TabIndex = 0;
            this.tabControlMusic.SelectedIndexChanged += new System.EventHandler(this.tabControls_SelectedIndexChanged);
            this.tabControlMusic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabSub_MouseDoubleClick);
            // 
            // tabMusicAll
            // 
            this.tabMusicAll.Location = new System.Drawing.Point(4, 29);
            this.tabMusicAll.Name = "tabMusicAll";
            this.tabMusicAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusicAll.Size = new System.Drawing.Size(941, 211);
            this.tabMusicAll.TabIndex = 0;
            this.tabMusicAll.Text = "All";
            this.tabMusicAll.UseVisualStyleBackColor = true;
            // 
            // tabMusicIndie
            // 
            this.tabMusicIndie.Location = new System.Drawing.Point(4, 29);
            this.tabMusicIndie.Name = "tabMusicIndie";
            this.tabMusicIndie.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusicIndie.Size = new System.Drawing.Size(941, 211);
            this.tabMusicIndie.TabIndex = 2;
            this.tabMusicIndie.Text = "Indie";
            this.tabMusicIndie.UseVisualStyleBackColor = true;
            // 
            // tabMusicMetal
            // 
            this.tabMusicMetal.Location = new System.Drawing.Point(4, 29);
            this.tabMusicMetal.Name = "tabMusicMetal";
            this.tabMusicMetal.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusicMetal.Size = new System.Drawing.Size(941, 211);
            this.tabMusicMetal.TabIndex = 3;
            this.tabMusicMetal.Text = "Metal";
            this.tabMusicMetal.UseVisualStyleBackColor = true;
            // 
            // tabMusicPlus
            // 
            this.tabMusicPlus.Location = new System.Drawing.Point(4, 29);
            this.tabMusicPlus.Name = "tabMusicPlus";
            this.tabMusicPlus.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusicPlus.Size = new System.Drawing.Size(941, 211);
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
            this.tabMainLinks.Size = new System.Drawing.Size(955, 250);
            this.tabMainLinks.TabIndex = 1;
            this.tabMainLinks.Text = "Links";
            this.tabMainLinks.UseVisualStyleBackColor = true;
            // 
            // tabControlLinks
            // 
            this.tabControlLinks.Controls.Add(this.tabLinksAll);
            this.tabControlLinks.Controls.Add(this.tabLinksYT);
            this.tabControlLinks.Controls.Add(this.tabLinksArticles);
            this.tabControlLinks.Controls.Add(this.tabLinksPlus);
            this.tabControlLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLinks.Location = new System.Drawing.Point(3, 3);
            this.tabControlLinks.Name = "tabControlLinks";
            this.tabControlLinks.SelectedIndex = 0;
            this.tabControlLinks.Size = new System.Drawing.Size(949, 244);
            this.tabControlLinks.TabIndex = 0;
            this.tabControlLinks.SelectedIndexChanged += new System.EventHandler(this.tabControls_SelectedIndexChanged);
            this.tabControlLinks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabSub_MouseDoubleClick);
            // 
            // tabLinksAll
            // 
            this.tabLinksAll.Location = new System.Drawing.Point(4, 29);
            this.tabLinksAll.Name = "tabLinksAll";
            this.tabLinksAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabLinksAll.Size = new System.Drawing.Size(941, 211);
            this.tabLinksAll.TabIndex = 0;
            this.tabLinksAll.Text = "All";
            this.tabLinksAll.UseVisualStyleBackColor = true;
            // 
            // tabLinksYT
            // 
            this.tabLinksYT.Location = new System.Drawing.Point(4, 29);
            this.tabLinksYT.Name = "tabLinksYT";
            this.tabLinksYT.Padding = new System.Windows.Forms.Padding(3);
            this.tabLinksYT.Size = new System.Drawing.Size(941, 211);
            this.tabLinksYT.TabIndex = 2;
            this.tabLinksYT.Text = "YouTube";
            this.tabLinksYT.UseVisualStyleBackColor = true;
            // 
            // tabLinksArticles
            // 
            this.tabLinksArticles.Location = new System.Drawing.Point(4, 29);
            this.tabLinksArticles.Name = "tabLinksArticles";
            this.tabLinksArticles.Padding = new System.Windows.Forms.Padding(3);
            this.tabLinksArticles.Size = new System.Drawing.Size(941, 211);
            this.tabLinksArticles.TabIndex = 3;
            this.tabLinksArticles.Text = "Articles";
            this.tabLinksArticles.UseVisualStyleBackColor = true;
            // 
            // tabLinksPlus
            // 
            this.tabLinksPlus.Location = new System.Drawing.Point(4, 29);
            this.tabLinksPlus.Name = "tabLinksPlus";
            this.tabLinksPlus.Padding = new System.Windows.Forms.Padding(3);
            this.tabLinksPlus.Size = new System.Drawing.Size(941, 211);
            this.tabLinksPlus.TabIndex = 1;
            this.tabLinksPlus.Text = "+";
            this.tabLinksPlus.UseVisualStyleBackColor = true;
            // 
            // tabMainMovies
            // 
            this.tabMainMovies.Location = new System.Drawing.Point(4, 29);
            this.tabMainMovies.Name = "tabMainMovies";
            this.tabMainMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainMovies.Size = new System.Drawing.Size(955, 250);
            this.tabMainMovies.TabIndex = 3;
            this.tabMainMovies.Text = "Movies";
            this.tabMainMovies.UseVisualStyleBackColor = true;
            // 
            // tabMainPlus
            // 
            this.tabMainPlus.Location = new System.Drawing.Point(4, 29);
            this.tabMainPlus.Name = "tabMainPlus";
            this.tabMainPlus.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPlus.Size = new System.Drawing.Size(955, 250);
            this.tabMainPlus.TabIndex = 2;
            this.tabMainPlus.Text = "+";
            this.tabMainPlus.UseVisualStyleBackColor = true;
            // 
            // NDtextBox
            // 
            this.NDtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NDtextBox.Location = new System.Drawing.Point(16, 341);
            this.NDtextBox.Multiline = true;
            this.NDtextBox.Name = "NDtextBox";
            this.NDtextBox.Size = new System.Drawing.Size(803, 98);
            this.NDtextBox.TabIndex = 2;
            // 
            // NDFlushButton
            // 
            this.NDFlushButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NDFlushButton.Location = new System.Drawing.Point(859, 349);
            this.NDFlushButton.Name = "NDFlushButton";
            this.NDFlushButton.Size = new System.Drawing.Size(117, 80);
            this.NDFlushButton.TabIndex = 3;
            this.NDFlushButton.Text = "Flush";
            this.NDFlushButton.UseVisualStyleBackColor = true;
            this.NDFlushButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NDFlushButton_MouseClick_Factored);
            // 
            // NDstatusStrip
            // 
            this.NDstatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.NDstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NDstatusStripLabel});
            this.NDstatusStrip.Location = new System.Drawing.Point(0, 448);
            this.NDstatusStrip.Name = "NDstatusStrip";
            this.NDstatusStrip.Size = new System.Drawing.Size(988, 30);
            this.NDstatusStrip.TabIndex = 4;
            this.NDstatusStrip.Text = "NDstatusStrip";
            // 
            // NDstatusStripLabel
            // 
            this.NDstatusStripLabel.Name = "NDstatusStripLabel";
            this.NDstatusStripLabel.Size = new System.Drawing.Size(126, 25);
            this.NDstatusStripLabel.Text = "None Selected";
            // 
            // tabMainGet
            // 
            this.tabMainGet.Controls.Add(this.tabControlGet);
            this.tabMainGet.Location = new System.Drawing.Point(4, 29);
            this.tabMainGet.Name = "tabMainGet";
            this.tabMainGet.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainGet.Size = new System.Drawing.Size(955, 250);
            this.tabMainGet.TabIndex = 5;
            this.tabMainGet.Text = "Get";
            this.tabMainGet.UseVisualStyleBackColor = true;
            // 
            // tabControlGet
            // 
            this.tabControlGet.Controls.Add(this.tabGetMovies);
            this.tabControlGet.Controls.Add(this.tabGetGames);
            this.tabControlGet.Controls.Add(this.tabGetAnime);
            this.tabControlGet.Controls.Add(this.tabGetBooks);
            this.tabControlGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGet.Location = new System.Drawing.Point(3, 3);
            this.tabControlGet.Name = "tabControlGet";
            this.tabControlGet.SelectedIndex = 0;
            this.tabControlGet.Size = new System.Drawing.Size(949, 244);
            this.tabControlGet.TabIndex = 0;
            this.tabControlGet.SelectedIndexChanged += new System.EventHandler(this.tabControls_SelectedIndexChanged);
            this.tabControlGet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabSub_MouseDoubleClick);
            // 
            // tabGetMovies
            // 
            this.tabGetMovies.Location = new System.Drawing.Point(4, 29);
            this.tabGetMovies.Name = "tabGetMovies";
            this.tabGetMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabGetMovies.Size = new System.Drawing.Size(941, 211);
            this.tabGetMovies.TabIndex = 0;
            this.tabGetMovies.Text = "Movies";
            this.tabGetMovies.UseVisualStyleBackColor = true;
            // 
            // tabGetGames
            // 
            this.tabGetGames.Location = new System.Drawing.Point(4, 29);
            this.tabGetGames.Name = "tabGetGames";
            this.tabGetGames.Padding = new System.Windows.Forms.Padding(3);
            this.tabGetGames.Size = new System.Drawing.Size(941, 211);
            this.tabGetGames.TabIndex = 1;
            this.tabGetGames.Text = "Games";
            this.tabGetGames.UseVisualStyleBackColor = true;
            // 
            // tabGetAnime
            // 
            this.tabGetAnime.Location = new System.Drawing.Point(4, 29);
            this.tabGetAnime.Name = "tabGetAnime";
            this.tabGetAnime.Size = new System.Drawing.Size(941, 211);
            this.tabGetAnime.TabIndex = 2;
            this.tabGetAnime.Text = "Anime";
            this.tabGetAnime.UseVisualStyleBackColor = true;
            // 
            // tabGetBooks
            // 
            this.tabGetBooks.Location = new System.Drawing.Point(4, 29);
            this.tabGetBooks.Name = "tabGetBooks";
            this.tabGetBooks.Size = new System.Drawing.Size(941, 211);
            this.tabGetBooks.TabIndex = 3;
            this.tabGetBooks.Text = "Books";
            this.tabGetBooks.UseVisualStyleBackColor = true;
            // 
            // NotedumpMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 478);
            this.Controls.Add(this.NDstatusStrip);
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
            this.tabMainTD.ResumeLayout(false);
            this.tabControlTD.ResumeLayout(false);
            this.tabMainMusic.ResumeLayout(false);
            this.tabControlMusic.ResumeLayout(false);
            this.tabMainLinks.ResumeLayout(false);
            this.tabControlLinks.ResumeLayout(false);
            this.NDstatusStrip.ResumeLayout(false);
            this.NDstatusStrip.PerformLayout();
            this.tabMainGet.ResumeLayout(false);
            this.tabControlGet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_GetStatus;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_exit;
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
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_saveAllExit;
        private System.Windows.Forms.TabPage tabLinksYT;
        private System.Windows.Forms.TabPage tabLinksArticles;
        private System.Windows.Forms.TabPage tabMainMovies;
        private System.Windows.Forms.TabPage tabMusicIndie;
        private System.Windows.Forms.TabPage tabMusicMetal;
        private System.Windows.Forms.TabPage tabMainTD;
        private System.Windows.Forms.TabControl tabControlTD;
        private System.Windows.Forms.TabPage tabTDRemind;
        private System.Windows.Forms.TabPage tabTDTD;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_saveAll;
        private System.Windows.Forms.StatusStrip NDstatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel NDstatusStripLabel;
        private System.Windows.Forms.TabPage tabMainGet;
        private System.Windows.Forms.TabControl tabControlGet;
        private System.Windows.Forms.TabPage tabGetMovies;
        private System.Windows.Forms.TabPage tabGetGames;
        private System.Windows.Forms.TabPage tabGetAnime;
        private System.Windows.Forms.TabPage tabGetBooks;
    }
}

