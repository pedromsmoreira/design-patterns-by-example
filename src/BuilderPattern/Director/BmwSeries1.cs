namespace BuilderPattern.Director
{
    using ConcreteBuilder;
    using Product;
    using Product.Parts;

    public class BmwSeries1
    {
        public BmwSeries1()
        {
            // you can use the other builders instead of the concrete object
            this.Vehicle = new VehicleBuilder()
                .WithType(VehicleType.Car)
                .WithBrand(Brand.Bmw)
                .WithEngine(new Engine(EngineType.TwinTurbo))
                .WithWheels(new Wheel(4, "chrome"))
                .WithSeats(new Seat(5, SeatsBrand.Regular))
                .Build();
        }

        public Vehicle Vehicle { get; }
    }
}