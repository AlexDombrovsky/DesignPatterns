using System;
using Iterator.Dinner;
using Iterator.Pancake;

namespace Iterator
{
    public class Waitress
    {
        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinnerMenu dinnerMenu)
        {
            PancakeHouseMenu = pancakeHouseMenu;
            DinnerMenu = dinnerMenu;
        }

        public PancakeHouseMenu PancakeHouseMenu { get; }

        public DinnerMenu DinnerMenu { get; }

        public void PrintMenu()
        {
            var pancakeIterator = PancakeHouseMenu.CreateIterator();
            var dinnerIterator = DinnerMenu.CreateIterator();
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("MENU\n----\nLUNCH");
            PrintMenu(dinnerIterator);
        }

        private void PrintMenu(Abstract.Iterator iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = (MenuItem) iterator.Next();
                Console.WriteLine(menuItem.Name);
                Console.WriteLine(menuItem.Price);
                Console.WriteLine(menuItem.Description);
            }
        }
    }
}