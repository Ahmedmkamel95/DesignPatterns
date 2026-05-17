namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// Concrete command that turns the light on.
    /// </summary>
    public class TurnOnCommand : ICommand
    {
        private readonly Light _light;

        public TurnOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}