namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Prototype interface declaring a clone operation for copying objects.
    /// </summary>
    public interface IPrototype<T>
    {
        T Clone();
    }
}