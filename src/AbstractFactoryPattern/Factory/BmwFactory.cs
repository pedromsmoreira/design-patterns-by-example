namespace AbstractFactoryPattern.Factory
{
    using AbstractFactory;
    using AbstractProduct;
    using Products;
    using Bike = AbstractProduct.Bike;

    public class BmwFactory : VehicleFactory
    {
        public override Car CreateCar()
        {
            return new Bmw();
        }

        public override Bike CreateBike()
        {
            return new BmwBike();
        }
    }
}