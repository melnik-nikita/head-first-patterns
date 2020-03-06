using System;
using Observer.Interfaces;

namespace Observer.Displays
{
    public class CurrentConditionsDisplay : WeatherObserver, DisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly WeatherSubject _weatherData;

        public CurrentConditionsDisplay(WeatherSubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity.");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }
    }
}
