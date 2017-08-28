namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    public class Mercedes : Car
    {
        public override bool IsNullable()
        {
            return false;
        }
    }
}