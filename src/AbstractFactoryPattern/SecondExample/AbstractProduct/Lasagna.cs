namespace AbstractFactoryPattern.SecondExample.AbstractProduct
{
    using System;

    public abstract class Lasagna
    {
        public abstract void Prepare();

        public IPasta Pasta { get; set; }

        public ICheese Cheese { get; set; }

        public ISauce Sauce { get; set; }

        public void Serve()
        {
            Console.WriteLine($"Lasagna is served!");
        }
    }
}