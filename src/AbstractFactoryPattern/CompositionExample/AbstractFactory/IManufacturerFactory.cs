namespace AbstractFactoryPattern.CompositionExample.AbstractFactory
{
    using Factory;

    public interface IManufacturerFactory
    {
        IFactory CreateFactory(Manufacturer manufacturer);
    }
}