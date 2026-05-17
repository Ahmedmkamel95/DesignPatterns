namespace DesignPatterns.Behavioral.Interpreter
{
    /// <summary>
    /// Interpreter interface for expression nodes.
    /// </summary>
    public interface IExpression
    {
        int Interpret();
    }
}