namespace FactoryMethodPattern.ConcreteProduct
{
    using Product;

    public partial class Engine : Part
    {
        public Engine(EngineType type)
        {
            this.Type = type;
        }

        public EngineType Type { get; set; }

        public override string PrintDetails()
        {
            return $"Type: {this.Type}";
        }
    }
}