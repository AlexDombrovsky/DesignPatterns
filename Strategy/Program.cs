using Strategy.Ducks;
using Strategy.Fly;
using System;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
            Console.ReadKey();
        }
    }
}