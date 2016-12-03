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
        //0: td_reminders, 1: td_td, 2: music_all, 3: music_ind, 4: music_met
        //5: links_all, 6: links_yt, 7: links_arts, 8: movies
        private int[] activetabs;
        private string[] activetab_rtb_name;
        private string[] subtabfile;
        private bool[] nd_active;
        private TabPage[] tabarray;
        private string[] activetab_name;

        public NotedumpMainForm()
        {
            InitializeComponent();
            //9 is the number of hardcoded pages
            activetabs = new int[9];
            activetab_rtb_name = new string[9];
            subtabfile = new string[9];
            nd_active = new bool[9];
            tabarray = new TabPage[9];
            activetab_name = new string[9];

            //don't want to initialize a jagged array; two separate arrays easier :)

            for (int i = 0; i < 9; i++)
            {
                activetabs[i] = 0;
                nd_active[i] = false;
                switch(i)
                {
                    case 0:
                        //default tab active is TD remind - first visible tab
                        activetabs[0] = 1;
                        tabarray[i] = tabTDRemind;
                        activetab_rtb_name[i] = "pageRTB_td_rem";
                        subtabfile[i] = "nd_td_remind.txt";
                        activetab_name[i] = "To Do - Reminders";
                        break;
                    case 1:
                        tabarray[i] = tabTDTD;
                        activetab_rtb_name[i] = "pageRTB_td_td";
                        subtabfile[i] = "nd_td_td.txt";
                        activetab_name[i] = "To Do - To Do";
                        break;
                    case 2:
                        tabarray[i] = tabMusicAll;
                        activetab_rtb_name[i] = "pageRTB_music_all";
                        subtabfile[i] = "nd_music_all.txt";
                        activetab_name[i] = "Music - All";
                        break;
                    case 3:
                        tabarray[i] = tabMusicIndie;
                        activetab_rtb_name[i] = "pageRTB_music_ind";
                        subtabfile[i] = "nd_music_indie.txt";
                        activetab_name[i] = "Music - Indie";
                        break;
                    case 4:
                        tabarray[i] = tabMusicMetal;
                        activetab_rtb_name[i] = "pageRTB_music_met";
                        subtabfile[i] = "nd_music_metal.txt";
                        activetab_name[i] = "Music - Metal";
                        break;
                    case 5:
                        tabarray[i] = tabLinksAll;
                        activetab_rtb_name[i] = "pageRTB_links_all";
                        subtabfile[i] = "nd_links_all.txt";
                        activetab_name[i] = "Links - All";
                        break;
                    case 6:
                        tabarray[i] = tabLinksYT;
                        activetab_rtb_name[i] = "pageRTB_links_yt";
                        subtabfile[i] = "nd_links_yt.txt";
                        activetab_name[i] = "Links - Youtube";
                        break;
                    case 7:
                        tabarray[i] = tabLinksArticles;
                        activetab_rtb_name[i] = "pageRTB_links_arts";
                        subtabfile[i] = "nd_links_arts.txt";
                        activetab_name[i] = "Links - Articles";
                        break;
                    case 8:
                        tabarray[i] = tabMainMovies;
                        activetab_rtb_name[i] = "pageRTB_movies";
                        subtabfile[i] = "nd_movies.txt";
                        activetab_name[i] = "Movies";
                        break;
                }
                
            }
        }
        private void get_active_tab(object sender, EventArgs e)
        {
            for (int c = 0; c < 9; c++)
            {
                if(activetabs[c] == 1)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[c];
                    NDstatusStrip.Refresh();
                    break;
                }
            }
        }

        private void set_active_tab(int tab_num)
        {
            for(int i = 0; i < 9; i++)
            {
                if(i == tab_num)
                {
                    activetabs[i] = 1;
                } else
                {
                    activetabs[i] = 0;
                }
            }
        }

        //tab code       
        private void tabControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            //event handler for when selected tab changes
            //used to create new tab
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
                else if (tabControlMain.SelectedTab == tabMainLinks)
                {
                    NDstatusStripLabel.Text = "active tab: Links";
                }
                else if (tabControlMain.SelectedTab == tabMainMusic)
                {
                    NDstatusStripLabel.Text = "active tab: Music";
                }
                else if (tabControlMain.SelectedTab == tabMainMovies)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[8];
                    set_active_tab(8);
                }
                else if (tabControlMain.SelectedTab == tabMainTD)
                {
                    NDstatusStripLabel.Text = "active tab: TD";
                }
            }
            else if (tabControlEvent == tabControlMusic)
            {
                if (tabControlMusic.SelectedTab == tabMusicPlus)
                {
                    tabName = "MusicTab";
                    RealSelectedTab = true;
                }
                else if (tabControlMusic.SelectedTab == tabMusicAll)
                {
                    //NDstatusStripLabel.Text = "selected tab: music, all";
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[2];
                    set_active_tab(2);
                }
                else if (tabControlMusic.SelectedTab == tabMusicIndie)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[3];
                    set_active_tab(3);
                }
                else if (tabControlMusic.SelectedTab == tabMusicMetal)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[4];
                    set_active_tab(4);
                }
            }
            else if (tabControlEvent == tabControlLinks)
            {
                if (tabControlLinks.SelectedTab == tabLinksPlus)
                {
                    tabName = "LinksTab";
                    RealSelectedTab = true;
                } else if (tabControlLinks.SelectedTab == tabLinksAll)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[5];
                    set_active_tab(5);
                } else if (tabControlLinks.SelectedTab == tabLinksYT)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[6];
                    set_active_tab(6);
                } else if (tabControlLinks.SelectedTab == tabLinksArticles)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[7];
                    set_active_tab(7);
                }
            }
            else if (tabControlEvent == tabControlTD)
            {
                if(tabControlTD.SelectedTab == tabTDRemind)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[0];
                    set_active_tab(0);
                }
                else if(tabControlTD.SelectedTab == tabTDTD)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[1];
                    set_active_tab(1);
                }
            }
            if (RealSelectedTab)
            {
                tabName = tabName + (tabControlEvent.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(tabName);
                tabControlEvent.TabPages.Insert(tabControlEvent.TabPages.Count - 1, createdTabPage);
                tabControlEvent.SelectedTab = createdTabPage;
            }
            NDstatusStrip.Refresh();
        }

        
        private void tabSub_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //main event handler for mouse doubleclick of a "sub" tab
            //used to create new RichTextBox for the subtab
            TabControl eventControl = (TabControl)sender;
            TabPage eventPage = eventControl.SelectedTab;

            //creating a textbox immediately on doubleclick without check
            //might not be safe, but only tabs get this event
            RichTextBox pageRTB = new RichTextBox();
            eventPage.Controls.Add(pageRTB);
            pageRTB.Dock = DockStyle.Fill;
            if (eventControl == tabControlMusic)
            {
                if (tabControlMusic.SelectedTab == tabMusicAll)
                {
                    pageRTB.Name = activetab_rtb_name[2];
                    pageRTB.LoadFile(subtabfile[2], RichTextBoxStreamType.PlainText);
                    nd_a_music_all = true;
                    nd_active[2] = true;
                    NDstatusStripLabel.Text = "music all activated!";
                }
                else if (tabControlMusic.SelectedTab == tabMusicIndie)
                {
                    pageRTB.Name = activetab_rtb_name[3];
                    pageRTB.LoadFile(subtabfile[3], RichTextBoxStreamType.PlainText);
                    nd_a_music_ind = true;
                    nd_active[3] = true;
                    NDstatusStripLabel.Text = "music indie activated!";
                }
                else if (tabControlMusic.SelectedTab == tabMusicMetal)
                {
                    pageRTB.Name = activetab_rtb_name[4];
                    pageRTB.LoadFile(subtabfile[4], RichTextBoxStreamType.PlainText);
                    nd_active[4] = true;
                    nd_a_music_met = true;
                    NDstatusStripLabel.Text = "music metal activated!";
                }
            } else if (eventControl == tabControlLinks)
            {
                if (tabControlLinks.SelectedTab == tabLinksAll)
                {
                    pageRTB.Name = activetab_rtb_name[5];
                    pageRTB.LoadFile(subtabfile[5], RichTextBoxStreamType.PlainText);
                    nd_active[5] = true;
                    nd_a_links_all = true;
                    NDstatusStripLabel.Text = "links all activated!";
                }
                else if (tabControlLinks.SelectedTab == tabLinksArticles)
                {
                    pageRTB.Name = activetab_rtb_name[7];
                    pageRTB.LoadFile(subtabfile[7], RichTextBoxStreamType.PlainText);
                    nd_active[7] = true;
                    nd_a_links_arts = true;
                    NDstatusStripLabel.Text = "links articles activated!";
                }
                else if (tabControlLinks.SelectedTab == tabLinksYT)
                {
                    pageRTB.Name = activetab_rtb_name[6];
                    pageRTB.LoadFile(subtabfile[6], RichTextBoxStreamType.PlainText);
                    nd_a_links_yt = true;
                    nd_active[6] = true;
                    NDstatusStripLabel.Text = "links youtube activated!";
                }
            } else if (eventControl == tabControlTD)
            {
                if (tabControlTD.SelectedTab == tabTDRemind)
                {
                    pageRTB.Name = activetab_rtb_name[0];
                    pageRTB.LoadFile(subtabfile[0], RichTextBoxStreamType.PlainText);
                    nd_active[0] = true;
                    nd_a_td_rem = true;
                    NDstatusStripLabel.Text = "td remind activated!";
                } else if (tabControlTD.SelectedTab == tabTDTD)
                {
                    pageRTB.Name = activetab_rtb_name[1];
                    pageRTB.LoadFile(subtabfile[1], RichTextBoxStreamType.PlainText);
                    nd_a_td_td = true;
                    nd_active[1] = true;
                    NDstatusStripLabel.Text = "td td activated!";
                }
            }
            NDstatusStrip.Refresh();
        }

        //for activetabs:
        //0: td_reminders, 1: td_td, 2: music_all, 3: music_ind, 4: music_met
        //5: links_all, 6: links_yt, 7: links_arts, 8: movies
        private void NDFlushButton_MouseClick_Factored(object sender, MouseEventArgs e)
        {
            string checkiftext = NDtextBox.Text;
            if (checkiftext.Length > 0)
            {
                bool yesorno = true;
                int i = 0;
                while (yesorno)
                {
                    if (activetabs[i] == 1)
                    {
                        if (nd_active[i] == true)
                        {
                            Control[] rtb = tabarray[i].Controls.Find(activetab_rtb_name[i], true);
                            RichTextBox rtb69 = (RichTextBox)rtb[0];
                            rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
                            NDstatusStripLabel.Text = "flushed to:" + subtabfile[i];
                        }
                        else
                        {
                            string filepath = subtabfile[i];
                            if (!(File.Exists(filepath)))
                            {
                                MessageBox.Show("file doesn't exist!");
                            }
                            else
                            {
                                string toappend = Environment.NewLine + NDtextBox.Text;
                                File.AppendAllText(filepath, toappend);
                                string ndstatus1 = "file written out: " + subtabfile[i];
                                NDstatusStripLabel.Text = ndstatus1;
                            }
                        }
                        NDtextBox.Clear();
                        yesorno = false;
                    }
                    i++;
                }
            } else
            {
                NDstatusStripLabel.Text = "no text to be flushed";
            }
            NDstatusStrip.Refresh();
        }


        private void tabControlMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(tabControlMain.SelectedTab == tabMainMovies)
            {                
                RichTextBox pageRTB = new RichTextBox();
                tabMainMovies.Controls.Add(pageRTB);
                pageRTB.Dock = DockStyle.Fill;                
                pageRTB.Name = activetab_rtb_name[8];
                pageRTB.LoadFile(subtabfile[8], RichTextBoxStreamType.PlainText);
                nd_a_movies = true;
                nd_active[8] = true;

                //Console.WriteLine("thisthis");
            }
        }       
    }
}
