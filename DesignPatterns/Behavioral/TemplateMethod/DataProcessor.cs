using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class DataProcessor
    {
        // The template method defining the skeleton of the algorithm.
        public void ProcessData()
        {
            ReadData();
            Process();
            SaveData();
        }

        protected abstract void ReadData();
        protected abstract void Process();

        // This is a hook or common behavior that subclasses can override if needed,
        // but it has a default implementation.
        protected virtual void SaveData()
        {
            Console.WriteLine("Saving processed data to the database...");
        }
    }
}
