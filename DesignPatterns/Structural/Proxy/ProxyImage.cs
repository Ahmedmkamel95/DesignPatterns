namespace DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// Proxy object that controls access to the real image and adds lazy initialization.
    /// </summary>
    public class ProxyImage : IImage
    {
        private readonly string _fileName;
        private RealImage? _realImage;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            // Lazily create the real image only when it is required.
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }

            _realImage.Display();
        }
    }
}