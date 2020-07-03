using System;

namespace Command
{
    public class Light
    {
        public string Location {get; private set;}
        public Light()
            :this("")
        { }

        public Light(string location)
        {
            Location = location;
        }
        public void On()
        {
            Console.WriteLine($"{Location} light is on.");
        }

        public void Off()
        {
            Console.WriteLine($"{Location} light is off.");
        }
    }
}
