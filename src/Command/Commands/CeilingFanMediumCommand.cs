namespace Command.Commands
{
    public class CeilingFanMediumCommand : ICommand
    {
        private CeilingFan _fan;
        private int _prevSpeed;

        public CeilingFanMediumCommand(CeilingFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _prevSpeed = _fan.Speed;
            _fan.Medium();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFan.HIGH)
            {
                _fan.High();
            }
            else if (_prevSpeed == CeilingFan.MEDIUM)
            {
                _fan.Medium();
            }
            else if (_prevSpeed == CeilingFan.LOW)
            {
                _fan.Low();
            }
            else if (_prevSpeed == CeilingFan.OFF)
            {
                _fan.Off();
            }
        }
    }
}
