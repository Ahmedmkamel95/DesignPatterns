using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// Invoker class that executes commands on request.
    /// </summary>
    public class RemoteControl
    {
        private readonly List<ICommand> _commands = new();

        public void Submit(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }

        public void RunAll()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}