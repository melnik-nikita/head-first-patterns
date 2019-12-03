using System;
using Strategy.Models.FlyBehavior;
using Strategy.Models.QuackBehavior;

namespace Strategy.Models
{
    public class ModelDuck : Duck
    {

        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }

    }
}