namespace AbstractFactoryPattern.SecondExample.Products
{
    using AbstractProduct;

    public class GranaPadano : ICheese
    {
        public string Type => nameof(GranaPadano);
    }
}