namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// Concrete command that turns the light off.
    /// </summary>
    public class TurnOffCommand : ICommand
    {
        private readonly Light _light;

        public TurnOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}