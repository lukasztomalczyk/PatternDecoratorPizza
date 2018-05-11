namespace PatternDecoratorPizza.Modules.Decorator
{
    internal class PizzaDecorator : PizzaBase
    {
        private readonly PizzaBase _pizzaBaseImplementation;

        public PizzaDecorator(PizzaBase pizzaBaseImplementation)
        {
            this._pizzaBaseImplementation = pizzaBaseImplementation;
        }
        public override double CalculatePrice()
        {
            return _pizzaBaseImplementation.CalculatePrice();
        }

        public override string GetTypeOfPizza()
        {
            return _pizzaBaseImplementation.GetTypeOfPizza();
        }
    }
}