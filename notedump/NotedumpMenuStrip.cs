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
        private bool nd_a_links_all = false, nd_a_links_art = false, nd_a_links_yt = false;
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
            if (nd_a_movies) //checks if "Movies" RTB is active
            {
                //find tabobject for tabMainMovies
                //save rtb

                Control[] rtb = tabMainMovies.Controls.Find("pageRTB_movies", true);
                Console.WriteLine(rtb.Length); //1

                //this works
                RichTextBox rtb69 = (RichTextBox)rtb[0];

            }
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
            if(nd_a_links_all)
            {
                MessageBox.Show("links_all activated!");
            }
            if (nd_a_movies) //checks if "Movies" RTB is active
            {
                //find tabobject for tabMainMovies
                //save rtb

                Control[] rtb = tabMainMovies.Controls.Find("pageRTB_movies", true);
                Console.WriteLine(rtb.Length); //1

                //this works
                RichTextBox rtb69 = (RichTextBox)rtb[0];
                Console.WriteLine("!!confirm start!!");
                Console.WriteLine(rtb69.Text); //confirming contents of rtb
                Console.WriteLine("!!confirm end!!");
                /*
                using (StreamWriter outputFile = new StreamWriter(Properties.Resources.nd_movies))
                {
                    outputFile.Write(rtb69.Text);
                }
                */
                rtb69.SaveFile("nd_movies.txt", RichTextBoxStreamType.PlainText);
            }
            Console.WriteLine(Properties.Resources.nd_movies);//movies remains unchanged
            this.Close();
        }
    }
}
