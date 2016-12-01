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
                else if (tabControlMain.SelectedTab == tabMainMusic)
                {
                    Console.WriteLine("tab main music selected!!");
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
            else if (tabControlEvent == tabControlTD)
            {
                if(tabControlTD.SelectedTab == tabTDRemind)
                {
                    Console.WriteLine("td remind selected");
                }
                else if(tabControlTD.SelectedTab == tabTDTD)
                {
                    Console.WriteLine("td td selected");
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
            //use this event to tell textbox where it's output is going to be
            if (tabControlMusic.SelectedTab == tabMusicAll)
            {
                //remember to make Console/output window visible to see messages
                Console.WriteLine("you selected music_all");
                //MessageBox.Show("you selected Music_All"); //annoying
            }
        }

        private void tabMusicAll_DoubleClick(object sender, EventArgs e)
        {
            //doubleclicked the tab, now have it open a textbox and open a file
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

        private void NDFlushButton_MouseClick(object sender, MouseEventArgs e)
        {
            //event handler for mouse click on Flush button
            Console.WriteLine("flush!"); //confirms that clicking button works
            var auxList = System.Reflection.Assembly.GetExecutingAssembly().GetManifes‌​tResourceNames();
            Console.WriteLine(auxList.Length);
            foreach(string c in auxList)
            {
                Console.WriteLine(c);
            }
            /*
                notedump.NotedumpMainForm.resources
                notedump.Properties.Resources.resources
            */
            if (nd_a_movies) //checks if "Movies" RTB is active
            {
                //find tabobject for tabLinksAll
                //save rtb
                
                //int asdf = tabMainMovies.Controls.Count;
                //Console.WriteLine(asdf); //1
                Control[] rtb = tabMainMovies.Controls.Find("pageRTB_movies", true);
                Console.WriteLine(rtb.Length); //1
                
                //this works
                RichTextBox rtb69 = (RichTextBox)rtb[0];
                Console.WriteLine(rtb69.Text + " hello!!!");
                //rtb69.Text = rtb69.Text + "hello!!!";
                rtb69.Text = rtb69.Text + '\n' + NDtextBox.Text;
                //also works to get the rtb control
                //each tab page only has one control attached - the rtb
                /*
                foreach (Control c in tabMainMovies.Controls)
                {
                    if (c is RichTextBox)
                    {
                        Console.WriteLine("c is rtb!");//this works!!!!!
                        Console.WriteLine(c.Name);
                    } 
                }
                */

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
