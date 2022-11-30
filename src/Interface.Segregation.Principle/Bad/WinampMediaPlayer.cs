using Interface.Segregation.Principle.Bad.Interface;

namespace Interface.Segregation.Principle.Bad
{
    /// <summary>
    /// Princípio da Segregação da Interface — Uma classe não deve ser forçada a implementar interfaces 
    /// e métodos que não irão utilizar.
    /// </summary>
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

