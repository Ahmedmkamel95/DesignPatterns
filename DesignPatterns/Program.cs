using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.Interface;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Creational.Singleton;

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

        /*
         * The Composite Pattern
         * Composes objects into tree structures to represent part-whole hierarchies.
         */
        Employee dev1 = new Employee("Ahmed");
        Employee dev2 = new Employee("Sara");
        Department engineering = new Department("Engineering");
        engineering.Add(dev1);
        engineering.Add(dev2);

        Employee manager = new Employee("Mona");
        Department company = new Department("Headquarters");
        company.Add(engineering);
        company.Add(manager);

        Console.WriteLine("\n--- Company Structure ---");
        company.ShowDetails();

        /*
         * The Facade Pattern
         * Provides a simplified interface to a library, a framework, or any other complex set of classes.
         */
        Console.WriteLine("\n--- Facade Pattern ---");
        var projector = new Projector();
        var soundSystem = new SoundSystem();
        var lights = new Lights();

        var homeTheater = new HomeTheaterFacade(
            projector,
            soundSystem,
            lights
        );

        homeTheater.WatchMovie();
        Console.WriteLine();
        homeTheater.EndMovie();

        /*
         * The Singleton Pattern
         * Ensures a class has only one instance, and provides a global point of access to it.
         */
        Console.WriteLine("\n--- Singleton Pattern ---");
        var config1 = Singleton.GetInstance();
        var config2 = Singleton.GetInstance();

        if (ReferenceEquals(config1, config2))
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }

        /*
         * The Factory Method Pattern
         * Creates objects without exposing the exact creation logic to the client.
         */
        Console.WriteLine("\n--- Factory Method Pattern ---");
        DesignPatterns.Creational.FactoryMethod.VehicleFactory factory;

        factory = new DesignPatterns.Creational.FactoryMethod.CarFactory();
        DesignPatterns.Creational.FactoryMethod.IVehicle factoryCar = factory.CreateVehicle();
        factoryCar.Drive();

        factory = new DesignPatterns.Creational.FactoryMethod.BikeFactory();
        DesignPatterns.Creational.FactoryMethod.IVehicle factoryBike = factory.CreateVehicle();
        factoryBike.Drive();
    }
}