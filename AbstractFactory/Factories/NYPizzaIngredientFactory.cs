using AbstractFactory.Factories.Abstract;
using AbstractFactory.Ingredients.Abstract;
using AbstractFactory.Ingredients.Common;
using AbstractFactory.Ingredients.NY;
using System.Collections.Generic;

namespace AbstractFactory.Factories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
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
            return new FreshClams();
        }
    }
}