namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    public class NullMercedes : Bike
    {
        public override bool IsNullable()
        {
            return true;
        }
    }
}