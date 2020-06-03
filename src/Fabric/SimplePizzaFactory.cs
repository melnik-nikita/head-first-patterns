using Fabric.Models;

namespace Fabric
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (pizzaType == "pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            else if (pizzaType == "clam")
            {
                pizza = new ClamPizza();
            }
            else if (pizzaType == "veggie")
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}
