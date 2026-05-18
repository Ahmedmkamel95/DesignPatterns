using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor
{
    public class DocumentStructure
    {
        private List<IElement> _elements = new List<IElement>();

        public void Add(IElement element)
        {
            _elements.Add(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
