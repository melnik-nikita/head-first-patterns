using System;

namespace Strategy.Models.QuackBehavior
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}