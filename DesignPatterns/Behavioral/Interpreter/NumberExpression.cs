namespace DesignPatterns.Behavioral.Interpreter
{
    /// <summary>
    /// Leaf expression representing a number.
    /// </summary>
    public class NumberExpression : IExpression
    {
        private readonly int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret() => _number;
    }
}