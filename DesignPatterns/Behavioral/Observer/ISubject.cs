using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Subject interface that allows observers to subscribe, unsubscribe, and receive notifications.
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}