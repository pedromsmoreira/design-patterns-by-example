namespace AbstractFactoryPattern.SecondExample.Products
{
    using System;
    using AbstractFactory;
    using AbstractProduct;
    using Factory;

    public class TomatoLasagna : Lasagna
    {
        private readonly ILasagnaIngredientsFactory ingredientsFactory;

        public TomatoLasagna()
        {
            this.ingredientsFactory = new ItalianLasagnaIngredientsFactory();
        }

        public override string Name => nameof(TomatoLasagna);

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this.Name}!");
            this.Pasta = this.ingredientsFactory.CreatePasta();
            this.Cheese = this.ingredientsFactory.CreateCheese();
            this.Sauce = this.ingredientsFactory.CreateSauce();
        }
    }
}