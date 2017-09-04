namespace AbstractFactoryPattern.CompositionExample.AbstractFactory
{
    using ConcreteProduct;

    public interface ICarFactory
    {
        ICar CreateCar(string model);
    }
}