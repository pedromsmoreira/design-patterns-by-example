namespace AbstractFactoryPattern.CompositionExample.Client
{
    using System.Collections.Generic;
    using AbstractFactory;
    using Factory;

    public class ManufacturerClient : IManufacturerClient
    {
        private readonly IDictionary<Manufacturer, IFactory> availableFactories;

        public ManufacturerClient()
        {
            this.availableFactories = new Dictionary<Manufacturer, IFactory>
            {
                { Manufacturer.Bmw, new BmwFactory() },
                { Manufacturer.Mercedes, new MercedesFactory() }
            };
        }

        public IFactory CreateFactory(Manufacturer manufacturer)
        {
            if (this.availableFactories.TryGetValue(manufacturer, out IFactory factory))
            {
                return factory;
            }

            return new NullFactory();
        }
    }
}