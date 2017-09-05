namespace AbstractFactoryPattern.CompositionExample.ConcreteProduct
{
    using System;
    using Product;

    public class Mercedes : ICar
    {
        public Mercedes(string model, string category)
        {
            this.Model = model;
            this.Category = category;

            this.FrontLeft = new Wheel();
            this.FrontRight = new Wheel();
            this.RearLeft = new Wheel();
            this.RearRight = new Wheel();

            this.Steering = new FrontSteering(this.FrontLeft, this.FrontRight);
            this.Driving = new TwoWheelDrive(this.RearLeft, this.RearRight);
            this.Manufacturer = MercedesManufacturer.GetInstance();
        }

        public string Model { get; }

        public string Category { get; }

        public IWheel FrontLeft { get; }

        public IWheel FrontRight { get; }

        public IWheel RearLeft { get; }

        public IWheel RearRight { get; }

        public ISteering Steering { get; }

        public IDriving Driving { get; }

        public IManufacturer Manufacturer { get; }

        public void PrintDetails()
        {
            Console.WriteLine($"Model: {this.Model} | Manufacturer: {this.Manufacturer.Name} | Speed: {this.RearRight.RotationSpeed} | Category: {this.Category}");
        }
    }
}