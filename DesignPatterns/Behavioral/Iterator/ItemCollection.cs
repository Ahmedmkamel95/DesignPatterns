using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ItemCollection : IAggregate
    {
        private List<Item> _items = new List<Item>();

        public IIterator CreateIterator()
        {
            return new ItemIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public Item this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }
    }
}
