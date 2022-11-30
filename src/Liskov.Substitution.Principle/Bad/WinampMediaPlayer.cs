using Liskov.Substitution.Principle.Bad.Abstract;

namespace Liskov.Substitution.Principle.Bad
{
    /// <summary>
    /// Princípio da substituição de Liskov — Uma classe derivada deve ser substituível por sua classe base.
    /// </summary>
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

