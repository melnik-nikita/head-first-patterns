namespace Command.Commands
{
    public class CeilingFanOffCommand: ICommand
    {
        private CeilingFan _fan;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.Off();
        }

        public void Undo()
        {
            _fan.On();
        }
    }
}
