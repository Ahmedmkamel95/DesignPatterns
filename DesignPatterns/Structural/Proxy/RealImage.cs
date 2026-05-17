using System;

namespace DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// The real object that performs the actual work.
    /// </summary>
    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading image '{_fileName}' from disk...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image '{_fileName}'.");
        }
    }
}