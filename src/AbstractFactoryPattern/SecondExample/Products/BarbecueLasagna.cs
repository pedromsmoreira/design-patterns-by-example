namespace AbstractFactoryPattern.SecondExample.Products
{
    using System;
    using AbstractFactory;
    using AbstractProduct;
    using Factory;

    public class BarbecueLasagna : Lasagna
    {
        private readonly ILasagnaIngredientsFactory ingredientsFactory;

        public BarbecueLasagna()
        {
            this.ingredientsFactory = new GlobalLasagnaIngredientFactory();
        }

        public override string Name => nameof(BarbecueLasagna);

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this.Name}!");
            this.Pasta = this.ingredientsFactory.CreatePasta();
            this.Cheese = this.ingredientsFactory.CreateCheese();
            this.Sauce = this.ingredientsFactory.CreateSauce();
        }
    }
}