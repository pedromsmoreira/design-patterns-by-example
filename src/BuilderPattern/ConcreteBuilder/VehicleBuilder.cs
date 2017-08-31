namespace BuilderPattern.ConcreteBuilder
{
    using Builder;
    using Product;
    using Product.Parts;

    public class VehicleBuilder : IVehicleBuilder
    {
        private VehicleType type;

        private Brand brand;

        private Engine engine;

        private Wheel wheels;

        private Seat seats;

        public VehicleBuilder()
        {
            this.brand = Brand.None;
            this.type = VehicleType.None;
            this.engine = new EngineBuilder().Build();
            this.wheels = new WheelsBuilder().Build();
            this.seats = new SeatsBuilder().Build();
        }

        public IVehicleBuilder WithType(VehicleType type)
        {
            this.type = type;
            return this;
        }

        public IVehicleBuilder WithBrand(Brand brand)
        {
            this.brand = brand;
            return this;
        }

        public IVehicleBuilder WithEngine(Engine engine)
        {
            this.engine = engine;
            return this;
        }

        public IVehicleBuilder WithWheels(Wheel wheel)
        {
            this.wheels = wheel;

            return this;
        }

        public IVehicleBuilder WithSeats(Seat seat)
        {
            this.seats = seat;

            return this;
        }

        public Vehicle Build()
        {
            return new Vehicle(this.type, this.brand, this.engine, this.wheels, this.seats);
        }
    }
}