namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using System;
    using System.Collections.Generic;
    using AbstractFactory;
    using ConcreteProduct;

    public class MercedesFactory : IFactory
    {
        private readonly IDictionary<Type, ICarFactoryMethod> availableModels;

        public MercedesFactory()
        {
            this.availableModels = new Dictionary<Type, ICarFactoryMethod>
            {
                { typeof(MercedesClassA), new MercedesClassA() }
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