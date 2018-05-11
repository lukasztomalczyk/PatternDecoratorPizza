namespace PatternDecoratorPizza.Modules.Types
{
    internal class SmallPizzaType : PizzaBase
    {
        public override double CalculatePrice()
        {
            return 12;
        }

        public override string GetTypeOfPizza()
        {
            return "This is small type of pizza.";
        }
    }
}