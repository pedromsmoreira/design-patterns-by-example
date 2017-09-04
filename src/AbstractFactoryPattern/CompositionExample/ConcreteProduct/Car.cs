namespace AbstractFactoryPattern.CompositionExample.ConcreteProduct
{
    using System;
    using Product;

    public abstract class Car : ICar
    {
        protected Car()
        {
        }

        public string Model { get; protected set; }

        public IWheel FrontLeft { get; protected set; }

        public IWheel FrontRight { get; protected set; }

        public IWheel RearLeft { get; protected set; }

        public IWheel RearRight { get; protected set; }

        public ISteering Steering { get; protected set; }

        public IDriving Driving { get; protected set; }

        public IManufacturer Manufacturer { get; protected set; }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Model: {this.Model} | Manufacturer: {this.Manufacturer.Name} | Speed: {this.RearRight.RotationSpeed}");
        }
    }
}