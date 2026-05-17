namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Observer interface defines the update method called by the subject.
    /// </summary>
    public interface IObserver
    {
        void Update(string message);
    }
}