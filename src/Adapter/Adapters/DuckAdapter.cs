using System;
using Adapter.Ducks;
using Adapter.Turkeys;

namespace Adapter.Adapters
{
    public class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            Console.WriteLine("Can't stop flying.");
            _duck.Fly();
        }
    }
}
