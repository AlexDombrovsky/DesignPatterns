using Command.Commands.Abstract;

namespace Command.Invokers
{
    internal class Pult
    {
        private ICommand _command;

        public void SetCommand(ICommand com)
        {
            _command = com;
        }

        public void PressButton()
        {
            _command?.Execute();
        }

        public void PressUndo()
        {
            _command?.Undo();
        }
    }
}