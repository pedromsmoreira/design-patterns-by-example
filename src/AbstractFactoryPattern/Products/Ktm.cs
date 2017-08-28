namespace AbstractFactoryPattern.Products
{
    using AbstractProduct;

    public class Ktm : Bike
    {
        public override bool IsNullable()
        {
            return false;
        }
    }
}