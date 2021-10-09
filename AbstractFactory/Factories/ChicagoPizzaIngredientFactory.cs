using AbstractFactory.Factories.Abstract;
using AbstractFactory.Ingredients.Abstract;
using AbstractFactory.Ingredients.Chicago;
using AbstractFactory.Ingredients.Common;
using System.Collections.Generic;

namespace AbstractFactory.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese CreateCheese()
        {
            return new Mozzarella();
        }

        public List<Veggies> CreateVeggies()
        {
            var veggies = new List<Veggies> { new Garlic(), new Onion() };
            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicesPepperoni();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }
    }
}