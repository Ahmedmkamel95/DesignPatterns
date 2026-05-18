using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Memento
{
    public class History
    {
        private Stack<TextMemento> _history = new Stack<TextMemento>();

        public void Push(TextMemento memento)
        {
            _history.Push(memento);
        }

        public TextMemento? Pop()
        {
            if (_history.Count > 0)
            {
                return _history.Pop();
            }
            return null;
        }
    }
}
