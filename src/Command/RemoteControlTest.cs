using Command.Commands;

namespace Command
{
    public class RemoteControlTest
    {
        public static void Run()
        {
            SimpleRemoteControl remote  = new SimpleRemoteControl();
            Light light  = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoor door = new GarageDoor();
            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(door);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
        }
    }
}
