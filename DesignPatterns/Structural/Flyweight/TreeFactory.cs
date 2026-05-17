using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Factory that returns shared TreeType instances instead of creating new ones each time.
    /// </summary>
    public class TreeFactory
    {
        private static readonly Dictionary<string, TreeType> _treeTypes = new();

        public static TreeType GetTreeType(string name, string color)
        {
            string key = $"{name}_{color}";

            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color);
            }

            return _treeTypes[key];
        }
    }
}