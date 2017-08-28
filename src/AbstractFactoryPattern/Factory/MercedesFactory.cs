namespace AbstractFactoryPattern.Factory
{
    using AbstractFactory;
    using AbstractProduct;
    using Products;

    public class MercedesFactory : VehicleFactory
    {
        public override Car CreateCar()
        {
            return new Mercedes();
        }

        public override Bike CreateBike()
        {
            return new NullMercedes();
        }
    }
}