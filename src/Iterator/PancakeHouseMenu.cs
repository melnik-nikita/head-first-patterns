using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenu
    {
        private readonly List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            AddItem(
                "K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99
            );
            AddItem(
                "Regular Pancake Breakfast",
                "Pancakes with fired eggs, sausage",
                true,
                2.99
            );
            AddItem(
                "Blueberry Breakfast",
                "Pancakes with fresh blueberries",
                true,
                3.49
            );
            AddItem(
                "Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59
            );
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);

            menuItems.Add(menuItem);
        }

        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }
    }
}
