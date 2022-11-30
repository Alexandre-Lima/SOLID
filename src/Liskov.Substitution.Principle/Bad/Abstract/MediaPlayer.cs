namespace Liskov.Substitution.Principle.Bad.Abstract
{
    public abstract class MediaPlayer
    {
        // Play audio implementation
        public void PlayAudio()
        {
            Console.WriteLine(" Playing audio ..........");
        }

        // Play video implementation
        public void PlayVideo()
        {
            Console.WriteLine(" Playing video ..........");
        }
    }
}
