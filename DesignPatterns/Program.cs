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
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Behavioral.NullObject;

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

        /*
         * The Chain of Responsibility Pattern
         * Passes a request along a chain of handlers. Upon receiving a request, each handler decides either to process it or to pass it to the next handler in the chain.
         */
        Console.WriteLine("\n--- Chain of Responsibility Pattern ---");
        
        Approver managerApprover = new Manager();
        Approver directorApprover = new Director();
        Approver presidentApprover = new President();

        managerApprover.SetSuccessor(directorApprover);
        directorApprover.SetSuccessor(presidentApprover);

        // Generate and process purchase requests
        managerApprover.ProcessRequest(500);
        managerApprover.ProcessRequest(4500);
        managerApprover.ProcessRequest(15000);
        managerApprover.ProcessRequest(25000);

        /*
         * The Iterator Pattern
         * Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
         */
        Console.WriteLine("\n--- Iterator Pattern ---");
        
        ItemCollection collection = new ItemCollection();
        collection.AddItem(new Item("Item 1"));
        collection.AddItem(new Item("Item 2"));
        collection.AddItem(new Item("Item 3"));
        collection.AddItem(new Item("Item 4"));

        IIterator iterator = collection.CreateIterator();

        Console.WriteLine("Iterating over collection:");
        for (Item item = iterator.First(); !iterator.IsDone(); item = iterator.Next())
        {
            if (item != null)
            {
                Console.WriteLine(item.Name);
            }
        }

        /*
         * The Memento Pattern
         * Without violating encapsulation, captures and externalizes an object's internal state so that the object can be restored to this state later.
         */
        Console.WriteLine("\n--- Memento Pattern ---");
        
        var editor = new TextEditor();
        var history = new History();

        editor.Type("Hello, ");
        history.Push(editor.Save());

        editor.Type("world!");
        history.Push(editor.Save());

        editor.Type(" This is a mistake.");
        
        // Undo last change
        var lastState = history.Pop();
        if (lastState != null)
        {
            // Restore to "Hello, world!"
            editor.Restore(lastState);
            lastState = history.Pop();
            if (lastState != null)
            {
                // Restore to "Hello, "
                editor.Restore(lastState);
            }
        }

        /*
         * The State Pattern
         * Allows an object to alter its behavior when its internal state changes. The object will appear to change its class.
         */
        Console.WriteLine("\n--- State Pattern ---");
        
        var mediaPlayer = new MediaPlayer();
        
        mediaPlayer.Play();   // Starting the player.
        mediaPlayer.Pause();  // Pausing the player.
        mediaPlayer.Pause();  // Already paused.
        mediaPlayer.Play();   // Resuming the player.
        mediaPlayer.Stop();   // Stopping the player.
        mediaPlayer.Stop();   // Already stopped.

        /*
         * The Template Method Pattern
         * Defines the skeleton of an algorithm in a method, deferring some steps to subclasses.
         * Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
         */
        Console.WriteLine("\n--- Template Method Pattern ---");
        
        Console.WriteLine("CSV Processing:");
        DataProcessor csvProcessor = new CsvDataProcessor();
        csvProcessor.ProcessData();

        Console.WriteLine("\nJSON Processing:");
        DataProcessor jsonProcessor = new JsonDataProcessor();
        jsonProcessor.ProcessData();

        /*
         * The Visitor Pattern
         * Represents an operation to be performed on the elements of an object structure.
         * Visitor lets you define a new operation without changing the classes of the elements on which it operates.
         */
        Console.WriteLine("\n--- Visitor Pattern ---");
        
        var document = new DocumentStructure();
        document.Add(new TextElement("Hello, this is a visitor pattern example."));
        document.Add(new ImageElement("http://example.com/image.png"));
        document.Add(new TextElement("Another text block."));

        var exportVisitor = new ExportVisitor();
        document.Accept(exportVisitor);

        /*
         * The Null Object Pattern
         * Instead of using null references to indicate the absence of an object, use an object that implements the expected interface but whose method bodies are empty or do nothing.
         */
        Console.WriteLine("\n--- Null Object Pattern ---");
        
        // Using a real logger
        Console.WriteLine("With ConsoleLogger:");
        var taskWithLogger = new TaskProcessor(new ConsoleLogger());
        taskWithLogger.Process("Data Cleanup");

        // Using a null logger (no output will be generated, but no exceptions are thrown)
        Console.WriteLine("\nWith NullLogger:");
        var taskWithoutLogger = new TaskProcessor(new NullLogger());
        taskWithoutLogger.Process("Background Sync");
    }
}