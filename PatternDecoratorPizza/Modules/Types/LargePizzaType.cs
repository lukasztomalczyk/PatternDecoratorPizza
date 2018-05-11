namespace PatternDecoratorPizza.Modules.Types
{
    internal class LargePizzaType : PizzaBase
    {
        public override double CalculatePrice()
        {
            return 20;
        }

        public override string GetTypeOfPizza()
        {
            return "This is large type of pizza";
        }
    }
}