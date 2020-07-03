namespace Command.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private GarageDoor _door;
        public GarageDoorCloseCommand(GarageDoor door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Close();
        }

        public void Undo()
        {
            _door.Open();
        }
    }
}
