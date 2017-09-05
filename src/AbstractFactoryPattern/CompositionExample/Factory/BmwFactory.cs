namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using AbstractFactory;
    using ConcreteProduct;

    public class BmwFactory : IFactory
    {
        public BmwFactory()
        {
        }

        public ICar CreateClass1(string model)
        {
            return new Bmw(model, "Class 1");
        }

        public ICar CreateClass2(string model)
        {
            return new Bmw(model, "Class 2");
        }

        public bool IsNull()
        {
            return false;
        }
    }
}