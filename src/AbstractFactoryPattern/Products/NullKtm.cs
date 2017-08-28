namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    public class NullKtm : Car
    {
        public override bool IsNullable()
        {
            return true;
        }
    }
}