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
        private void saveAllClick(object sender, EventArgs e)
        {
            int len = 9;
            Control[] rtb;
            RichTextBox rtb69;
            for(int i = 0; i < len; i++)
            {
                if(nd_active[i])
                {
                    rtb = tabarray[i].Controls.Find(activetab_rtb_name[i], true);
                    rtb69 = (RichTextBox)rtb[0];
                    rtb69.SaveFile(subtabfile[i], RichTextBoxStreamType.PlainText);
                }
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
            saveAllClick(sender, e);
            this.Close();
        }
    }
}
