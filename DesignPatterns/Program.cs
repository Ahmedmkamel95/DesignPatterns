using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.Interface;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Strategy;

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

        /*
         * The Prototype Pattern
         * Creates new objects by cloning existing prototypes instead of constructing them from scratch.
         */
        Console.WriteLine("--- Prototype Pattern ---");

        var originalDocument = new Document(
            "Project Plan",
            "Version 1 of the project plan.",
            new List<string> { "design", "timeline" }
        );

        PrototypeFactory.RegisterPrototype("projectPlan", originalDocument);

        var clonedDocument = PrototypeFactory.Create("projectPlan");
        clonedDocument.Title = "Project Plan - Copy";
        clonedDocument.Tags.Add("copy");

        originalDocument.Print();
        Console.WriteLine();
        clonedDocument.Print();

        /*
         * The Abstract Factory Pattern
         * Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
         */
        Console.WriteLine("\n--- Abstract Factory Pattern ---");
        IGUIFactory guiFactory;
        string os = "Windows";

        if (os == "Windows")
        {
            guiFactory = new WindowsFactory();
        }
        else
        {
            guiFactory = new MacFactory();
        }

        IButton button = guiFactory.CreateButton();
        ICheckbox checkbox = guiFactory.CreateCheckbox();

        button.Render();
        checkbox.Check();

        /*
         * The Builder Pattern
         * Constructs complex objects step by step and separates construction from representation.
         */
        Console.WriteLine("--- Builder Pattern ---");

        var builder = new ComputerBuilder();
        var director = new ComputerDirector();

        var gamingComputer = director.BuildGamingComputer(builder);
        gamingComputer.PrintSpecifications();

        Console.WriteLine();

        var officeComputer = director.BuildOfficeComputer(builder);
        officeComputer.PrintSpecifications();

        /*
         * The Command Pattern
         * Encapsulates requests as objects, allowing parameterization and queuing of operations.
         */
        Console.WriteLine("--- Command Pattern ---");

        var livingRoomLight = new Light("Living Room");
        var kitchenLight = new Light("Kitchen");
        var remote = new RemoteControl();

        var turnOnLivingRoom = new TurnOnCommand(livingRoomLight);
        var turnOffLivingRoom = new TurnOffCommand(livingRoomLight);
        var turnOnKitchen = new TurnOnCommand(kitchenLight);

        remote.Submit(turnOnLivingRoom);
        remote.Submit(turnOnKitchen);
        remote.Submit(turnOffLivingRoom);

        /*
         * The Interpreter Pattern
         * Builds and evaluates an expression tree from a simple grammar.
         */
        Console.WriteLine("--- Interpreter Pattern ---");

        string arithmeticExpression = "7 + 3 - 2";
        var parsedExpression = ExpressionParser.Parse(arithmeticExpression);

        Console.WriteLine($"Expression: {arithmeticExpression}");
        Console.WriteLine($"Result: {parsedExpression.Interpret()}");

        /*
         * The Strategy Pattern
         * Defines a family of algorithms, encapsulates each one, and makes them interchangeable.
         */
        Console.WriteLine("\n--- Strategy Pattern ---");
        var paymentContext = new PaymentContext(new CreditCardPayment());
        paymentContext.Pay(100);

        paymentContext.SetPaymentStrategy(new PayPalPayment());
        paymentContext.Pay(200);

        paymentContext.SetPaymentStrategy(new CashPayment());
        paymentContext.Pay(50);

        /*
         * The Observer Pattern
         * Allows observers to subscribe to a subject and receive notifications when state changes.
         */
        Console.WriteLine("--- Observer Pattern ---");

        var agency = new NewsAgency();
        var reader1 = new NewsReader("Ahmed");
        var reader2 = new NewsReader("Sara");

        agency.RegisterObserver(reader1);
        agency.RegisterObserver(reader2);

        agency.News = "Breaking: New Observer example implemented!";

        agency.RemoveObserver(reader1);
        agency.News = "Update: Ahmed unsubscribed from news.";

        /*
         * The Mediator Pattern
         * Centralizes communication between objects through a mediator rather than direct peer-to-peer interaction.
         */
        Console.WriteLine("--- Mediator Pattern ---");

        var chatMediator = new ChatMediator();
        var user1 = new ChatUser(chatMediator, "Ali");
        var user2 = new ChatUser(chatMediator, "Fatima");
        var user3 = new ChatUser(chatMediator, "Khalid");

        chatMediator.RegisterUser(user1);
        chatMediator.RegisterUser(user2);
        chatMediator.RegisterUser(user3);

        user1.Send("Hello everyone!");
        user2.Send("Hi Ali, great to see you.");

        /*
         * The Flyweight Pattern
         * Shares common intrinsic state (TreeType) between many objects to reduce memory usage.
         * Each Tree instance keeps only the unique extrinsic state (x, y coordinates).
         */
        Console.WriteLine("--- Flyweight Pattern ---");

        List<Tree> forest = new();

        for (int i = 0; i < 100000; i++)
        {
            // The shared TreeType is reused for every tree with the same name and color.
            TreeType treeType = TreeFactory.GetTreeType("Oak", "Green");
            forest.Add(new Tree(i, i * 2, treeType));
        }

        // Display a couple of sample trees, but avoid printing all 100000 entries.
        forest[0].Display();
        forest[99999].Display();
        Console.WriteLine($"Total trees created: {forest.Count}");

        /*
         * The Proxy Pattern
         * Controls access to a real object and adds lazy creation behavior.
         * The proxy holds a reference to the real object and creates it only when needed.
         */
        Console.WriteLine("--- Proxy Pattern ---");

        IImage image = new ProxyImage("landscape.jpg");
        image.Display();
        image.Display();
    }
}