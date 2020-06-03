using Fabric.Models;
using Fabric.Models.NYPizza;

namespace Fabric
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore()
        {
        }

        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new NYStylePepperoniPizza();
            }
            else if (type == "clam")
            {
                pizza = new NYStyleClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new NYStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
