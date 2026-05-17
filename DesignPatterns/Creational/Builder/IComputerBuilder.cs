namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Builder interface for creating Computer objects step by step.
    /// </summary>
    public interface IComputerBuilder
    {
        IComputerBuilder SetCpu(string cpu);
        IComputerBuilder SetRam(int ram);
        IComputerBuilder SetStorage(string storage);
        IComputerBuilder SetGraphicsCard(string graphicsCard);
        IComputerBuilder SetOperatingSystem(string operatingSystem);
        Computer Build();
    }
}