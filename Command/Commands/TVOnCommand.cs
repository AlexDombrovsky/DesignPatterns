using Command.Commands.Abstract;
using Command.Receivers;

namespace Command.Commands
{
    internal class TVOnCommand : ICommand
    {
        private readonly TV _tv;

        public TVOnCommand(TV tvSet)
        {
            _tv = tvSet;
        }

        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}