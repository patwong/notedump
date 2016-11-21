using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notedump
{
    public partial class NotedumpMainForm : Form
    {
        public NotedumpMainForm()
        {
            InitializeComponent();
        }

        //tab code
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlMain.SelectedTab == tabMainPlus)
            {
                string title = "MainTab" + (tabControlMain.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                tabControlMain.TabPages.Insert(tabControlMain.TabPages.Count - 1, createdTabPage);
                tabControlMain.SelectedTab = createdTabPage;
            }
        }

        private void tabControlMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMusic.SelectedTab == tabMusicPlus)
            {
                string title = "MusicTab" + (tabControlMusic.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                tabControlMusic.TabPages.Insert(tabControlMusic.TabPages.Count - 1, createdTabPage);
                tabControlMusic.SelectedTab = createdTabPage;
            }
        }

        private void tabControlLinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlLinks.SelectedTab == tabLinksPlus)
            {
                string title = "LinksTab" + (tabControlLinks.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                tabControlLinks.TabPages.Insert(tabControlLinks.TabPages.Count - 1, createdTabPage);
                tabControlLinks.SelectedTab = createdTabPage;
            }
        }

        private void tabControlMusic_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControlMusic.SelectedTab == tabMusicAll)
            {
                Console.WriteLine("you selected Music_All");
            }
        }

        private void tabMusicAll_Click(object sender, EventArgs e)
        {

        }

        private void tabMusicAll_DoubleClick(object sender, EventArgs e)
        {
            //doubleclicked the tab, now have it open a textbox and open a file
        }

        private void tabControlMusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tabControlMusic.SelectedTab == tabMusicAll)
            {
                RichTextBox musicAllBox = new RichTextBox();
                musicAllBox.Dock = DockStyle.Fill;
                // musicAllBox.Size = tabMusicAll.Size;
                tabMusicAll.Controls.Add(musicAllBox);
            }
        }


    }
}
