namespace BuilderPattern.Builder
{
    using Product.Parts;

    public class WheelsBuilder
    {
        private int quantity;

        private string type;

        public WheelsBuilder()
        {
            this.type = string.Empty;
            this.quantity = 0;
        }

        public WheelsBuilder WithType(string type)
        {
            this.type = type;
            return this;
        }

        public WheelsBuilder WithQuantity(int quantity)
        {
            this.quantity = quantity;
            return this;
        }

        public Wheel Build()
        {
            return new Wheel(this.quantity, this.type);
        }
    }
}