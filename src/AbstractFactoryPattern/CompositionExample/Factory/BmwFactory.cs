namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using AbstractFactory;
    using ConcreteProduct;

    public class BmwFactory : IFactory
    {
        public BmwFactory()
        {
        }

        public ICar Create(string model)
        {
            return new Bmw().CreateCar(model);
        }

        public bool IsNull()
        {
            return false;
        }
    }
}