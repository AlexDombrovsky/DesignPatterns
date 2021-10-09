namespace Decorator.BaseClasses
{
    public abstract class Beverage
    {
        public string Description { get; set; } = "Unknown beverage";

        public abstract double Cost();
    }
}
