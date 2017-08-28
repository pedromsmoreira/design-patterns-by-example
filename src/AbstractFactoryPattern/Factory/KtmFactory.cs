namespace AbstractFactoryPattern.Factory
{
    using AbstractFactory;
    using AbstractProduct;
    using Products;

    public class KtmFactory : VehicleFactory
    {
        public override Car CreateCar()
        {
            return new NullCar();
        }

        public override Bike CreateBike()
        {
            return new Ktm();
        }
    }
}