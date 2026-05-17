namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// Mediator interface defines communication between colleagues.
    /// </summary>
    public interface IChatMediator
    {
        void RegisterUser(User user);
        void SendMessage(string message, User sender);
    }
}