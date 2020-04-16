using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Globalization;

namespace WindowsFormsApp1
{
    static class Globals
    {
        public static string soundFolderPath;
        public static List<string> soundFiles;
        public static ContextMenu cm;
        public static string buttonText = null;

    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Control _pressedButton;

        private void SetSoundFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.UserProfile;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                labelFolderPath.Text = folderBrowserDialog1.SelectedPath;
                Globals.soundFolderPath = labelFolderPath.Text;
            }
            
           
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {

            Control pressedButton = sender as Control;
            _pressedButton = pressedButton;

            if (e.Button == MouseButtons.Right)
            {
                setFileList();
                Globals.soundFiles.Sort();
                Globals.cm = new ContextMenu();
                foreach (var item in Globals.soundFiles)
                {
                    Globals.cm.MenuItems.Add(new MenuItem(item, MenuItem_Click));
                }

                Globals.cm.Show(pressedButton, new Point(pressedButton.Height / 2, pressedButton.Width / 2));


                //MessageBox.Show("");

                //pressedButton.Text = Globals.buttonText;

            }
            else
            {
                WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                player.URL = Globals.soundFolderPath + "\\" + Globals.buttonText + "\\" + ".mp3";
                player.controls.play();
            }
        }

        private void setFileList()
        {
            Globals.soundFiles = new List<string>();

            String[] soundFilesWithPath = Directory.GetFiles(Globals.soundFolderPath,"*.mp3");
            TextInfo ti = new CultureInfo("en-US", false).TextInfo;

            foreach (var item in soundFilesWithPath)
            {
                var sections = item.Split('\\');
                var fileNameWithExt = (sections[sections.Length - 1]).Split('.');
                var fileName = fileNameWithExt[0];

                fileName = ti.ToTitleCase(fileName);

                Globals.soundFiles.Add(fileName);
            }
        }

        private void MenuItem_Click(Object sender, System.EventArgs e)
        {
            MenuItem item = sender as MenuItem;
            _pressedButton.Text = item.Text;
            //Globals.buttonText = item.Text;

        }
    }
}