using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class CsvDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading data from CSV file...");
        }

        protected override void Process()
        {
            Console.WriteLine("Processing CSV data...");
        }
    }
}
