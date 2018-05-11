namespace PatternDecoratorPizza.Modules.Types
{
    internal class MediumPizzaType : PizzaBase
    {
        public override double CalculatePrice()
        {
            return 15;
        }

        public override string GetTypeOfPizza()
        {
            return "This is medium type of pizza";
        }
    }
}