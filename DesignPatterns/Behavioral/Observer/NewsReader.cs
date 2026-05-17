using System;

namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Concrete observer that reacts to news updates from the subject.
    /// </summary>
    public class NewsReader : IObserver
    {
        private readonly string _name;

        public NewsReader(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received news: {message}");
        }
    }
}