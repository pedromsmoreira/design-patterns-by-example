namespace AbstractFactoryPattern.CompositionExample.ConcreteProduct
{
    using AbstractFactoryPattern.CompositionExample.AbstractFactory;
    using Product;

    public class BmwSeries1 : ICarFactoryMethod
    {
        public ICar CreateCar()
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
    }
}