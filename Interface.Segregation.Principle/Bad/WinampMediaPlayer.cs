using Interface.Segregation.Principle.Bad.Interface;

namespace Interface.Segregation.Principle.Bad
{
    public class WinampMediaPlayer : IMediaPlayer
    {     
        public void PlayAudio()
        {
            Console.WriteLine(" Playing audio ..........");
        }

        /// <summary>
        /// Play video is not supported in Winamp player
        /// </summary>
        public void PlayVideo()
        {
            throw new NotSupportedException();
        }
    }
}

