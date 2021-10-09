using System;

namespace Iterator.Dinner
{
    public class DinnerMenu
    {
        private const int MaxItems = 6;
        private readonly MenuItem[] _menuItems;
        private int _numberOfItems;

        public DinnerMenu()
        {
            _menuItems = new MenuItem[MaxItems];
            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 2.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems >= MaxItems)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems += 1;
            }
        }

        public Abstract.Iterator CreateIterator()
        {
            return new DinnerMenuIterator(_menuItems);
        }
    }
}