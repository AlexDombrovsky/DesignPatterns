using System;
using System.Collections;

namespace Iterator.Pancake
{
    public class PancakeHouseMenu
    {
        private readonly ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrumbled eggs, and toasts", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }

        public Abstract.Iterator CreateIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }
    }
}
