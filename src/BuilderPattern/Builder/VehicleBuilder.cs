namespace BuilderPattern.Builder
{
    using Product;
    using Product.Parts;

    public class VehicleBuilder
    {
        private Brand brand;

        private Engine engine;

        private Wheel wheels;

        private Seat seats;

        public VehicleBuilder()
        {
            this.brand = Brand.None;
            this.engine = new EngineBuilder().Build();
            this.wheels = new WheelsBuilder().Build();
            this.seats = new SeatsBuilder().Build();
        }

        public VehicleBuilder WithBrand(Brand brand)
        {
            this.brand = brand;
            return this;
        }

        public VehicleBuilder WithEngine(Engine engine)
        {
            this.engine = engine;
            return this;
        }

        public VehicleBuilder WithWheels(Wheel wheel)
        {
            this.wheels = wheel;

            return this;
        }

        public VehicleBuilder WithSeats(Seat seat)
        {
            this.seats = seat;

            return this;
        }

        public Vehicle Build()
        {
            return new Vehicle(this.brand, this.engine, this.wheels, this.seats);
        }
    }
}