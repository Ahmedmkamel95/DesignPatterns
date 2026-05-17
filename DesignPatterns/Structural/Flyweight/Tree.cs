namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Context object that contains unique extrinsic state for each tree instance.
    /// </summary>
    public class Tree
    {
        private readonly int _x;
        private readonly int _y;
        private readonly TreeType _type;

        public Tree(int x, int y, TreeType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        public void Display()
        {
            _type.Display(_x, _y);
        }
    }
}