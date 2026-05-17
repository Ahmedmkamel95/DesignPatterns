using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// Concrete mediator coordinating message exchange between users.
    /// </summary>
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new();

        public void RegisterUser(User user)
        {
            if (!_users.Contains(user))
            {
                _users.Add(user);
            }
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.Receive(message);
                }
            }
        }
    }
}