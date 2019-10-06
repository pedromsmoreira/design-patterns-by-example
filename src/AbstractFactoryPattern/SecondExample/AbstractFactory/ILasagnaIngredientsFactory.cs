namespace AbstractFactoryPattern.SecondExample.AbstractFactory
{
    using AbstractProduct;

    public interface ILasagnaIngredientsFactory
    {
        IPasta CreatePasta();

        ISauce CreateSauce();

        ICheese CreateCheese();
    }
}