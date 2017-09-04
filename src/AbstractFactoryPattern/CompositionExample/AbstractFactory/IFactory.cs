namespace AbstractFactoryPattern.CompositionExample.AbstractFactory
{
    using ConcreteProduct;
    using Factory;
    using Product;

    public interface IFactory
    {
        ICar Create(CarModel model);

        bool IsNull();
    }
}