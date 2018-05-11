namespace PatternDecoratorPizza.Modules.Types
{
    public class LargePizzaType : PizzaBase
    {
        public override double CalculatePrice()
        {
            return 20;
        }

        public override string GetTypeOfPizza()
        {
            return "Large";
        }
    }
}