using Interface.Segregation.Principle.Bad.Interface;

namespace Interface.Segregation.Principle.Bad
{
    public class DivMediaPlayer : IMediaPlayer
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

