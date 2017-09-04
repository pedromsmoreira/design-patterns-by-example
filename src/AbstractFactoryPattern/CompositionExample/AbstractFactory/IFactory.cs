namespace AbstractFactoryPattern.CompositionExample.AbstractFactory
{
    using ConcreteProduct;

    public interface IFactory
    {
        ICar Create(string model);

        bool IsNull();
    }
}