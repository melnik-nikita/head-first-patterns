using System;

namespace Strategy.Models
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Rubber Duck display");
        }
    }
}