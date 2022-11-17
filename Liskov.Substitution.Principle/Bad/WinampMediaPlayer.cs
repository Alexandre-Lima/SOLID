using Liskov.Substitution.Principle.Bad.Abstract;

namespace Liskov.Substitution.Principle.Bad
{
    public class WinampMediaPlayer : MediaPlayer
    {
        /// <summary>
        /// Play video is not supported in Winamp player
        /// </summary>
        public void PlayVideo()
        {
            throw new NotSupportedException();
        }
    }
}

