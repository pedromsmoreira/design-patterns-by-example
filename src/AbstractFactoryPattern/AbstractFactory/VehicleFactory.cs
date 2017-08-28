namespace AbstractFactoryPattern.AbstractFactory
{
    using AbstractProduct;

    public abstract class VehicleFactory
    {
        public abstract Car CreateCar();

        public abstract Bike CreateBike();
    }
}