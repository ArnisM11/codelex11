using System;

namespace MakeSounds
{
    public class Firework: ISound
    {
        public Firework()
        {
            PlaySound();
        }
        public void PlaySound()
        {
            Console.WriteLine("whoosh-bang");
        }
    }
}