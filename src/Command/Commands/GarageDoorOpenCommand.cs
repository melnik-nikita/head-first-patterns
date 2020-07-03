namespace Command.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor _door;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Open();
        }

        public void Undo()
        {
            _door.Close();
        }
    }
}
