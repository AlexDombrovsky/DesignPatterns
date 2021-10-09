using AbstractFactory.Ingredients.Abstract;
using System.Collections.Generic;

namespace AbstractFactory.Factories.Abstract
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Veggies> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}