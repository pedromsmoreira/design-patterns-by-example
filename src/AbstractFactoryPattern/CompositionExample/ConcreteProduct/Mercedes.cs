namespace AbstractFactoryPattern.CompositionExample.ConcreteProduct
{
    using AbstractFactoryPattern.CompositionExample.AbstractFactory;
    using Product;

    public class Mercedes : ICarFactory
    {
        public ICar CreateCar(string model)
        {
            var frontLeft = new Wheel();
            var frontRight = new Wheel();
            var rearLeft = new Wheel();
            var rearRight = new Wheel();

            var frontSteering = new FrontSteering(frontLeft, frontRight);
            var twoWheelDrive = new TwoWheelDrive(rearLeft, rearRight);
            var manufacturer = MercedesManufacturer.GetInstance();

            return new Car(model, manufacturer, frontLeft, frontRight, rearLeft, rearRight, frontSteering, twoWheelDrive);
        }
    }
}