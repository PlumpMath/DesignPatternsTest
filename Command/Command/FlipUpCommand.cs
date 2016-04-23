namespace Command.Command
{
    /// <summary>
    /// The Command for turning on the light - ConcreteCommand #1 
    /// </summary>
    public class FlipUpCommand : ICommand
    {
        private Light _light;

        public FlipUpCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
