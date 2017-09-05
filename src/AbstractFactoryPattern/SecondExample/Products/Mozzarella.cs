namespace AbstractFactoryPattern.SecondExample.Products
{
    using AbstractProduct;

    public class Mozzarella : ICheese
    {
        public string Type => nameof(Mozzarella);
    }
}