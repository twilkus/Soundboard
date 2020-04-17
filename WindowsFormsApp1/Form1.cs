namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;
    using System.IO;
    using System.Globalization;

    public partial class Form1 : Form
    {
        private const string pathConfigurationKey = "SoundsPath";
        private Control _pressedButton;
        private string soundFolderPath;
        private List<string> soundFiles;
        private ContextMenu cm;

        private WMPLib.WindowsMediaPlayer _player;

        public Form1()
        {
            InitializeComponent();
            _player = new WMPLib.WindowsMediaPlayer();
            trackBar1.Value = 100;
            _player.settings.volume = 100;
            SetPath();
        }

        private void SetPath()
        {
            var path = ConfigurationManager.AppSettings[pathConfigurationKey];
            if(!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                soundFolderPath = path;
                labelFolderPath.Text = path;
            }
        }

        private void SetSoundFolderButton_Click(object sender, EventArgs e)
        {
            setSoundFolderPath();
        }

        private void setSoundFolderPath()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.UserProfile;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                labelFolderPath.Text = folderBrowserDialog1.SelectedPath;
                soundFolderPath = labelFolderPath.Text;
                ConfigHelper.AddUpdateAppSettings(pathConfigurationKey, soundFolderPath);
            }
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            Control pressedButton = sender as Control;
            _pressedButton = pressedButton;

            if (e.Button == MouseButtons.Right)
            {
                if(soundFolderPath == null)
                {
                    setSoundFolderPath();
                }

                if(soundFolderPath == null)
                {
                    return;
                }

                setFileList();
                soundFiles.Sort();
                cm = new ContextMenu();
                foreach (var item in soundFiles)
                {
                    cm.MenuItems.Add(new MenuItem(item, MenuItem_Click));
                }

                cm.Show(pressedButton, new Point(pressedButton.Height / 2, pressedButton.Width / 2));
            }
        }

        private void setFileList()
        {
            soundFiles = new List<string>();

            String[] soundFilesWithPath = Directory.GetFiles(soundFolderPath,"*.mp3");
            TextInfo ti = new CultureInfo("en-US", false).TextInfo;

            foreach (var item in soundFilesWithPath)
            {
                var fileName = Path.GetFileNameWithoutExtension(item);
                fileName = ti.ToTitleCase(fileName);
                soundFiles.Add(fileName);
            }
        }

        private void MenuItem_Click(Object sender, System.EventArgs e)
        {
            MenuItem item = sender as MenuItem;
            _pressedButton.Text = item.Text;
        }

        private void soundButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (string.IsNullOrEmpty(button.AccessibleDescription))
            {
                button.AccessibleDescription = soundFolderPath;
            }
            var path = $@"{button.AccessibleDescription}\{button.Text}.mp3";
            if (File.Exists(path))
            {
                _player.URL = path;
                _player.controls.play();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _player.settings.volume = trackBar1.Value;
        }
    }
}