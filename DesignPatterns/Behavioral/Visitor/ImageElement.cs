namespace DesignPatterns.Behavioral.Visitor
{
    public class ImageElement : IElement
    {
        public string Url { get; }

        public ImageElement(string url)
        {
            Url = url;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitImageElement(this);
        }
    }
}
