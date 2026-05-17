using System;

namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// Colleague base class that delegates communication through a mediator.
    /// </summary>
    public class User
    {
        private readonly IChatMediator _mediator;

        public string Name { get; }

        public User(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public virtual void Receive(string message)
        {
            Console.WriteLine($"{Name} receives: {message}");
        }
    }
}