namespace DesignPatterns.Behavioral.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
