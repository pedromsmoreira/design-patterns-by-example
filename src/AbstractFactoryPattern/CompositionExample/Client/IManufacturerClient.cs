namespace AbstractFactoryPattern.CompositionExample.Client
{
    using AbstractFactory;

    public interface IManufacturerClient
    {
        IFactory CreateFactory(Manufacturer manufacturer);
    }
}