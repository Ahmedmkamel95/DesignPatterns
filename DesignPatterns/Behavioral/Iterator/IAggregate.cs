namespace DesignPatterns.Behavioral.Iterator
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
