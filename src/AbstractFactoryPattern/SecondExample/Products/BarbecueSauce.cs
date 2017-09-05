namespace AbstractFactoryPattern.SecondExample.Products
{
    using AbstractProduct;

    public class BarbecueSauce : ISauce
    {
        public BarbecueSauce()
        {
        }

        public string Type => nameof(BarbecueSauce);

        public int Quantity => 200;
    }
}