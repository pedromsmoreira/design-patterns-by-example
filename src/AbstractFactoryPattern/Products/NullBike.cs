namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    public class NullBike : Bike
    {
        public override bool IsNullable()
        {
            return true;
        }
    }
}