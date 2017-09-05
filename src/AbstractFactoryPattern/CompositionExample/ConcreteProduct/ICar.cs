namespace AbstractFactoryPattern.CompositionExample.ConcreteProduct
{
    using Product;

    public interface ICar
    {
        string Category { get; }
        IWheel FrontLeft { get; }

        IWheel FrontRight { get; }

        IWheel RearLeft { get; }

        IWheel RearRight { get; }

        ISteering Steering { get; }

        IDriving Driving { get; }

        IManufacturer Manufacturer { get; }

        void PrintDetails();
    }
}