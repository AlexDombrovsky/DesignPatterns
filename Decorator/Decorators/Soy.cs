using Decorator.BaseClasses;

namespace Decorator.Decorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
            Description = _beverage.Description + ", Soy";
        }

        public override double Cost()
        {
            return .15 + _beverage.Cost();
        }
    }
}
