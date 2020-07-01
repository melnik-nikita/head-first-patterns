using Fabric.Models;
using Fabric.Models.Ingredients;

namespace Fabric.Stores
{
    public class CaliforniaStore : PizzaStore
    {
        public CaliforniaStore()
        {
        }

        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new CaliforniaPizzaIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "California Style Cheese Pizza";
            }
            else if (type == "pepperoni")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "California Style Veggie Pizza";
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "California Style Clam Pizza";
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "California Style Veggie Pizza";
            }

            return pizza;
        }
    }
}
