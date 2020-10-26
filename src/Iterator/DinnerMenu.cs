﻿using System;

namespace Iterator
{
    public class DinnerMenu
    {
        private const int MAX_ITEMS = 6;
        private readonly MenuItem[] _menuItems;
        private int numberOfItems;

        public DinnerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);

            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);

            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);

            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);

            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                _menuItems[numberOfItems] = menuItem;
                numberOfItems += 1;
            }
        }

        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }
    }
}
