using Iterator.Dinner;
using Iterator.Pancake;

namespace Iterator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinnerMenu = new DinnerMenu();
            var waitress = new Waitress(pancakeHouseMenu, dinnerMenu);
            waitress.PrintMenu();
        }
    }
}