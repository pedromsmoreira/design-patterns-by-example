namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using AbstractFactory;
    using ConcreteProduct;
    using Product;

    public class NullFactory : IFactory
    {
        public NullFactory()
        {
        }

        public ICar Create(CarModel model)
        {
            return null;
        }

        public bool IsNull()
        {
            return true;
        }
    }
}