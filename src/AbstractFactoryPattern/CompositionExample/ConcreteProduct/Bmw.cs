namespace AbstractFactoryPattern.CompositionExample.ConcreteProduct
{
    using Product;

    public sealed class Bmw : Car
    {
        public Bmw(string model) : base()
        {
            this.Model = model;

            this.FrontLeft = new Wheel();
            this.FrontRight = new Wheel();
            this.RearLeft = new Wheel();
            this.RearRight = new Wheel();

            this.Steering = new FrontSteering(this.FrontLeft, this.FrontRight);
            this.Driving = new TwoWheelDrive(this.RearLeft, this.RearRight);
            this.Manufacturer = BmwManufacturer.GetInstance();
        }
    }
}