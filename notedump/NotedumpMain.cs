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
        /* code regarding the main form itself  */
        /* e.g. form-wise events like maximizing*/
        private void NotedumpMainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                //this.Hide();
                MessageBox.Show(this.WindowState.ToString());
            }
        }
    }
}
