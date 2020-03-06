using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer
{
    public class WeatherData : WeatherSubject
    {
        private IList<WeatherObserver> _weatherObservers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _weatherObservers = new List<WeatherObserver>();
        }

        public void RegisterObserver(WeatherObserver observer)
        {
            _weatherObservers.Add(observer);
        }

        public void RemoveObserver(WeatherObserver observer)
        {
            _weatherObservers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (WeatherObserver observer in _weatherObservers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void SetMeasurementsChanged(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public float GetTemperature()
        {
            return _temperature;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }
    }
}
