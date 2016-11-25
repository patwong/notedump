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
        private void tabControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool RealSelectedTab = false;
            string tabName = "";
            TabControl tabControlEvent = (TabControl)sender;
            if (tabControlMain.SelectedTab == tabMainPlus)
            {
                tabName = "MainTab";
                RealSelectedTab = true;
            }
            else if (tabControlMusic.SelectedTab == tabMusicPlus)
            {
                tabName = "MusicTab";
                RealSelectedTab = true;
            }
            else if (tabControlLinks.SelectedTab == tabLinksPlus)
            {
                tabName = "LinksTab";
                RealSelectedTab = true;
            }
            if (RealSelectedTab)
            {
                tabName = tabName + (tabControlEvent.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(tabName);
                tabControlEvent.TabPages.Insert(tabControlEvent.TabPages.Count - 1, createdTabPage);
                tabControlEvent.SelectedTab = createdTabPage;
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
