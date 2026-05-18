namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator
    {
        Item First();
        Item Next();
        bool IsDone();
        Item CurrentItem();
    }
}
