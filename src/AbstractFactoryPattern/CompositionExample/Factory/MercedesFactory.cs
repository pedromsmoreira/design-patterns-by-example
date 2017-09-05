namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using AbstractFactory;
    using ConcreteProduct;

    public class MercedesFactory : IFactory
    {
        public MercedesFactory()
        {
        }

        public ICar CreateClass1(string model)
        {
            return new Mercedes(model, "Class 1");
        }

        public ICar CreateClass2(string model)
        {
            return new Mercedes(model, "Class 2");
        }

        public bool IsNull()
        {
            return false;
        }
    }
}