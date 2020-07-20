using System;

namespace Facade
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn Popper on");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn Popper popping popcorn!");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn Popper off");
        }
    }
}
