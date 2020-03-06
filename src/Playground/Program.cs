using System;
using Observer;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();
            station.Main();
        }
    }
}
