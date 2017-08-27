namespace FactoryMethodPattern.ConcreteProduct
{
    using System;
    using Product;

    public class Seat : Part
    {
        public Seat(int total)
        {
            this.TotalSeats = total;
        }

        public int TotalSeats { get; set; }

        public override string PrintDetails()
        {
            return $"Number of Seats: {this.TotalSeats}";
        }
    }
}