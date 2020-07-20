using System;

namespace Facade
{
    public class TheaterLights
    {
        public void Dim(int amount)
        {
            Console.WriteLine($"Theater Ceiling Lights dimming to {amount}%");
        }

        public void On()
        {
            Console.WriteLine("Theater Ceiling Lights on");
        }
    }
}
