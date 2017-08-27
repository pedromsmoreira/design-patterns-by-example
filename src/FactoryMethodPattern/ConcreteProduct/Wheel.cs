namespace FactoryMethodPattern.ConcreteProduct
{
    using System;
    using Product;

    public class Wheel : Part
    {
        public Wheel(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; set; }

        public override string PrintDetails()
        {
            return $"Number of Wheels: {this.Quantity}";
        }
    }
}