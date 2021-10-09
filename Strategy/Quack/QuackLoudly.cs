using Strategy.Behaviors;
using System;

namespace Strategy.Quack
{
    public class QuackLoudly : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}