namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using System;
    using System.Collections.Generic;
    using AbstractFactory;
    using ConcreteProduct;
    using Product;

    public class BmwFactory : IFactory
    {
        private readonly IDictionary<Type, ICarFactoryMethod> availableModels;

        public BmwFactory()
        {
            this.availableModels = new Dictionary<Type, ICarFactoryMethod>
            {
                { typeof(BmwSeries1), new BmwSeries1() }
            };
        }

        public ICar Create(Type model)
        {
            return this.availableModels[model].CreateCar();
        }

        public bool IsNull()
        {
            return false;
        }
    }
}