namespace Soundboard
{
    public class Player
    {
        WMPLib.WindowsMediaPlayer WindowsMediaPlayer { get; set; }

        public Player()
        {
            WindowsMediaPlayer = new WMPLib.WindowsMediaPlayer();
        }

        public void Play()
        {
            WindowsMediaPlayer.controls.play();
        }

        public void Stop()
        {
            WindowsMediaPlayer.controls.stop();
        }

        public void SetVolume(int volume)
        {
            WindowsMediaPlayer.settings.volume = volume;
        }
    }
}
