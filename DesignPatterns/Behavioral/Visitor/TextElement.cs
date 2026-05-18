namespace DesignPatterns.Behavioral.Visitor
{
    public class TextElement : IElement
    {
        public string Text { get; }

        public TextElement(string text)
        {
            Text = text;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTextElement(this);
        }
    }
}
