using System;

namespace Strategy.Models
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Decoy Duck");
        }
    }
}