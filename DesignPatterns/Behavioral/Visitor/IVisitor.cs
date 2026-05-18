namespace DesignPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void VisitTextElement(TextElement element);
        void VisitImageElement(ImageElement element);
    }
}
