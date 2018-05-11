using System;
using PatternDecoratorPizza.Components;
using PatternDecoratorPizza.Modules;
using PatternDecoratorPizza.Modules.Types;

namespace PatternDecoratorPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBase MyOrderLargePizzaWithCheese = new LargePizzaType();
            
            Console.WriteLine(
                "Costs of pizza: {0}", MyOrderLargePizzaWithCheese.CalculatePrice());
            Console.WriteLine(
                "Type of pizza: {0}", 
                MyOrderLargePizzaWithCheese.GetTypeOfPizza());
            
            MyOrderLargePizzaWithCheese = new CheeseDecorator(MyOrderLargePizzaWithCheese);
            
            Console.WriteLine(
                "Costs of pizza: {0}", MyOrderLargePizzaWithCheese.CalculatePrice());
            Console.WriteLine(
                "Type of pizza: {0}", 
                MyOrderLargePizzaWithCheese.GetTypeOfPizza());

            Console.ReadKey();
        }
    }
}