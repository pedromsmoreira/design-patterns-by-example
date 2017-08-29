namespace BuilderPattern.Product.Parts
{
    public class Wheel : Part
    {
        public Wheel(int quantity, string type)
        {
            this.Quantity = quantity;
            this.Type = type;
        }

        public int Quantity { get; set; }

        public string Type { get; set; }

        public override string PrintDetails()
        {
            return $"Number of Wheels: {this.Quantity} | Type: {this.Type}";
        }
    }
}