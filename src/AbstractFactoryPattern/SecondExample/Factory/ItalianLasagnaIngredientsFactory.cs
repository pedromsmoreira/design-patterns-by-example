namespace AbstractFactoryPattern.SecondExample.Factory
{
    using System;
    using AbstractFactory;
    using AbstractProduct;
    using Products;

    public class ItalianLasagnaIngredientsFactory : ILasagnaIngredientsFactory
    {
        public IPasta CreatePasta()
        {
            Console.WriteLine($"Laying Pasta: {nameof(ThickPasta)}");
            return new ThickPasta();
        }

        public ISauce CreateSauce()
        {
            Console.WriteLine($"Pouring Sauce: {nameof(TomatoSauce)}");
            return new TomatoSauce();
        }

        public ICheese CreateCheese()
        {
            Console.WriteLine($"Pouring Cheese: {nameof(GranaPadano)}");
            return new GranaPadano();
        }
    }
}