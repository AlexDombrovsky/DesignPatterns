using TemplateMethod.Beverages;

namespace TemplateMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();

            var coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}