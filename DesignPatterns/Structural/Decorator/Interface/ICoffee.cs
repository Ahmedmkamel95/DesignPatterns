namespace DesignPatterns.Structural.Decorator.Interface
{
    // Interface for the Decorator pattern - defines the contract for coffee objects
    // This is the component interface that both concrete components and decorators implement
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }
}
