namespace DesignPatterns.Behavioral.Iterator
{
    public class ItemIterator : IIterator
    {
        private ItemCollection _collection;
        private int _current = 0;

        public ItemIterator(ItemCollection collection)
        {
            this._collection = collection;
        }

        public Item First()
        {
            _current = 0;
            return _collection[_current];
        }

        public Item? Next()
        {
            _current += 1;
            if (!IsDone())
            {
                return _collection[_current];
            }
            else
            {
                return null;
            }
        }

        public bool IsDone()
        {
            return _current >= _collection.Count;
        }

        public Item CurrentItem()
        {
            return _collection[_current];
        }
    }
}
