using System;
using Adapter.Adapters;
using Adapter.Ducks;
using Adapter.Turkeys;

namespace Adapter
{
    public class DuckTestDrive
    {
        public static void Test()
        {
            var duck = new MallardDuck();
            var turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says...");
            TestDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
