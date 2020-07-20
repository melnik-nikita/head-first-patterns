using System;

namespace TemplateMethod
{
    public static class BeverageTestDrive
    {
        public static void Test()
        {
            var teaWithHook = new TeaWithHook();
            var coffeeWithHook = new CoffeeWithHook();

            Console.WriteLine("\nMaking tea...");
            teaWithHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeWithHook.PrepareRecipe();
        }
    }
}
