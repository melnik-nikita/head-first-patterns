using System;
using Strategy.Models.FlyBehavior;
using Strategy.Models.QuackBehavior;

namespace Strategy.Models
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}