using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notedump
{
    public partial class NotedumpMainForm : Form
    {
        //all the code regarding the menustrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exits without saving
            this.Close();
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
            this.Close();
        }
    }
}
