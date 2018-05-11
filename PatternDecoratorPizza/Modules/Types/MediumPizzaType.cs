namespace PatternDecoratorPizza.Modules.Types
{
    public class MediumPizzaType : PizzaBase
    {
        public override double CalculatePrice()
        {
            return 15;
        }

        public override string GetTypeOfPizza()
        {
            return "Medium";
        }
    }
}