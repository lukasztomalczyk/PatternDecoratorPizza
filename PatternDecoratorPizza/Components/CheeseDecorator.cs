using PatternDecoratorPizza.Modules;
using PatternDecoratorPizza.Modules.Decorator;

namespace PatternDecoratorPizza.Components
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(PizzaBase pizzaBaseImplementation) : base(pizzaBaseImplementation)
        {
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 0.5;
        }

        public override string GetTypeOfPizza()
        {
            return base.GetTypeOfPizza() + " + cheese";
        }
    }
}