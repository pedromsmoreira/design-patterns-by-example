namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using ConcreteProduct;

    public interface ICreateClass4Car
    {
        ICar CreateClass4(string model);
    }
}