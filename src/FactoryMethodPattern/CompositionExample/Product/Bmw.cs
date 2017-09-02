namespace FactoryMethodPattern.CompositionExample.Product
{
    public class Bmw : IManufacturer
    {
        private static IManufacturer instance;

        private Bmw()
        {
        }

        public string Name => nameof(Bmw);

        public static IManufacturer GetInstance()
        {
            return instance ?? (instance = new Bmw());
        }
    }
}