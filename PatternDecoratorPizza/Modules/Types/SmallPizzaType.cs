namespace PatternDecoratorPizza.Modules.Types
{
    public class SmallPizzaType : PizzaBase
    {
        public override double CalculatePrice()
        {
            return 12;
        }

        public override string GetTypeOfPizza()
        {
            return "Small";
        }
    }
}