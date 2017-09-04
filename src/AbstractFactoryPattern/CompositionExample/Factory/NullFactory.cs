namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using AbstractFactory;
    using ConcreteProduct;

    public class NullFactory : IFactory
    {
        public NullFactory()
        {
        }

        public ICar Create(string model)
        {
            return null;
        }

        public bool IsNull()
        {
            return true;
        }
    }
}