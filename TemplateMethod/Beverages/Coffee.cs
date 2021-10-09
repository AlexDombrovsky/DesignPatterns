using System;
using TemplateMethod.Beverages.Abstract;

namespace TemplateMethod.Beverages
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();
            return answer.ToLower().StartsWith("y");
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
            var answer = Console.ReadLine();
            return answer ?? "no";
        }
    }
}