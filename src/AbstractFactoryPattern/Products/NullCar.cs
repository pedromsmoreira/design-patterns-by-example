namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    public class NullCar : Car
    {
        public override bool IsNullable()
        {
            return true;
        }
    }
}