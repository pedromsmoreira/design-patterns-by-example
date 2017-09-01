namespace FactoryMethodPattern.CompositionExample.Creator
{
    using ConcreteCreator;
    using ConcreteProduct;

    public static class CarFactory
    {
        public static ICar BmwSeries1()
        {
            var frontLeft = new Wheel();
            var frontRight = new Wheel();
            var rearLeft = new Wheel();
            var rearRight = new Wheel();

            var frontSteering = new FrontSteering(frontLeft, frontRight);
            var twoWheelDrive = new TwoWheelDrive(rearLeft, rearRight);
            var manufacturer = Bmw.GetInstance();

            return new Car("Bmw Series 1", manufacturer, frontLeft, frontRight, rearLeft, rearRight, frontSteering, twoWheelDrive);
        }

        public static ICar MercedesClassA()
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