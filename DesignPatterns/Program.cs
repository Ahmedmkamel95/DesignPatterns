using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.Interface;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;

class Program
{
    static void Main(string[] args)
    {
        /* The Decorator pattern allows us to add new functionality to an existing object without altering its structure.
         * In this example, we have a simple coffee that can be decorated with additional features like milk and sugar.
         * Each decorator adds its own cost and description to the base coffee.
         */
        ICoffee coffee = new SimpleCoffee();

        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);

        Console.WriteLine(coffee.GetDescription());
        Console.WriteLine("Total Cost: " + coffee.GetCost());

        /* The Adapter pattern allows incompatible interfaces to work together.
         * In this example, we adapt a Type-C charger to work with an iPhone charging interface.
         */
        TypeCCharger typeCCharger = new TypeCCharger();
        IPhoneCharger adapter = new ChargerAdapter(typeCCharger);
        adapter.ChargeWithIPhone();

        /* 5️⃣ الاستخدام (The Bridge Pattern)
         * Decouples an abstraction from its implementation so that the two can vary independently.
         */
        Vehicle petrolCar = new Car(new PetrolEngine());
        petrolCar.Drive();

        Vehicle electricCar = new Car(new ElectricEngine());
        electricCar.Drive();
    }
}