using System.Windows.Forms;

namespace Soundboard
{
    public class SoundButton : Button
    {
        public SoundButton()
        {
            Player = new Player();
        }

        public SoundButton(string buttonName, string path)
        {
            Player = new Player();
            Text = buttonName;
            ButtonName = buttonName;
            Path = path;
        }

        private string _path;

        public Player Player { get; set; }
        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                Player.WindowsMediaPlayer.URL = value;
                Player.WindowsMediaPlayer.controls.stop();
            }
        }
        public string ButtonName { get; set; }
    }
}
