using Decorator.BaseClasses;

namespace Decorator.Decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
            Description = _beverage.Description + ", Whip";
        }

        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }
    }
}
