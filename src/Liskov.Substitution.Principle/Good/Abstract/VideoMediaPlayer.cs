namespace Liskov.Substitution.Principle.Good.Abstract
{
    public abstract class VideoMediaPlayer : AudioMediaPlayer
    {
        // Play video implementation
        public void PlayVideo()
        {
            Console.WriteLine(" Playing video ..........");
        }
    }
}
