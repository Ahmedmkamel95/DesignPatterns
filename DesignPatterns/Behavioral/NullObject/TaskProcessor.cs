namespace DesignPatterns.Behavioral.NullObject
{
    public class TaskProcessor
    {
        private readonly ILogger _logger;

        public TaskProcessor(ILogger? logger = null)
        {
            // If null is passed, default to NullLogger to avoid NullReferenceException
            _logger = logger ?? new NullLogger();
        }

        public void Process(string taskName)
        {
            _logger.Log($"Starting task: {taskName}");
            // Imagine complex task processing here
            _logger.Log($"Finished task: {taskName}");
        }
    }
}
