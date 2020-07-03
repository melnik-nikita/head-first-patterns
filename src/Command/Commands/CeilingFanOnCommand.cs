namespace Command.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        private CeilingFan _fan;

        public CeilingFanOnCommand(CeilingFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.On();
        }

        public void Undo()
        {
            _fan.Off();
        }
    }
}
