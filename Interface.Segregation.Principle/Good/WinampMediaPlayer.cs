using Interface.Segregation.Principle.Good.Interface;

namespace Interface.Segregation.Principle.Good
{
    public class WinampMediaPlayer : IAudioMediaPlayer
    {
        public void PlayAudio()
        {
            Console.WriteLine(" Playing audio ..........");
        }
    }
}

