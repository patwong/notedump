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
        //9: anime, 10: books, 11: games, 12: movies (get)
        private int[] activetabs;
        private string[] activetab_rtb_name;
        private string[] subtabfile;
        private bool[] nd_active;
        private TabPage[] tabarray;
        private string[] activetab_name;
        private int num_pages = 13;

        public NotedumpMainForm()
        {
            InitializeComponent();

            /******************************************************/
            /*********** all my initialization code **************/
            /******************************************************/

 
            //9 is the number of hardcoded pages
            activetabs = new int[num_pages];
            activetab_rtb_name = new string[num_pages];
            subtabfile = new string[num_pages];
            nd_active = new bool[num_pages];
            tabarray = new TabPage[num_pages];
            activetab_name = new string[num_pages];

            //initializes all the arrays
            for (int i = 0; i < num_pages; i++)
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
                    case 9:
                        tabarray[i] = tabGetAnime;
                        activetab_rtb_name[i] = "pageRTB_anime";
                        subtabfile[i] = "nd_get_anime.txt";
                        activetab_name[i] = "Anime";
                        break;
                    case 10:
                        tabarray[i] = tabGetBooks;
                        activetab_rtb_name[i] = "pageRTB_books";
                        subtabfile[i] = "nd_get_books.txt";
                        activetab_name[i] = "Books";
                        break;
                    case 11:
                        tabarray[i] = tabGetGames;
                        activetab_rtb_name[i] = "pageRTB_games";
                        subtabfile[i] = "nd_get_games.txt";
                        activetab_name[i] = "Games";
                        break;
                    case 12:
                        tabarray[i] = tabGetMovies;
                        activetab_rtb_name[i] = "pageRTB_Movies";
                        subtabfile[i] = "nd_get_movies.txt";
                        activetab_name[i] = "Movies";
                        break;
                }
                
            }
        }

        //sets the active tab
        //binary value a tab's active status
        //0: inactive, 1: active
        //only one tab is active
        private void set_active_tab(int tab_num)
        {
            for(int i = 0; i < num_pages; i++)
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
            //used to create new tab and
            //to indicate a change in the currently active tab
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
            else if (tabControlEvent == tabControlGet)
            {
                if(tabControlGet.SelectedTab == tabGetAnime)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[9];
                    set_active_tab(9);
                }
                else if(tabControlGet.SelectedTab == tabGetBooks)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[10];
                    set_active_tab(10);
                }
                else if(tabControlGet.SelectedTab == tabGetGames)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[11];
                    set_active_tab(11);
                }
                else if(tabControlGet.SelectedTab == tabGetMovies)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[12];
                    set_active_tab(12);
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
            //might not be safe, but only subtabs get this event
            //only menutab that gets a rtb is Movies and it's handled
            //by its own event handler
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
            }
            else if (eventControl == tabControlLinks)
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
            }
            else if (eventControl == tabControlTD)
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
            else if(eventControl == tabControlGet)
            {
                //0: td_reminders, 1: td_td, 2: music_all, 3: music_ind, 4: music_met
                //5: links_all, 6: links_yt, 7: links_arts, 8: movies
                //9: anime, 10: books, 11: games, 12: movies (get)
                if (tabControlGet.SelectedTab == tabGetAnime)
                {
                    pageRTB.Name = activetab_rtb_name[9];
                    pageRTB.LoadFile(subtabfile[9], RichTextBoxStreamType.PlainText);
                    nd_active[9] = true;
                    nd_a_get_anime = true;
                    NDstatusStripLabel.Text = "get - anime activated!";
                }
                else if(tabControlGet.SelectedTab == tabGetBooks)
                {
                    pageRTB.Name = activetab_rtb_name[10];
                    pageRTB.LoadFile(subtabfile[10], RichTextBoxStreamType.PlainText);
                    nd_active[10] = true;
                    tabMouseDoubleClick_Factored(10, pageRTB);
                    NDstatusStripLabel.Text = "get - books activated!";
                }
            }
            NDstatusStrip.Refresh();
        }
        private void tabMouseDoubleClick_Factored(int tab_num, RichTextBox pageRTB)
        {
            pageRTB.Name = activetab_rtb_name[tab_num];
            pageRTB.LoadFile(subtabfile[tab_num], RichTextBoxStreamType.PlainText);
            nd_active[tab_num] = true;
        }
        //for activetabs:
        //0: td_reminders, 1: td_td, 2: music_all, 3: music_ind, 4: music_met
        //5: links_all, 6: links_yt, 7: links_arts, 8: movies
        private void NDFlushButton_MouseClick_Factored(object sender, MouseEventArgs e)
        {
            //flushes out text in the textbox to the currently active tab
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
                            NDstatusStripLabel.Text = "flushed to: " + subtabfile[i];
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
            //movies gets its own event handler
            if(tabControlMain.SelectedTab == tabMainMovies)
            {                
                RichTextBox pageRTB = new RichTextBox();
                tabMainMovies.Controls.Add(pageRTB);
                pageRTB.Dock = DockStyle.Fill;                
                pageRTB.Name = activetab_rtb_name[8];
                pageRTB.LoadFile(subtabfile[8], RichTextBoxStreamType.PlainText);
                nd_a_movies = true;
                nd_active[8] = true;
            }
        }
    }
}
