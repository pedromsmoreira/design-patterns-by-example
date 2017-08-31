namespace BuilderPattern.Product.Parts
{
    public class Seat : Part
    {
        public Seat(int total, SeatsBrand brand)
        {
            this.TotalSeats = total;
            this.Brand = brand;
        }

        public int TotalSeats { get; set; }

        public SeatsBrand Brand { get; set; }

        public override string PrintDetails()
        {
            return $"Number of Seats: {this.TotalSeats} | Line: {this.Brand}";
        }
    }
}