using AbstractFactory.Factories.Abstract;
using AbstractFactory.PizzaTypes.Abstract;
using System;

namespace AbstractFactory.PizzaTypes
{
    public class VeggiePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Veggies = _pizzaIngredientFactory.CreateVeggies();
        }
    }
}