using System;
namespace Command
{
    public class Stereo
    {
        public string Name {get; private  set;}
        public Stereo(string name)
        {
            Name = name;
        }
        public void On()
        {
            Console.WriteLine($"{Name} stereo is on.");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} stereo is off.");
        }

        public void SetCd()
        {
            Console.WriteLine($"{Name} stereo is set for CD input.");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{Name} stereo is set for DVD input.");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{Name} stereo is set for Radio input.");
        }

        public void SetVolume(int volumeNumber)
        {
            Console.WriteLine($"{Name} stereo volume set to {volumeNumber}.");
        }
    }
}
