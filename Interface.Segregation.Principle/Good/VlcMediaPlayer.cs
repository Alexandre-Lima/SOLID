using Interface.Segregation.Principle.Good.Interface;

namespace Interface.Segregation.Principle.Good
{
    public class VlcMediaPlayer : IAudioMediaPlayer , IVideoMediaPlayer
    {
        public void PlayAudio()
        {
            Console.WriteLine(" Playing audio ..........");
        }

        public void PlayVideo()
        {
            Console.WriteLine(" Playing video ..........");
        }
    }
}

