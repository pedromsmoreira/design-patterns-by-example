namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    public class NullBike : AbstractProduct.Bike
    {
        public override bool IsNullable()
        {
            return true;
        }
    }
}