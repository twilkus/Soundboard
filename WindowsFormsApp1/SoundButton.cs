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

        public Player Player { get; set; }
        public string Path { get; set; }
        public string ButtonName { get; set; }
    }
}
