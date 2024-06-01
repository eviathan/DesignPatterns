using CommandPattern.Interfaces;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class EnableLightCommand : ICommand
    {
        private readonly LightReciever _light;

        public EnableLightCommand(LightReciever light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Enabled = true;
        }

        public void Undo()
        {
            _light.Enabled = false;
        }
    }
}