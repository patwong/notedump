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

        public NotedumpMainForm()
        {
            InitializeComponent();
            activetabs = new int[9];
            activetab_rtb_name = new string[9];            
            subtabfile = new string[9];
            nd_active = new bool[9];

            //don't want to initialize a jagged array; two separate arrays easier :)

            for (int i = 0; i < 9; i++)
            {
                activetabs[i] = 0;
                nd_active[i] = false;
                switch(i)
                {
                    case 0:
                        activetab_rtb_name[i] = "pageRTB_td_rem";
                        subtabfile[i] = "nd_td_remind.txt";
                        break;
                    case 1:
                        activetab_rtb_name[i] = "pageRTB_td_td";
                        subtabfile[i] = "nd_td_td.txt";
                        break;
                    case 2:
                        activetab_rtb_name[i] = "pageRTB_music_all";
                        subtabfile[i] = "nd_music_all.txt";
                        break;
                    case 3:
                        activetab_rtb_name[i] = "pageRTB_music_ind";
                        subtabfile[i] = "nd_music_ind.txt";
                        break;
                    case 4:
                        activetab_rtb_name[i] = "pageRTB_music_met";
                        subtabfile[i] = "nd_music_metal.txt";
                        break;
                    case 5:
                        activetab_rtb_name[i] = "pageRTB_links_all";
                        subtabfile[i] = "nd_links_all.txt";
                        break;
                    case 6:
                        activetab_rtb_name[i] = "pageRTB_links_yt";
                        subtabfile[i] = "nd_links_yt.txt";
                        break;
                    case 7:
                        activetab_rtb_name[i] = "pageRTB_links_arts";
                        subtabfile[i] = "nd_links_arts.txt";
                        break;
                    case 8:
                        activetab_rtb_name[i] = "pageRTB_movies";
                        subtabfile[i] = "nd_movies.txt";
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
                    NDstatusStripLabel.Text = "selected tab: links";
                }
                else if (tabControlMain.SelectedTab == tabMainMusic)
                {
                    NDstatusStripLabel.Text = "selected tab: music";
                }
                else if (tabControlMain.SelectedTab == tabMainMovies)
                {
                    NDstatusStripLabel.Text = "selected tab: movies";
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
                    NDstatusStripLabel.Text = "selected tab: music, all";
                    set_active_tab(2);
                }
                else if (tabControlMusic.SelectedTab == tabMusicIndie)
                {
                    NDstatusStripLabel.Text = "selected tab: music, indie";                    
                    set_active_tab(3);
                }
                else if (tabControlMusic.SelectedTab == tabMusicMetal)
                {
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
                    NDstatusStripLabel.Text = "selected tab: links, all";
                    set_active_tab(5);
                } else if (tabControlLinks.SelectedTab == tabLinksYT)
                {
                    NDstatusStripLabel.Text = "selected tab: links, yt";
                    set_active_tab(6);
                } else if (tabControlLinks.SelectedTab == tabLinksArticles)
                {
                    NDstatusStripLabel.Text = "selected tab: links, articles";
                    set_active_tab(7);
                }
            }
            else if (tabControlEvent == tabControlTD)
            {
                if(tabControlTD.SelectedTab == tabTDRemind)
                {
                    NDstatusStripLabel.Text = "selected tab: td, reminders";
                    set_active_tab(0);
                }
                else if(tabControlTD.SelectedTab == tabTDTD)
                {
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
                    nd_a_music_all = true;
                    nd_active[2] = true;
                    NDstatusStripLabel.Text = "music all activated!";
                }
                else if (tabControlMusic.SelectedTab == tabMusicIndie)
                {
                    pageRTB.Name = "pageRTB_music_ind";
                    pageRTB.LoadFile("nd_music_indie.txt", RichTextBoxStreamType.PlainText);
                    nd_a_music_ind = true;
                    nd_active[3] = true;
                    NDstatusStripLabel.Text = "music indie activated!";
                }
                else if (tabControlMusic.SelectedTab == tabMusicMetal)
                {
                    pageRTB.Name = "pageRTB_music_met";
                    pageRTB.LoadFile("nd_music_metal.txt", RichTextBoxStreamType.PlainText);
                    nd_active[4] = true;
                    nd_a_music_met = true;
                    NDstatusStripLabel.Text = "music metal activated!";
                }
            } else if (eventControl == tabControlLinks)
            {
                if (tabControlLinks.SelectedTab == tabLinksAll)
                {
                    pageRTB.Name = "pageRTB_links_all";
                    pageRTB.LoadFile("nd_links_all.txt", RichTextBoxStreamType.PlainText);
                    nd_active[5] = true;
                    nd_a_links_all = true;
                    NDstatusStripLabel.Text = "links all activated!";
                }
                else if (tabControlLinks.SelectedTab == tabLinksArticles)
                {
                    pageRTB.Name = "pageRTB_links_arts";
                    pageRTB.LoadFile("nd_links_arts.txt", RichTextBoxStreamType.PlainText);
                    nd_active[7] = true;
                    nd_a_links_arts = true;
                    NDstatusStripLabel.Text = "links articles activated!";
                }
                else if (tabControlLinks.SelectedTab == tabLinksYT)
                {
                    pageRTB.Name = "pageRTB_links_yt";
                    pageRTB.LoadFile("nd_links_yt.txt", RichTextBoxStreamType.PlainText);
                    nd_a_links_yt = true;
                    nd_active[6] = true;
                    NDstatusStripLabel.Text = "links youtube activated!";
                }
            } else if (eventControl == tabControlTD)
            {
                if (tabControlTD.SelectedTab == tabTDRemind)
                {
                    pageRTB.Name = "pageRTB_td_rem";
                    pageRTB.LoadFile("nd_td_remind.txt", RichTextBoxStreamType.PlainText);
                    nd_active[0] = true;
                    nd_a_td_rem = true;
                    NDstatusStripLabel.Text = "td remind activated!";
                } else if (tabControlTD.SelectedTab == tabTDTD)
                {
                    pageRTB.Name = "pageRTB_td_td";
                    pageRTB.LoadFile("nd_td_td.txt", RichTextBoxStreamType.PlainText);
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
            string checkiftext = NDstatusStripLabel.Text;
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
                            //need to change tabMainMovies to a 
                            //use dictionary or what?
                            Control[] rtb = tabMainMovies.Controls.Find(activetab_rtb_name[i], true);
                            RichTextBox rtb69 = (RichTextBox)rtb[0];
                            rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
                            NDstatusStripLabel.Text = "flushed!";
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
                                File.AppendAllText(filepath, '\r' + '\n' + NDtextBox.Text);
                                NDstatusStripLabel.Text = "file written out!";
                            }
                        }
                        NDtextBox.Clear();
                        yesorno = false;
                    }
                    i++;
                }
            } else
            {
                //hello
                NDstatusStripLabel.Text = "no text to be flushed";
            }
            NDstatusStrip.Refresh();
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
                    rtb69.Text = rtb69.Text + '\r' + '\n' + NDtextBox.Text;
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

                    string tpname = "tabMusicAll";
                    var lol69 = typeof(TabPage);
                    var lol70 = lol69.GetField(tpname);
                    //TabPage testpage = (TabPage) this.GetType().GetField(tpname).GetValue(this);
                    Console.WriteLine(lol70.ToString());
                    Console.WriteLine("end of debug");
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
