namespace FactoryMethodPattern.CompositionExample.ConcreteCreator
{
    using System;
    using ConcreteProduct;
    using Product;

    public class Car : ICar
    {
        public Car(string name, IManufacturer manufacturer, IWheel frontLeft, IWheel frontRight, IWheel rearLeft, IWheel rearRight, ISteering steering, IDriving driving)
        {
            this.FrontLeft = frontLeft;
            this.RearLeft = rearLeft;
            this.FrontRight = frontRight;
            this.RearRight = rearLeft;

            this.Steering = steering;
            this.Driving = driving;
            this.Manufacturer = manufacturer;

            this.Name = name;
        }

        public string Name { get; }

        public IWheel FrontLeft { get; }

        public IWheel FrontRight { get; }

        public IWheel RearLeft { get; }

        public IWheel RearRight { get; }

        public ISteering Steering { get; }

        public IDriving Driving { get; }

        public IManufacturer Manufacturer { get; }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {this.Name} | Manufacturer: {this.Manufacturer.Name} | Speed: {this.RearRight.RotationSpeed}");
        }
    }
}