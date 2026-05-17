namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Concrete builder for constructing Computer objects.
    /// </summary>
    public class ComputerBuilder : IComputerBuilder
    {
        private string _cpu = string.Empty;
        private int _ram;
        private string _storage = string.Empty;
        private string _graphicsCard = string.Empty;
        private string _operatingSystem = string.Empty;

        public IComputerBuilder SetCpu(string cpu)
        {
            _cpu = cpu;
            return this;
        }

        public IComputerBuilder SetRam(int ram)
        {
            _ram = ram;
            return this;
        }

        public IComputerBuilder SetStorage(string storage)
        {
            _storage = storage;
            return this;
        }

        public IComputerBuilder SetGraphicsCard(string graphicsCard)
        {
            _graphicsCard = graphicsCard;
            return this;
        }

        public IComputerBuilder SetOperatingSystem(string operatingSystem)
        {
            _operatingSystem = operatingSystem;
            return this;
        }

        public Computer Build()
        {
            return new Computer(_cpu, _ram, _storage, _graphicsCard, _operatingSystem);
        }
    }
}