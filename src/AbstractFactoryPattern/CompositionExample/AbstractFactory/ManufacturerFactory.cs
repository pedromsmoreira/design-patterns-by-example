namespace AbstractFactoryPattern.CompositionExample.AbstractFactory
{
    using System;
    using System.Collections.Generic;
    using Factory;

    public class ManufacturerFactory : IManufacturerFactory
    {
        private readonly IDictionary<Manufacturer, IFactory> availableFactories;

        public ManufacturerFactory()
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