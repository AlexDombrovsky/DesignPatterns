using AbstractFactory.Factories;
using AbstractFactory.PizzaStores.Abstract;
using AbstractFactory.PizzaTypes;
using AbstractFactory.PizzaTypes.Abstract;

namespace AbstractFactory.PizzaStores
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var ingredientFactory = new NYPizzaIngredientFactory();
            if (type.Equals("cheese"))
            {
                var pizza = new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" };
                return pizza;
            }

            if (type.Equals("pepperoni"))
            {
                var pizza = new PepperoniPizza(ingredientFactory) { Name = "New York Pepperoni Cheese Pizza" };
                return pizza;
            }

            if (type.Equals("clam"))
            {
                var pizza = new ClamPizza(ingredientFactory) { Name = "New York Style Clam Pizza" };
                return pizza;
            }

            if (type.Equals("veggie"))
            {
                var pizza = new VeggiePizza(ingredientFactory) { Name = "New York Style Veggie Pizza" };
                return pizza;
            }

            return null;
        }
    }
}