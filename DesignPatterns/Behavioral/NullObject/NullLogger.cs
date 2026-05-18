namespace DesignPatterns.Behavioral.NullObject
{
    public class NullLogger : ILogger
    {
        public void Log(string message)
        {
            // Do nothing. This is the essence of the Null Object pattern.
        }
    }
}
