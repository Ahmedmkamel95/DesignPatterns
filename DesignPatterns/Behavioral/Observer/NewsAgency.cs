using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Concrete subject holding state and notifying subscribed observers.
    /// </summary>
    public class NewsAgency : ISubject
    {
        private readonly List<IObserver> _observers = new();
        private string _news = string.Empty;

        public string News
        {
            get => _news;
            set
            {
                _news = value;
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_news);
            }
        }
    }
}