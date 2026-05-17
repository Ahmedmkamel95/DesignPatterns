using System.Collections.Generic;

namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Registry for prototype instances that can be cloned on demand.
    /// </summary>
    public static class PrototypeFactory
    {
        private static readonly Dictionary<string, Document> _prototypes = new();

        public static void RegisterPrototype(string key, Document prototype)
        {
            _prototypes[key] = prototype;
        }

        public static Document Create(string key)
        {
            if (_prototypes.TryGetValue(key, out var prototype))
            {
                return prototype.Clone();
            }

            throw new KeyNotFoundException($"Prototype with key '{key}' is not registered.");
        }
    }
}