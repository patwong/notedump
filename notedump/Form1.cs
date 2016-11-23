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
        //public string ndrootdir;
        public NotedumpMainForm()
        {
            InitializeComponent();
            //ndrootdir = AppDomain.CurrentDomain.BaseDirectory;
        }

        //tab code
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlMain.SelectedTab == tabMainPlus)
            {
                string title = "MainTab" + (tabControlMain.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                tabControlMain.TabPages.Insert(tabControlMain.TabPages.Count - 1, createdTabPage);
                tabControlMain.SelectedTab = createdTabPage;
            }
        }

        private void tabControlMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMusic.SelectedTab == tabMusicPlus)
            {
                string title = "MusicTab" + (tabControlMusic.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                tabControlMusic.TabPages.Insert(tabControlMusic.TabPages.Count - 1, createdTabPage);
                tabControlMusic.SelectedTab = createdTabPage;
            }
        }

        private void tabControlLinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlLinks.SelectedTab == tabLinksPlus)
            {
                string title = "LinksTab" + (tabControlLinks.TabCount + 1).ToString();
                TabPage createdTabPage = new TabPage(title);
                tabControlLinks.TabPages.Insert(tabControlLinks.TabPages.Count - 1, createdTabPage);
                tabControlLinks.SelectedTab = createdTabPage;
            }
        }

        private void tabControlMusic_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControlMusic.SelectedTab == tabMusicAll)
            {
                Console.WriteLine("you selected Music_All");
            }
        }

        private void tabMusicAll_Click(object sender, EventArgs e)
        {

        }

        private void tabMusicAll_DoubleClick(object sender, EventArgs e)
        {
            //doubleclicked the tab, now have it open a textbox and open a file
        }

        private void tabControlMusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tabControlMusic.SelectedTab == tabMusicAll)
            {
                RichTextBox musicAllBox = new RichTextBox();

                //dock dynamically resizes on whatever the form does
                musicAllBox.Dock = DockStyle.Fill;

                //size = size only resizes to its container once
                // musicAllBox.Size = tabMusicAll.Size; 

                tabMusicAll.Controls.Add(musicAllBox); //do i need this?

                //opening the textfile
                //OpenFileDialog openMusicAllFile = new OpenFileDialog();
                //openMusicAllFile.FileName = "music_all.txt";
                //openMusicAllFile.Filter = "Text Files|*.txt"; //this opens dialogue box
                //if (openMusicAllFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //    musicAllBox.LoadFile(openMusicAllFile.FileName,
                //    RichTextBoxStreamType.PlainText);

                //these two are the same
                Console.WriteLine("current directory:{0}", Directory.GetCurrentDirectory());
                Console.WriteLine("startup path: {0}", Application.StartupPath);

                /*
                 * current directory:D:\Projects\notedump\notedump\bin\Debug
                 *  startup path: D:\Projects\notedump\notedump\bin\Debug
                 *  D:\Projects\notedump\notedump\bin\Debug/cat
                 * 
                 */

                //string rootdir = Application.StartupPath;
                //rootdir = rootdir + "/cat"; //works - concats "/cat" to rootdir
                //Console.WriteLine(rootdir);
                string testpath = Environment.CurrentDirectory + @"\music_all.txt";
                Console.WriteLine(testpath);
                //string apath1 = Properties.Resources.music_all;
                //Console.WriteLine(apath1);
                // var txtfile = notedump.Properties.Resources.musicall1;

                //String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                //String strFilePath = Path.Combine(strAppPath, "Resources");
                //String txtfile = Path.Combine(strFilePath, "musicall1.txt");
                //string[] arrlist = Assembly.GetExecutingAssembly().GetManifestResourceNames();

                //Assembly creditAssm = Assembly.GetExecutingAssembly();
                //using (Stream creditStream =
                //creditAssm.GetManifestResourceStream("notedump.Properties.Resources.musicall1.txt"))
                //{
                //    musicAllBox.LoadFile(creditStream, RichTextBoxStreamType.RichText);
                //}

                musicAllBox.Text = Properties.Resources.musicall1;
                //musicAllBox.LoadFile(txtfile , RichTextBoxStreamType.PlainText);
            }
        }


    }
}
