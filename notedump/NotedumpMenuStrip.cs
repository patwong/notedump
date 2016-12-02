using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notedump
{
    public partial class NotedumpMainForm : Form
    {
        /***** notedump rtb active ******/
        //binary value indicating if RTB is active or not
        //will be used to determine if content of RTB needs saving
        //format: nd_a_{cat}_{sub}
        //cat: category, i.e. links, movies, music, td
        //sub: subcategory, i.e. all, arts, yt, etc.
        //links
        private bool nd_a_links_all = false, nd_a_links_arts = false, nd_a_links_yt = false;
        //movies
        private bool nd_a_movies = false;
        //music
        private bool nd_a_music_all = false, nd_a_music_ind = false, nd_a_music_met = false;
        //td
        private bool nd_a_td_rem = false, nd_a_td_td = false;

        //all the code regarding the menustrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exits without saving
            this.Close();
        }
        private void menuStrip_saveAll_Click(object sender, EventArgs e)
        {
            //event for when "Save All" is clicked
            Control[] rtb;
            RichTextBox rtb69;
            if (nd_a_links_all)
            {
                rtb = tabLinksAll.Controls.Find("pageRTB_links_all", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_links_all.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_links_arts) //checks if "links_arts" RTB is active
            {
                rtb = tabLinksArticles.Controls.Find("pageRTB_links_arts", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_links_arts.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_links_yt) //checks if "links_yt" RTB is active
            {
                rtb = tabLinksYT.Controls.Find("pageRTB_links_yt", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_links_yt.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_movies) //checks if "Movies" RTB is active
            {                
                rtb = tabMainMovies.Controls.Find("pageRTB_movies", true);
                rtb69 = (RichTextBox)rtb[0];                         
                rtb69.SaveFile("nd_movies.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_music_all) //checks if "music_all" RTB is active
            {
                rtb = tabMusicAll.Controls.Find("pageRTB_music_all", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_music_indie.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_music_ind) //checks if "music_ind" RTB is active
            {
                rtb = tabMusicIndie.Controls.Find("pageRTB_music_ind", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_music_indie.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_music_met) //checks if "music_met" RTB is active
            {
                rtb = tabMusicMetal.Controls.Find("pageRTB_music_met", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_music_metal.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_td_rem) //checks if "td_rem" RTB is active
            {
                rtb = tabTDRemind.Controls.Find("pageRTB_td_rem", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_td_remind.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_td_td) //checks if "td_td" RTB is active
            {
                rtb = tabTDTD.Controls.Find("pageRTB_td_td", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_td_td.txt", RichTextBoxStreamType.PlainText);
            }
            NDstatusStripLabel.Text = "saved everything";
            NDstatusStrip.Refresh();
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

            Control[] rtb;
            RichTextBox rtb69;
            if(nd_a_links_all)
            {
                Console.WriteLine("links_all activated!");
                rtb = tabLinksAll.Controls.Find("pageRTB_links_all", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_links_all.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_links_arts) //checks if "links_arts" RTB is active
            {
                rtb = tabLinksArticles.Controls.Find("pageRTB_links_arts", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_links_arts.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_links_yt) //checks if "links_yt" RTB is active
            {
                Console.WriteLine("links_yt activated!!");
                rtb = tabLinksYT.Controls.Find("pageRTB_links_yt", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_links_yt.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_movies) //checks if "Movies" RTB is active
            {
                //find tabobject for tabMainMovies
                //save rtb

                rtb = tabMainMovies.Controls.Find("pageRTB_movies", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_movies.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_music_all) //checks if "music_all" RTB is active
            {
                rtb = tabMusicAll.Controls.Find("pageRTB_music_all", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_music_indie.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_music_ind) //checks if "music_ind" RTB is active
            {
                rtb = tabMusicIndie.Controls.Find("pageRTB_music_ind", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_music_indie.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_music_met) //checks if "music_met" RTB is active
            {
                rtb = tabMusicMetal.Controls.Find("pageRTB_music_met", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_music_metal.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_td_rem) //checks if "td_rem" RTB is active
            {
                rtb = tabTDRemind.Controls.Find("pageRTB_td_rem", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_td_remind.txt", RichTextBoxStreamType.PlainText);
            }
            if (nd_a_td_td) //checks if "td_td" RTB is active
            {
                rtb = tabTDTD.Controls.Find("pageRTB_td_td", true);
                rtb69 = (RichTextBox)rtb[0];
                rtb69.SaveFile("nd_td_td.txt", RichTextBoxStreamType.PlainText);
            }
            //Console.WriteLine(Properties.Resources.nd_movies);//movies remains unchanged
            this.Close();
        }
    }
}
