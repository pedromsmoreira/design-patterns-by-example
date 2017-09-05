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

        public ICar CreateClass1(string model)
        {
            return null;
        }

        public ICar CreateClass2(string model)
        {
            return null;
        }

        public ICar CreateClass3(string model)
        {
            return null;
        }

        public ICar CreateClass4(string model)
        {
            return null;
        }

        public bool IsNull()
        {
            return true;
        }
    }
}