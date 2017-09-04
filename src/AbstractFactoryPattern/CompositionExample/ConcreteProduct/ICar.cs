namespace AbstractFactoryPattern.CompositionExample.ConcreteProduct
{
    using Product;

    public interface ICar
    {
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