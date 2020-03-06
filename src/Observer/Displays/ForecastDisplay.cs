using System;
using Observer.Interfaces;

namespace Observer.Displays
{
    public class ForecastDisplay : WeatherObserver, DisplayElement
    {
        private WeatherSubject _weatherSubject;
        private string[] _forecasts;

        public ForecastDisplay(WeatherSubject subject)
        {
            _weatherSubject = subject;
            subject.RegisterObserver(this);

            _forecasts = new string[] {
                "Improving weather on the way!",
                "Watch out for cooler, rainy weather",
                "More of the same"
            };
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Display();
        }

        public void Display()
        {
            Random rand = new Random();
            Console.WriteLine($"Forecast: {_forecasts[rand.Next(_forecasts.Length - 1)]}");
        }
    }
}
