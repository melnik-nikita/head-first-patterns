using Fabric.Models;
using Fabric.Models.CaliforniaPizza;

namespace Fabric
{
    public class CaliforniaStore : PizzaStore
    {
        public CaliforniaStore()
        {
        }

        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new CaliforniaCheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new CaliforniaPepperoniPizza();
            }
            else if (type == "clam")
            {
                pizza = new CaliforniaClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new CaliforniaVeggiePizza();
            }

            return pizza;
        }
    }
}
