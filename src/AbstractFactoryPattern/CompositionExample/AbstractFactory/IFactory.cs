namespace AbstractFactoryPattern.CompositionExample.AbstractFactory
{
    using System;
    using ConcreteProduct;

    public interface IFactory
    {
        ICar Create(Type model);

        bool IsNull();
    }
}