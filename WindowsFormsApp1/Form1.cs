namespace Soundboard
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
        //Button keys are stored in button.AccessibleDescription
        public const string pathButton1Key = "pathButton1";
        public const string pathButton2Key = "pathButton2";
        public const string pathButton3Key = "pathButton3";
        public const string pathButton4Key = "pathButton4";
        public const string pathButton5Key = "pathButton5";
        public const string pathButton6Key = "pathButton6";
        public const string pathButton7Key = "pathButton7";
        public const string pathButton8Key = "pathButton8";
        public const string pathButton9Key = "pathButton9";
        public const string pathButton10Key = "pathButton10";
        public const string pathButton11Key = "pathButton11";
        public const string pathButton12Key = "pathButton12";
        public const string pathButton13Key = "pathButton13";
        public const string pathButton14Key = "pathButton14";
        public const string pathButton15Key = "pathButton15";
        public const string pathButton16Key = "pathButton16";
        private Control _pressedButton;
        private string soundFolderPath;
        private List<string> soundFiles;
        private ContextMenu cm;
        private WMPLib.WindowsMediaPlayer _player;
        private List<string> selectedOptions = new List<string>();

        public Form1()
        {
            InitializeComponent();
            _player = new WMPLib.WindowsMediaPlayer();
            trackBar1.Value = 50;
            _player.settings.volume = 50;
            SetPath();
            SetButtonPaths();
        }

        private void SetButtonPaths()
        {
            Button[] AllButtons = new Button[] {button1,button2,button3,button4,button5,button6,button7,button8,button9,button10,button11,button12,button13,button14,button15,button16};
            
            foreach (var button in AllButtons)
            {
                if ((!string.IsNullOrEmpty(ConfigurationManager.AppSettings[button.AccessibleDescription])) && (File.Exists(ConfigurationManager.AppSettings[button.AccessibleDescription])))
                {
                    var buttonPath = ConfigurationManager.AppSettings[button.AccessibleDescription];
                    var buttonName = Path.GetFileNameWithoutExtension(buttonPath);
                    TextInfo ti = new CultureInfo("en-US", false).TextInfo;
                    buttonName = ti.ToTitleCase(buttonName);
                    button.Tag = buttonPath;
                    button.Text = buttonName;
                    SetRightClickSelectedOptions(buttonName);
                }
            }
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
                    if (!selectedOptions.Contains(item))
                    {
                        cm.MenuItems.Add(new MenuItem(item, MenuItem_Click));
                    }
                }

                if (cm.MenuItems.Count == 0)
                {
                    cm.MenuItems.Add(new MenuItem("No unselected sounds"));
                    cm.Show(pressedButton, new Point(pressedButton.Height / 2, pressedButton.Width / 2));
                }
                else
                {
                    cm.Show(pressedButton, new Point(pressedButton.Height / 2, pressedButton.Width / 2));
                }
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
            _pressedButton.Tag = soundFolderPath + "\\" + _pressedButton.Text + ".mp3";
            string path = _pressedButton.Tag as string;
            SetRightClickSelectedOptions(_pressedButton.Text);
            SaveButtonPathToConfig(path);
            
        }

        private void SetRightClickSelectedOptions(String selected)
        {
            selectedOptions.Add(selected);
        }

        private void SaveButtonPathToConfig(string buttonPath)
        {
            ConfigHelper.AddUpdateAppSettings(_pressedButton.AccessibleDescription, buttonPath);
        }

        private void SoundButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var path = "";
            if(button.Tag != null)
            {
                path = button.Tag as string;

                if (File.Exists(path))
                {
                    _player.URL = path;
                    _player.controls.play();
                }
            }
        }

        private void KillSoundButton_Click(object sender, EventArgs e)
        {
            _player.controls.stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _player.settings.volume = trackBar1.Value;

        }

        private void ClearAllButtons_Click(object sender, EventArgs e)
        {
            Button[] AllButtons = new Button[] {button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16};

            foreach(var button in AllButtons)
            {
                button.Tag = "";
                button.Text = "(Empty)";
            }

            selectedOptions.Clear();
        }
    }
}
