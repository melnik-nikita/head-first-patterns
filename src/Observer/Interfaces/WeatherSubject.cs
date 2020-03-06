namespace Observer.Interfaces
{
    public interface WeatherSubject
    {
        void RegisterObserver(WeatherObserver observer);
        void RemoveObserver(WeatherObserver observer);
        void NotifyObservers();
    }
}
