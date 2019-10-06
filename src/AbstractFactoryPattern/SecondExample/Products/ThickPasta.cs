namespace AbstractFactoryPattern.SecondExample.Products
{
    using AbstractProduct;

    public class ThickPasta : IPasta
    {
        public int NumberOfLayers => 3;
    }
}