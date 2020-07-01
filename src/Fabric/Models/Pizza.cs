using System;
using System.Collections.Generic;
using Fabric.Models.Ingredients;

namespace Fabric.Models
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        // protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clams;

        public override string ToString()
        {
            return "Pizza description";
        }

        public abstract void Prepare();

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
