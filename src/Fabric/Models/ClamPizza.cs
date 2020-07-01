using System;
using Fabric.Models.Ingredients;

namespace Fabric.Models
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory _pizzaIngredientFactory;

        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");

            dough = _pizzaIngredientFactory.CreateDough();
            sauce = _pizzaIngredientFactory.CreateSauce();
            cheese = _pizzaIngredientFactory.CreateCheese();
            clams = _pizzaIngredientFactory.CreateClam();
        }
    }
}
