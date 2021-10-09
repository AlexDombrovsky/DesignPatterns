using AbstractFactory.PizzaStores;
using AbstractFactory.PizzaStores.Abstract;
using System;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();

            var pizza = nyPizzaStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoPizzaStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            Console.ReadKey();
        }
    }
}