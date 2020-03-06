using System;
using Decorator;
using Decorator.Beverages;
using Decorator.Condiments;

namespace Decorator
{
    public class StarbuzzCoffee
    {
        public static void MakeSomeCoffee()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"{darkRoast.GetDescription()} ${darkRoast.Cost()}");

            Beverage houseBlend = new HouseBlend();
            houseBlend.SetSize(Size.VENTI);
            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()} ${houseBlend.Cost()}");
        }
    }
}
