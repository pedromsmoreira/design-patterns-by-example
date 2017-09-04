namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using System.Collections.Generic;
    using AbstractFactory;
    using ConcreteProduct;
    using Product;

    public class BmwFactory : IFactory
    {
        private readonly IDictionary<CarModel, ICarFactoryMethod> availableModels;

        public BmwFactory()
        {
            this.availableModels = new Dictionary<CarModel, ICarFactoryMethod>
            {
                { CarModel.Series1, new BmwSeries1() }
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