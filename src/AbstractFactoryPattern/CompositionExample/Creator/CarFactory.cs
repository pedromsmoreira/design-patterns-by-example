namespace AbstractFactoryPattern.CompositionExample.Creator
{
    using ConcreteProduct;

    public interface ICarFactoryMethod
    {
        ICar CreateCar();
    }
}