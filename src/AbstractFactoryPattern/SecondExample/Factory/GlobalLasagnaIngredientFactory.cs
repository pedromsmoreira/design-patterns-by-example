namespace AbstractFactoryPattern.SecondExample.Factory
{
    using System;
    using AbstractFactory;
    using AbstractProduct;
    using Products;

    public class GlobalLasagnaIngredientFactory : ILasagnaIngredientsFactory
    {
        public IPasta CreatePasta()
        {
            Console.WriteLine($"Laying Pasta: {nameof(ThinPasta)}");
            return new ThinPasta();
        }

        public ISauce CreateSauce()
        {
            Console.WriteLine($"Pouring Sauce: {nameof(BarbecueSauce)}");
            return new BarbecueSauce();
        }

        public ICheese CreateCheese()
        {
            Console.WriteLine($"Pouring Cheese: {nameof(Mozzarella)}");
            return new Mozzarella();
        }
    }
}