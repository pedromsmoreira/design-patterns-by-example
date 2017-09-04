namespace AbstractFactoryPattern.CompositionExample.Product
{
    public class BmwManufacturer : IManufacturer
    {
        private static IManufacturer instance;

        private BmwManufacturer()
        {
        }

        public string Name => nameof(BmwManufacturer);

        public static IManufacturer GetInstance()
        {
            return instance ?? (instance = new BmwManufacturer());
        }
    }
}