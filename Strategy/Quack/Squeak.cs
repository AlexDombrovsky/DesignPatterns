using Strategy.Behaviors;
using System;

namespace Strategy.Quack
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}