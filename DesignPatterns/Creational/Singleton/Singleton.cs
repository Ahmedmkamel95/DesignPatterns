using System;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;

        // Private constructor prevents direct instantiation
        private Singleton()
        {
            Console.WriteLine("Singleton Instance Created.");
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
