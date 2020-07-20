using System;

namespace Facade
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Top-O-Line Amplifier on");
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine($"Top-O-Line Amplifier setting DVD player to {dvd.Name} DVD Player");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Top-O-Line Amplifier surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Top-O-Line Amplifier setting volume to {volume}");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line Amplifier off");
        }
    }
}
