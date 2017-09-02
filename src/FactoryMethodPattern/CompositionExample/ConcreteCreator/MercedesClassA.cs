namespace FactoryMethodPattern.CompositionExample.ConcreteCreator
{
    using ConcreteProduct;
    using Creator;
    using Product;

    public class MercedesClassA : ICarFactoryMethod
    {
        public ICar CreateCar()
        {
            var frontLeft = new Wheel();
            var frontRight = new Wheel();
            var rearLeft = new Wheel();
            var rearRight = new Wheel();

            var frontSteering = new FrontSteering(frontLeft, frontRight);
            var twoWheelDrive = new TwoWheelDrive(rearLeft, rearRight);
            var manufacturer = Mercedes.GetInstance();

            return new Car("Mercedes Class A", manufacturer, frontLeft, frontRight, rearLeft, rearRight, frontSteering, twoWheelDrive);
        }
    }
}