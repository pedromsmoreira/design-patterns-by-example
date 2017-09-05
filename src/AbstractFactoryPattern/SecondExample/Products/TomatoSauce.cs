namespace AbstractFactoryPattern.SecondExample.Products
{
    using AbstractProduct;

    public class TomatoSauce : ISauce
    {
        public string Type => nameof(TomatoSauce);

        public int Quantity => 250;
    }
}