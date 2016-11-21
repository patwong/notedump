using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlMain.SelectedTab == tabMainPlus)
            {
                string title = "TabPage " + (tabControlMain.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                //tabControlMain.TabPages.Add(createdTabPage);
                tabControlMain.TabPages.Insert(tabControlMain.TabPages.Count - 1, createdTabPage);
                tabControlMain.SelectedTab = createdTabPage;
            }
        }
    }
}
