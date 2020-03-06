namespace Observer.Interfaces
{
    public interface WeatherObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
