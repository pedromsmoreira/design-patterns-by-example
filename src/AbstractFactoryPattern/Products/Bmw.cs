namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    public class Bmw : Car
    {
        public override bool IsNullable()
        {
            return false;
        }
    }
}