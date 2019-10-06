namespace AbstractFactoryPattern.SecondExample.AbstractProduct
{
    using System;

    public abstract class Lasagna
    {
        public abstract string Name { get; }

        public IPasta Pasta { get; protected set; }

        public ICheese Cheese { get; protected set; }

        public ISauce Sauce { get; protected set; }

        public abstract void Prepare();

        public void Details()
        {
            Console.WriteLine($"{this.Name} Lasagna Details.");
            Console.WriteLine($"{this.Pasta.NumberOfLayers} Layers of {this.Pasta.GetType().Name}");
            Console.WriteLine($"{this.Cheese.Type} Cheese");
            Console.WriteLine($"{this.Sauce.Quantity} grams of {this.Sauce.Type}");
        }

        public void Bake()
        {
            Console.WriteLine("Baking at 250ºC...");
        }

        public void Serve()
        {
            Console.WriteLine($"Lasagna is served!");
        }
    }
}