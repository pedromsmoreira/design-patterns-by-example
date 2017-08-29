namespace BuilderPattern.Builder
{
    using Product.Parts;

    public class SeatsBuilder
    {
        private int total;

        private SeatsBrand brand;

        public SeatsBuilder()
        {
            this.total = 0;
            this.brand = SeatsBrand.None;
        }

        public SeatsBuilder WithTotalOf(int total)
        {
            this.total = total;
            return this;
        }

        public SeatsBuilder WithSeatsBrand(SeatsBrand brand)
        {
            this.brand = brand;
            return this;
        }

        public Seat Build()
        {
            return new Seat(this.total, this.brand);
        }
    }
}