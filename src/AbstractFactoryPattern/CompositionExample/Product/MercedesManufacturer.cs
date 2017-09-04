namespace AbstractFactoryPattern.CompositionExample.Product
{
    public class MercedesManufacturer : IManufacturer
    {
        private static IManufacturer instance;

        private MercedesManufacturer()
        {
        }

        public string Name => nameof(MercedesManufacturer);

        public static IManufacturer GetInstance()
        {
            return instance ?? (instance = new MercedesManufacturer());
        }
    }
}