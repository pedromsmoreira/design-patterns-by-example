namespace AbstractFactoryPattern.CompositionExample.AbstractFactory
{
    using ConcreteProduct;

    public interface IFactory
    {
        ICar CreateClass1(string model);

        ICar CreateClass2(string model);

        bool IsNull();
    }
}