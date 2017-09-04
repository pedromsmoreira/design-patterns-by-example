namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using System;
    using System.Collections.Generic;
    using AbstractFactory;
    using ConcreteProduct;
    using Product;

    public class MercedesFactory : IFactory
    {
        private readonly IDictionary<CarModel, ICarFactoryMethod> availableModels;

        public MercedesFactory()
        {
            this.availableModels = new Dictionary<CarModel, ICarFactoryMethod>
            {
                { CarModel.ClassA, new MercedesClassA() }
            };
        }

        public ICar Create(CarModel model)
        {
            return this.availableModels[model].CreateCar();
        }

        public bool IsNull()
        {
            return false;
        }
    }
}