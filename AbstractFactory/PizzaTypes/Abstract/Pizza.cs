using AbstractFactory.Ingredients.Abstract;
using System;
using System.Collections.Generic;

namespace AbstractFactory.PizzaTypes.Abstract
{
    public abstract class Pizza
    {
        public Cheese Cheese;
        public Clams Clams;
        public Dough Dough;
        public Pepperoni Pepperoni;
        public Sauce Sauce;
        public List<Veggies> Veggies;
        public string Name { get; set; }

        public abstract void Prepare();
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}