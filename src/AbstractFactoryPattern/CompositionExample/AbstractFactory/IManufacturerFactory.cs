namespace AbstractFactoryPattern.CompositionExample.AbstractFactory
{
    public interface IManufacturerFactory
    {
        IFactory CreateFactory(Manufacturer manufacturer);
    }
}