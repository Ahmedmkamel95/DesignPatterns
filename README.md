# Design Patterns

This repository demonstrates the 24 Gang of Four (GoF) design patterns, organized into the three classic categories:

- **Creational Patterns**
- **Structural Patterns**
- **Behavioral Patterns**

The project is structured under the `DesignPatterns` folder with subfolders for each category.

## Project Structure

- `DesignPatterns/Creational/` - Creational pattern implementations
- `DesignPatterns/Structural/` - Structural pattern implementations
- `DesignPatterns/Behavioral/` - Behavioral pattern implementations
- `DesignPatterns/Program.cs` - Example entry point showing the Decorator pattern

## GoF Design Patterns

### Creational Patterns

1. Abstract Factory
2. Builder
3. Factory Method
4. Prototype
5. Singleton

### Structural Patterns

6. Adapter
7. Bridge
8. Composite
9. Decorator
10. Facade
11. Flyweight
12. Proxy

### Behavioral Patterns

13. Chain of Responsibility
14. Command
15. Interpreter
16. Iterator
17. Mediator
18. Memento
19. Observer
20. State
21. Strategy
22. Template Method
23. Visitor
24. Null Object

## About This Repository

This repository is intended as a learning and reference implementation of the 24 classic GoF design patterns in C#.

The current `Program.cs` example demonstrates the Structural `Decorator` pattern by composing a coffee object with optional decorators for milk and sugar.

## Running the Project

From the solution root, run:

```powershell
cd .\DesignPatterns
dotnet run
```

## Notes

- Each pattern should be implemented in its respective category folder.
- The README lists all 24 GoF patterns so the project structure and goals are clear.
