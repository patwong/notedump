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

        //Menu Strip code
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exits without saving
            this.Close();
        }

        private void saveAllAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /**************************************************/
            /* obviously saves all open textboxes and         */
            /* flushes them all out to respective files       */
            /**************************************************/

            //need to include code where all open textboxes flushed out 
            //to respective files
            //read only textboxes?
            //problem 1: cannot pick and choose tab to include dumped items
            this.Close();
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


    }
}
