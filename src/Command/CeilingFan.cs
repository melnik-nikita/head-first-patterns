using System;
namespace Command
{
    public class CeilingFan
    {
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;
        public string Location {get; private set;}
        public  int Speed {get; private set;}

        public CeilingFan(string location = "")
        {
            Location = location;
            Speed = OFF;
        }

        public void High()
        {
            Speed = HIGH;
        }

        public void Medium()
        {
            Speed = MEDIUM;
        }

        public void Low()
        {
            Speed = LOW;
        }

        public void On()
        {
            Console.WriteLine($"{Location} ceiling fan is on high.");
        }

        public void Off()
        {
            Console.WriteLine($"{Location} ceiling fan is off.");
            Speed = OFF;
        }
    }
}
