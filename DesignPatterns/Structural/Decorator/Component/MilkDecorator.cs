using DesignPatterns.Structural.Decorator.Interface;

namespace DesignPatterns.Structural.Decorator.Component
{
    // Concrete decorator in the Decorator pattern - adds milk to the coffee
    // This decorator extends the base coffee with milk functionality and cost
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 2.0;
        }
    }
}
