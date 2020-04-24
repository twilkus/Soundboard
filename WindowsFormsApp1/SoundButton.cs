using System.Drawing;
using System.Windows.Forms;

namespace Soundboard
{
    public class SoundButton : Button
    {
        private string _path;

        public PictureBox PlayPicture { get; set; }
        public Player Player { get; set; }

        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                Player.WindowsMediaPlayer.URL = value;
                Player.WindowsMediaPlayer.Ctlcontrols.stop();
                Player.WindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
            }
        }

        public SoundButton()
        {
            Player = new Player();
        }

        public SoundButton(string text, string path)
        {
            Player = new Player();
            Text = text;
            Path = path;
        }

        public void Play()
        {
            Player.Play();
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.LawnGreen;
        }

        public void Stop()
        {
            Player.Stop();
            SetStyleBackToDefault();
        }

        public void SetStyleBackToDefault()
        {
            FlatStyle = FlatStyle.Standard;
            UseVisualStyleBackColor = true;
        }

        public void SetVolume(int volume)
        {
            Player.SetVolume(volume);
        }

        public bool IsPlaying()
        {
            return Player.WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying;
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch ((PlayState)e.newState)
            {
                case PlayState.Undefined:
                    break;
                case PlayState.MediaEnded:
                    SetStyleBackToDefault();
                    break;
                default:
                    break;
            }
        }
    }
}
