using System.Linq;
using System;
using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer.Displays
{
    public class StatisticsDisplay : WeatherObserver, DisplayElement
    {
        private readonly WeatherSubject _weatherSubject;
        private float Min;
        private float Max;
        private IList<float> All;

        public StatisticsDisplay(WeatherSubject subject)
        {
            _weatherSubject = subject;
            subject.RegisterObserver(this);

            All = new List<float>();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Min = Math.Min(Min, temperature);
            Max = Math.Max(Max, temperature);
            All.Add(temperature);
            Display();
        }

        public void Display()
        {
            float avg = All.Sum() / All.Count;
            Console.WriteLine($"Avg/Max/Min temperature = {avg}/{Max}/{Min}");
        }
    }
}
