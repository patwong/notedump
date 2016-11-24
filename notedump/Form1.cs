using System;
using System.IO;
using System.Reflection;
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
        //figure out dynamic tab system later
        //will hardcode important tabs first
        
        /*
         * public partial class MenuTab : TabPage
        {
            //i do something
        }
        public partial class SubTab : TabPage
        {
            //i do something
        }
        */
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

        private void tabMusicAll_DoubleClick(object sender, EventArgs e)
        {
            //doubleclicked the tab, now have it open a textbox and open a file
        }

        private void tabControlMusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (tabControlMusic.SelectedTab == tabMusicAll)            
            {
                RichTextBox musicAllBox = new RichTextBox();

                //dock dynamically resizes on whatever the form does
                musicAllBox.Dock = DockStyle.Fill;

                //size = size only resizes to its container once
                // musicAllBox.Size = tabMusicAll.Size; 

                tabMusicAll.Controls.Add(musicAllBox); //do i need this?

                //string rootdir = Application.StartupPath;
                //rootdir = rootdir + "/cat"; //works - concats "/cat" to rootdir
                //Console.WriteLine(rootdir);

                musicAllBox.Text = Properties.Resources.musicall1;
                //musicAllBox.LoadFile(txtfile , RichTextBoxStreamType.PlainText);                               
            }
        }
        private void tabSub_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TabControl eventControl = (TabControl)sender;
            TabPage eventPage = eventControl.SelectedTab;
            RichTextBox pageRTB = new RichTextBox();
            eventPage.Controls.Add(pageRTB); //do i need this?
            pageRTB.Dock = DockStyle.Fill;
        }

        private void NDFlushButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tabLinksAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi!");
        }

        private void tabControlMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
