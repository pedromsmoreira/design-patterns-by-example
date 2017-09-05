namespace AbstractFactoryPattern.SecondExample.Products
{
    using AbstractProduct;

    public class ThinPasta : IPasta
    {
        public int NumberOfLayers => 4;
    }
}