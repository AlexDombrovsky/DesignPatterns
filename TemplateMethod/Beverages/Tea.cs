﻿using System;
using TemplateMethod.Beverages.Abstract;

namespace TemplateMethod.Beverages
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}