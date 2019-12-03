using System;

namespace Strategy.Models.QuackBehavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}