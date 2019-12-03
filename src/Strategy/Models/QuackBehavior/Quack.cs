using System;

namespace Strategy.Models.QuackBehavior
{
    public class Quack : IQuackBehavior
    {
        public void quack() => Console.WriteLine("Quack");
    }
}