namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Director that controls the building process using an IComputerBuilder.
    /// </summary>
    public class ComputerDirector
    {
        public Computer BuildGamingComputer(IComputerBuilder builder)
        {
            return builder
                .SetCpu("Intel Core i9")
                .SetRam(32)
                .SetStorage("2TB NVMe SSD")
                .SetGraphicsCard("NVIDIA RTX 4090")
                .SetOperatingSystem("Windows 11")
                .Build();
        }

        public Computer BuildOfficeComputer(IComputerBuilder builder)
        {
            return builder
                .SetCpu("Intel Core i5")
                .SetRam(16)
                .SetStorage("512GB SSD")
                .SetGraphicsCard("Integrated Graphics")
                .SetOperatingSystem("Windows 11 Pro")
                .Build();
        }
    }
}