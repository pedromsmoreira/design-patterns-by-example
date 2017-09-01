namespace FactoryMethodPattern.CompositionExample.ConcreteProduct
{
    using Product;

    public class Mercedes : IManufacturer
    {
        private static IManufacturer instance;

        private Mercedes()
        {
        }

        public string Name => nameof(Mercedes);

        public static IManufacturer GetInstance()
        {
            return instance ?? (instance = new Mercedes());
        }
    }
}