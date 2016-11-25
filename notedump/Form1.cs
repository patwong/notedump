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
            if (tabControlEvent == tabControlMain)
            {
                if (tabControlMain.SelectedTab == tabMainPlus)
                {
                    tabName = "MainTab";
                    RealSelectedTab = true;
                }
            }
            else if (tabControlEvent == tabControlMusic)
            {
                if (tabControlMusic.SelectedTab == tabMusicPlus)
                {
                    tabName = "MusicTab";
                    RealSelectedTab = true;
                }
            }
            else if (tabControlEvent == tabControlLinks)
            {
                if (tabControlLinks.SelectedTab == tabLinksPlus)
                {
                    tabName = "LinksTab";
                    RealSelectedTab = true;
                }
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
                MessageBox.Show("you selected Music_All");
            }
        }

        private void tabMusicAll_DoubleClick(object sender, EventArgs e)
        {
            //doubleclicked the tab, now have it open a textbox and open a file
        }
        
        private void tabSub_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TabControl eventControl = (TabControl)sender;
            TabPage eventPage = eventControl.SelectedTab;
            RichTextBox pageRTB = new RichTextBox();
            eventPage.Controls.Add(pageRTB); //do i need this?
            pageRTB.Dock = DockStyle.Fill;
            if (eventControl == tabControlMusic)
            {
                if (tabControlMusic.SelectedTab == tabMusicAll)
                {
                    pageRTB.Text = Properties.Resources.nd_music_all;
                }
                else if (tabControlMusic.SelectedTab == tabMusicIndie)
                {
                    pageRTB.Text = Properties.Resources.nd_music_indie;
                }
                else if (tabControlMusic.SelectedTab == tabMusicMetal)
                {
                    pageRTB.Text = Properties.Resources.nd_music_metal;
                }
            } if (eventControl == tabControlLinks)
            {
                if (tabControlLinks.SelectedTab == tabLinksAll)
                {
                    pageRTB.Text = Properties.Resources.nd_links_all;
                }
                else if (tabControlLinks.SelectedTab == tabLinksArticles)
                {
                    pageRTB.Text = Properties.Resources.nd_links_arts;
                }
                else if (tabControlLinks.SelectedTab == tabLinksYT)
                {
                    pageRTB.Text = Properties.Resources.nd_links_yt;
                }
            }
        }

        private void NDFlushButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tabControlMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(tabControlMain.SelectedTab == tabMainMovies)
            {
                RichTextBox pageRTB = new RichTextBox();
                tabMainMovies.Controls.Add(pageRTB); //do i need this?
                pageRTB.Dock = DockStyle.Fill;
                pageRTB.Text = Properties.Resources.nd_movies;
            }
        }
    }
}
