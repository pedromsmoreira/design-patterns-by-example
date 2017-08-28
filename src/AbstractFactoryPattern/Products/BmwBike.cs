namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    internal class BmwBike : AbstractProduct.Bike
    {
        public override bool IsNullable()
        {
            return false;
        }
    }
}