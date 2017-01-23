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
        //all the code regarding the menustrip

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exits without saving
            this.Close();
        }

        //displays the name of the active name in the status bar
        //useful since i didn't make the first visible subtab "active"
        //when menu tabs are changed
        private void get_active_tab(object sender, EventArgs e)
        {
            for (int c = 0; c < num_pages; c++)
            {
                if (activetabs[c] == 1)
                {
                    NDstatusStripLabel.Text = "active tab: " + activetab_name[c];
                    NDstatusStrip.Refresh();
                    break;
                }
            }
        }

        private void saveAllClick(object sender, EventArgs e)
        {
            Control[] rtb;
            RichTextBox rtb69;
            for(int i = 0; i < num_pages; i++)
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
