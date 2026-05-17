namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// Concrete colleague representing a chat participant.
    /// </summary>
    public class ChatUser : User
    {
        public ChatUser(IChatMediator mediator, string name)
            : base(mediator, name)
        {
        }
    }
}