namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using System;
    using AbstractFactory;
    using ConcreteProduct;

    public class NullFactory : IFactory
    {
        public NullFactory()
        {
        }

        public ICar Create(Type model)
        {
            return null;
        }

        public bool IsNull()
        {
            return true;
        }
    }
}