using System;

namespace Facade
{
    public class DvdPlayer
    {
        private string _movie;

        public DvdPlayer(string name = "Top-O-Line")
        {
            Name = name;
        }

        public string Name { get; }

        public void On()
        {
            Console.WriteLine($"{Name} DVD Player on");
        }

        public void Play(string movie)
        {
            _movie = movie;
            Console.WriteLine($"{Name} DVD Player playing \"{_movie}\"");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} DVD Player stopped \"{_movie}\"");
        }

        public void Eject()
        {
            Console.WriteLine($"{Name} DVD Player eject");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} DVD Player off");
        }
    }
}
