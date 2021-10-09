using AbstractFactory.Factories;
using AbstractFactory.PizzaStores.Abstract;
using AbstractFactory.PizzaTypes;
using AbstractFactory.PizzaTypes.Abstract;

namespace AbstractFactory.PizzaStores
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var ingredientFactory = new ChicagoPizzaIngredientFactory();
            if (type.Equals("cheese"))
            {
                var pizza = new CheesePizza(ingredientFactory) { Name = "Chicago Style Cheese Pizza" };
                return pizza;
            }

            if (type.Equals("pepperoni"))
            {
                var pizza = new PepperoniPizza(ingredientFactory) { Name = "Chicago Pepperoni Cheese Pizza" };
                return pizza;
            }

            if (type.Equals("clam"))
            {
                var pizza = new ClamPizza(ingredientFactory) { Name = "Chicago Style Clam Pizza" };
                return pizza;
            }

            if (type.Equals("veggie"))
            {
                var pizza = new VeggiePizza(ingredientFactory) { Name = "Chicago Style Veggie Pizza" };
                return pizza;
            }

            return null;
        }
    }
}