using System.Text;
namespace Command
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();

            for(int i = 0; i < _offCommands.Length; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                builder.Append($"[slot {i}] {_onCommands[i].GetType().Name}      {_offCommands[i].GetType().Name}\n");
            }

            return builder.ToString();
        }
    }
}
