using System;
using System.Collections.Generic;

namespace Fabric.Models
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected IList<string> toppings = new List<string>();

        public string Name { get => name; }

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");

            foreach (string topping in toppings)
            {
                Console.WriteLine($"    {topping}");
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("BAke for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }


    }
}
