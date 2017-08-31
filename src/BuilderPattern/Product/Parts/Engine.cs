namespace BuilderPattern.Product.Parts
{
    public class Engine : Part
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