namespace AbstractFactoryPattern.SecondExample.Client
{
    using System;
    using System.Collections.Generic;
    using AbstractProduct;
    using Products;

    public class LasagnaStore : ILasagnaStore
    {
        private readonly IDictionary<string, Lasagna> menu;

        public LasagnaStore()
        {
            this.menu = new Dictionary<string, Lasagna>
            {
                { "tomato", new TomatoLasagna() },
                { "barbecue", new BarbecueLasagna() }
            };
        }

        public void OrderLasagna(string lasagnaType)
        {
            if (!this.menu.TryGetValue(lasagnaType, out Lasagna lasagna))
            {
                Console.WriteLine("Lasagna does not exist in the menu!");
                return;
            }

            lasagna.Prepare();
            lasagna.Serve();

            lasagna.Details();
        }
    }
}