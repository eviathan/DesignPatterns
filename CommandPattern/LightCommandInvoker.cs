
using CommandPattern.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class LightCommandInvoker
    {
        private ICommand _enableCommand { get; set; }

        public LightCommandInvoker(ICommand enableCommand)
        {
            _enableCommand = enableCommand;
        }

        public void Enable()
        {
            _enableCommand.Execute();
        }

        public void Disable()
        {
            _enableCommand.Undo();
        }

        internal void SetCommand(ICommand enableCommand)
        {
            _enableCommand = enableCommand;
        }
    }
}