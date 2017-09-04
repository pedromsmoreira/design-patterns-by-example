namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    internal class BmwBike : Bike
    {
        public override bool IsNullable()
        {
            return false;
        }
    }
}