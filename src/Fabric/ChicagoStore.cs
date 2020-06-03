using Fabric.Models;
using Fabric.Models.ChicagoPizza;

namespace Fabric
{
    public class ChicagoStore : PizzaStore
    {
        public ChicagoStore()
        {
        }

        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new ChicagoCheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new ChicagoPepperoniPizza();
            }
            else if (type == "clam")
            {
                pizza = new ChicagoClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new ChicagoVeggiePizza();
            }

            return pizza;
        }
    }
}
