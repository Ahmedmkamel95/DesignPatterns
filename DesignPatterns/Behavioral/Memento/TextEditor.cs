using System;

namespace DesignPatterns.Behavioral.Memento
{
    public class TextEditor
    {
        private string _content = "";

        public void Type(string words)
        {
            _content += words;
            Console.WriteLine($"Current Text: {_content}");
        }

        public string Content
        {
            get { return _content; }
        }

        public TextMemento Save()
        {
            return new TextMemento(_content);
        }

        public void Restore(TextMemento memento)
        {
            if (memento != null)
            {
                _content = memento.State;
                Console.WriteLine($"Restored Text: {_content}");
            }
        }
    }
}
