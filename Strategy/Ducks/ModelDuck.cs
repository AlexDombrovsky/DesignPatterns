using Strategy.Fly;
using Strategy.Quack;
using System;

namespace Strategy.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new QuackLoudly();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}