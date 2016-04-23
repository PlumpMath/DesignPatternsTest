namespace Command.Command
{
    /// <summary>
    /// The Command for turning off the light - ConcreteCommand #2 
    /// </summary>
    public class FlipDownCommand : ICommand
    {
        private Light _light;

        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
