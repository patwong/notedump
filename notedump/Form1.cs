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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlMain.SelectedTab == tabMainPlus)
            {
                string title = "MainTab " + (tabControlMain.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                //tabControlMain.TabPages.Add(createdTabPage);
                tabControlMain.TabPages.Insert(tabControlMain.TabPages.Count - 1, createdTabPage);
                tabControlMain.SelectedTab = createdTabPage;
            }
        }

        private void tabControlMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMusic.SelectedTab == tabMusicPlus)
            {
                string title = "MusicTab " + (tabControlMusic.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                //tabControlMain.TabPages.Add(createdTabPage);
                tabControlMusic.TabPages.Insert(tabControlMusic.TabPages.Count - 1, createdTabPage);
                tabControlMusic.SelectedTab = createdTabPage;
            }
        }

        private void tabControlLinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlLinks.SelectedTab == tabLinksPlus)
            {
                string title = "LinksTab " + (tabControlLinks.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                //tabControlMain.TabPages.Add(createdTabPage);
                tabControlLinks.TabPages.Insert(tabControlLinks.TabPages.Count - 1, createdTabPage);
                tabControlLinks.SelectedTab = createdTabPage;
            }
        }
    }
}
