using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class ExportVisitor : IVisitor
    {
        public void VisitTextElement(TextElement element)
        {
            Console.WriteLine($"Exporting Text: {element.Text}");
        }

        public void VisitImageElement(ImageElement element)
        {
            Console.WriteLine($"Exporting Image from URL: {element.Url}");
        }
    }
}
