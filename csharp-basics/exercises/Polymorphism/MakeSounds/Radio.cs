using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    internal class Radio : ISound
    {
        public Radio()
        {
            PlaySound();
        }
        public void PlaySound()
        {
            Console.WriteLine("pshshshshshs");
        }
    }
}
