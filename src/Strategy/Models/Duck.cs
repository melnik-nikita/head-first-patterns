using System;
using Strategy.Models.FlyBehavior;
using Strategy.Models.QuackBehavior;

namespace Strategy.Models
{
    public abstract class Duck
    {

        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();

        public void PerformQuack()
        {
            quackBehavior.quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}