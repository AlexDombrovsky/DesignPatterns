using Decorator.BaseClasses;

namespace Decorator.Decorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
            Description = _beverage.Description + ", Mocha";
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }
}
