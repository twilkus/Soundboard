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
        private SoundButton _pressedButton;
        private string soundFolderPath;
        private List<string> soundFiles;
        private ContextMenu cm;
        private SoundButton[] _allButtons;
        private List<string> selectedOptions = new List<string>();

        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 50;
            _allButtons = new SoundButton[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16 };
            SetPath();
            SetButtonPaths();
        }

        private void SetButtonPaths()
        {
            foreach (var button in _allButtons)
            {
                if ((!string.IsNullOrEmpty(ConfigurationManager.AppSettings[button.AccessibleDescription])) && (File.Exists(ConfigurationManager.AppSettings[button.AccessibleDescription])))
                {
                    var buttonPath = ConfigurationManager.AppSettings[button.AccessibleDescription];
                    var buttonName = Path.GetFileNameWithoutExtension(buttonPath);
                    TextInfo ti = new CultureInfo("en-US", false).TextInfo;
                    buttonName = ti.ToTitleCase(buttonName);
                    button.Path = buttonPath;
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
            var pressedButton = sender as SoundButton;
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
            var buttonName = item.Text;
            var path = soundFolderPath + "\\" + buttonName + ".mp3";

            _pressedButton.Text = buttonName;
            _pressedButton.Path = path;
            
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

        private void SaveButtonPathToConfig(SoundButton button, string buttonPath)
        {
            ConfigHelper.AddUpdateAppSettings(button.AccessibleDescription, buttonPath);
        }

        private void SoundButton_Click(object sender, EventArgs e)
        {
            var button = sender as SoundButton;
            
            if(button.IsPlaying())
            {
                button.Stop();
            } 
            else if (File.Exists(button.Path))
            {
                button.Play();
            }
        }

        private void KillSoundButton_Click(object sender, EventArgs e)
        {
            foreach (var soundButton in _allButtons)
            {
                soundButton.Stop();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            foreach(var soundButton in _allButtons)
            {
                soundButton.SetVolume(trackBar1.Value);
            }
        }

        private void ClearAllButtons_Click(object sender, EventArgs e)
        {
            foreach(var button in _allButtons)
            {
                SaveButtonPathToConfig(button, "");
                button.Path = "";
                button.Text = "(Empty)";
                button.Player = new Player();
            }
            selectedOptions.Clear();
        }
    }
}
