using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Parrot : ISound
    {
        public Parrot()
        {
            PlaySound();
        }
        public void PlaySound()
        {
            Console.WriteLine("p-p-p-parrrrr");
        }
    }
}