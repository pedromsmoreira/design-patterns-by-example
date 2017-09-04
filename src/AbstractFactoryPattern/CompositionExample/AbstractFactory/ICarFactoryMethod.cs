namespace AbstractFactoryPattern.CompositionExample.AbstractFactory
{
    using ConcreteProduct;

    public interface ICarFactoryMethod
    {
        ICar CreateCar();
    }
}