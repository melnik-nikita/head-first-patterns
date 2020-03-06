using System;
using Observer.Displays;

namespace Observer
{
    public class WeatherStation
    {
        public void Main()
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurementsChanged(80, 65, 30.4f);
            Console.WriteLine("===========================================");
            weatherData.SetMeasurementsChanged(82, 70, 29.2f);
            Console.WriteLine("===========================================");
            weatherData.SetMeasurementsChanged(78, 90, 29.2f);
        }
    }
}
