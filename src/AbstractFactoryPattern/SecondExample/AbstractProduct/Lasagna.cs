namespace AbstractFactoryPattern.SecondExample.AbstractProduct
{
    using System;

    public abstract class Lasagna
    {
        public IPasta Pasta { get; set; }

        public ICheese Cheese { get; set; }

        public ISauce Sauce { get; set; }

        public abstract void Prepare();

        public void Serve()
        {
            Console.WriteLine($"Lasagna is served!");
        }
    }
}