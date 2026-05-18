using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class JsonDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading data from JSON file...");
        }

        protected override void Process()
        {
            Console.WriteLine("Processing JSON data...");
        }
    }
}
