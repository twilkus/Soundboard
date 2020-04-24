namespace Soundboard
{
    public class Player
    {
        public AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer { get; set; }

        public Player()
        {
            WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            WindowsMediaPlayer.CreateControl();
        }

        public void Play()
        {
            WindowsMediaPlayer.Ctlcontrols.play();
        }

        public void Stop()
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
        }

        public void SetVolume(int volume)
        {
            WindowsMediaPlayer.settings.volume = volume;
        }
    }
}
