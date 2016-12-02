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

        public NotedumpMainForm()
        {
            InitializeComponent();
            activetabs = new int[9];
            for(int i = 0; i < 9; i++)
            {
                activetabs[i] = 0;
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
                    NDstatusStripLabel.Text = "selected tab: links";
                }
                else if (tabControlMain.SelectedTab == tabMainMusic)
                {
                    Console.WriteLine("tab main music selected!!");
                    NDstatusStripLabel.Text = "selected tab: music";
                    //NDstatusStrip.Refresh();
                }
                else if (tabControlMain.SelectedTab == tabMainMovies)
                {
                    Console.WriteLine("debug: selected tab: movies");
                    NDstatusStripLabel.Text = "selected tab: movies";
                    //NDstatusStrip.Refresh();
                    set_active_tab(8);
                }
                else if (tabControlMain.SelectedTab == tabMainTD)
                {
                    NDstatusStripLabel.Text = "selected tab: TD";
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
                    Console.WriteLine("selectedindex: music all");
                    NDstatusStripLabel.Text = "selected tab: music, all";
                    //NDstatusStrip.Refresh();
                    set_active_tab(2);
                }
                else if (tabControlMusic.SelectedTab == tabMusicIndie)
                {
                    Console.WriteLine("debug: selectedindex: music indie");
                    NDstatusStripLabel.Text = "selected tab: music, indie";                    
                    set_active_tab(3);
                }
                else if (tabControlMusic.SelectedTab == tabMusicMetal)
                {
                    Console.WriteLine("debug: selected tab: music met");
                    NDstatusStripLabel.Text = "selected tab: music, metal";
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
                    Console.WriteLine("debug: selected tab: links all");
                    NDstatusStripLabel.Text = "selected tab: links, all";
                    set_active_tab(5);
                } else if (tabControlLinks.SelectedTab == tabLinksYT)
                {
                    Console.WriteLine("debug: selected tab: links yt");
                    NDstatusStripLabel.Text = "selected tab: links, yt";
                    set_active_tab(6);
                } else if (tabControlLinks.SelectedTab == tabLinksArticles)
                {
                    Console.WriteLine("debug: selected tab: links arts");
                    NDstatusStripLabel.Text = "selected tab: links, articles";
                    set_active_tab(7);
                }
            }
            else if (tabControlEvent == tabControlTD)
            {
                if(tabControlTD.SelectedTab == tabTDRemind)
                {
                    Console.WriteLine("debug: selected tab: td remind");
                    NDstatusStripLabel.Text = "selected tab: td, reminders";
                    set_active_tab(0);
                }
                else if(tabControlTD.SelectedTab == tabTDTD)
                {
                    Console.WriteLine("debug: selected: td td");
                    NDstatusStripLabel.Text = "selected tab: td, td";
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


        private void tabControlMusic_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //use this event to tell textbox where it's output is going to be
            if (tabControlMusic.SelectedTab == tabMusicAll)
            {
                //remember to make Console/output window visible to see messages
                Console.WriteLine("you selected music_all");
                //MessageBox.Show("you selected Music_All"); //annoying
            }
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
                    pageRTB.Name = "pageRTB_music_all";
                    pageRTB.LoadFile("nd_music_all.txt", RichTextBoxStreamType.PlainText);
                    //pageRTB.Text = Properties.Resources.nd_music_all;
                    nd_a_music_all = true;
                }
                else if (tabControlMusic.SelectedTab == tabMusicIndie)
                {
                    pageRTB.Name = "pageRTB_music_ind";
                    pageRTB.LoadFile("nd_music_indie.txt", RichTextBoxStreamType.PlainText);
                    //pageRTB.Text = Properties.Resources.nd_music_indie;
                    nd_a_music_ind = true;
                }
                else if (tabControlMusic.SelectedTab == tabMusicMetal)
                {
                    pageRTB.Name = "pageRTB_music_met";
                    pageRTB.LoadFile("nd_music_metal.txt", RichTextBoxStreamType.PlainText);
                    //pageRTB.Text = Properties.Resources.nd_music_metal;
                    nd_a_music_met = true;
                }
            } else if (eventControl == tabControlLinks)
            {
                if (tabControlLinks.SelectedTab == tabLinksAll)
                {
                    pageRTB.Name = "pageRTB_links_all";
                    pageRTB.LoadFile("nd_links_all.txt", RichTextBoxStreamType.PlainText);
                    //pageRTB.Text = Properties.Resources.nd_links_all;
                    nd_a_links_all = true;
                }
                else if (tabControlLinks.SelectedTab == tabLinksArticles)
                {
                    pageRTB.Name = "pageRTB_links_arts";
                    pageRTB.LoadFile("nd_links_arts.txt", RichTextBoxStreamType.PlainText);
                    //pageRTB.Text = Properties.Resources.nd_links_arts;
                    nd_a_links_arts = true;
                }
                else if (tabControlLinks.SelectedTab == tabLinksYT)
                {
                    pageRTB.Name = "pageRTB_links_yt";
                    pageRTB.LoadFile("nd_links_yt.txt", RichTextBoxStreamType.PlainText);
                    //pageRTB.Text = Properties.Resources.nd_links_yt;
                    nd_a_links_yt = true;
                }
            } else if (eventControl == tabControlTD)
            {
                if (tabControlTD.SelectedTab == tabTDRemind)
                {
                    pageRTB.Name = "pageRTB_td_rem";
                    pageRTB.LoadFile("nd_td_remind.txt", RichTextBoxStreamType.PlainText);
                    //pageRTB.Text = Properties.Resources.nd_td_remind;
                    nd_a_td_rem = true;
                } else if (tabControlTD.SelectedTab == tabTDTD)
                {
                    pageRTB.Name = "pageRTB_td_td";
                    pageRTB.LoadFile("nd_td_td.txt", RichTextBoxStreamType.PlainText);
                    //pageRTB.Text = Properties.Resources.nd_td_td;
                    nd_a_td_td = true;
                }
            }
        }

        //for activetabs:
        //0: td_reminders, 1: td_td, 2: music_all, 3: music_ind, 4: music_met
        //5: links_all, 6: links_yt, 7: links_arts, 8: movies
        private void NDFlushButton_MouseClick(object sender, MouseEventArgs e)
        {
            //event handler for mouse click on Flush button
            Console.WriteLine("flush!"); //confirms that clicking button works
            if(activetabs[0] == 1)
            {
                if(nd_a_td_rem)
                {
                    //find tabobject for tabTDRemind
                    //save rtb
                    Control[] rtb = tabTDRemind.Controls.Find("pageRTB_td_rem", true);
                    RichTextBox rtb69 = (RichTextBox)rtb[0];
                    rtb69.Text = rtb69.Text + 'r' + '\n' + NDtextBox.Text;
                }
                else
                {
                    //do i allow unopened tab to have contents flushed?
                    //let's try first...
                    //it works!!
                    string filepath = "nd_td_remind.txt";
                    if(!(File.Exists(filepath)))
                    {
                        MessageBox.Show("file doesn't exist!");
                    }
                    else
                    {
                        File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                        Console.WriteLine("file written out!!");
                    }
                }
            }
            else if(activetabs[1] == 1)
            {
                if (nd_a_td_td)
                {
                    //find tabobject for tabTDTD
                    //save rtb
                    Control[] rtb = tabTDTD.Controls.Find("pageRTB_td_td", true);
                    RichTextBox rtb69 = (RichTextBox)rtb[0];
                    rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
                }
                else
                {
                    string filepath = "nd_td_td.txt";
                    if (!(File.Exists(filepath)))
                    {
                        MessageBox.Show("file doesn't exist!");
                    }
                    else
                    {
                        File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                        Console.WriteLine("file written out!!");
                    }
                }
            }
            else if (activetabs[2] == 1)
            {
                if (nd_a_music_all)
                {
                    //find tabobject for tabMusicAll
                    //save rtb
                    Control[] rtb = tabMusicAll.Controls.Find("pageRTB_music_all", true);
                    RichTextBox rtb69 = (RichTextBox)rtb[0];
                    rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
                }
                else
                {
                    string filepath = "nd_music_all.txt";
                    if (!(File.Exists(filepath)))
                    {
                        MessageBox.Show("file doesn't exist!");
                    }
                    else
                    {
                        File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                        Console.WriteLine("file written out!!");
                    }
                }
            }
            else if (activetabs[3] == 1)
            {
                if (nd_a_music_ind)
                {
                    //find tabobject for tabMusicIndie
                    //save rtb
                    Control[] rtb = tabMusicIndie.Controls.Find("pageRTB_music_ind", true);
                    RichTextBox rtb69 = (RichTextBox)rtb[0];
                    rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
                }
                else
                {
                    string filepath = "nd_music_ind.txt";
                    if (!(File.Exists(filepath)))
                    {
                        MessageBox.Show("file doesn't exist!");
                    }
                    else
                    {
                        File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                        Console.WriteLine("file written out!!");
                    }
                }
            }
            else if (activetabs[4] == 1)
            {
                if (nd_a_music_met)
                {
                    //find tabobject for tabMusicMetal
                    //save rtb
                    Control[] rtb = tabMusicMetal.Controls.Find("pageRTB_music_met", true);
                    RichTextBox rtb69 = (RichTextBox)rtb[0];
                    rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
                }
                else
                {
                    string filepath = "nd_music_metal.txt";
                    if (!(File.Exists(filepath)))
                    {
                        MessageBox.Show("file doesn't exist!");
                    }
                    else
                    {
                        File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                        Console.WriteLine("file written out!!");
                    }
                }
            }
            else if (activetabs[5] == 1)
            {
                if (nd_a_links_all)
                {
                    //find tabobject for tabLinksAll
                    //save rtb
                    Control[] rtb = tabLinksAll.Controls.Find("pageRTB_links_all", true);
                    RichTextBox rtb69 = (RichTextBox)rtb[0];
                    rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
                }
                else
                {
                    string filepath = "nd_links_all.txt";
                    if (!(File.Exists(filepath)))
                    {
                        MessageBox.Show("file doesn't exist!");
                    }
                    else
                    {
                        File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                        Console.WriteLine("file written out!!");
                    }
                }
            }
            else if (activetabs[6] == 1)
            {
                if (nd_a_links_yt)
                {
                    //find tabobject for tabLinksYT
                    //save rtb
                    Control[] rtb = tabLinksYT.Controls.Find("pageRTB_links_yt", true);
                    RichTextBox rtb69 = (RichTextBox)rtb[0];
                    rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
                }
                else
                {
                    string filepath = "nd_links_yt.txt";
                    if (!(File.Exists(filepath)))
                    {
                        MessageBox.Show("file doesn't exist!");
                    }
                    else
                    {
                        File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                        Console.WriteLine("file written out!!");
                    }
                }
            }
            else if (activetabs[7] == 1)
            {
                if (nd_a_links_arts)
                {
                    //find tabobject for tabLinkArticles
                    //save rtb
                    Control[] rtb = tabLinksArticles.Controls.Find("pageRTB_links_arts", true);
                    RichTextBox rtb69 = (RichTextBox)rtb[0];
                    rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
                }
                else
                {
                    string filepath = "nd_links_arts.txt";
                    if (!(File.Exists(filepath)))
                    {
                        MessageBox.Show("file doesn't exist!");
                    }
                    else
                    {
                        File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                        Console.WriteLine("file written out!!");
                    }
                }
            }
            else if (activetabs[8] == 1)
            {
                if (nd_a_movies) //checks if "Movies" RTB is active
                {
                    //find tabobject for tabMainMovies
                    //save rtb                          
                    Control[] rtb = tabMainMovies.Controls.Find("pageRTB_movies", true);
                    RichTextBox rtb69 = (RichTextBox)rtb[0];
                    rtb69.Text = rtb69.Text + '\r'+ '\n' + NDtextBox.Text;
                }
                else
                {
                    string filepath = "nd_movies.txt";
                    if (!(File.Exists(filepath)))
                    {
                        MessageBox.Show("file doesn't exist!");
                    }
                    else
                    {
                        File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                        Console.WriteLine("file written out!!");
                    }
                }
            }
            NDtextBox.Clear();
        }

        private void tabControlMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(tabControlMain.SelectedTab == tabMainMovies)
            {                
                RichTextBox pageRTB = new RichTextBox();
                pageRTB.Name = "pageRTB_movies";
                tabMainMovies.Controls.Add(pageRTB); //do i need this?
                pageRTB.Dock = DockStyle.Fill;
                pageRTB.LoadFile("nd_movies.txt", RichTextBoxStreamType.PlainText);
                nd_a_movies = true;


                //Console.WriteLine("thisthis");
            }
        }

    }
}
