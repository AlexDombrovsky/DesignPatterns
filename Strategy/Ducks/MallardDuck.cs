using Strategy.Fly;
using Strategy.Quack;
using System;

namespace Strategy.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new QuackLoudly();
            _flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck");
        }
    }
}