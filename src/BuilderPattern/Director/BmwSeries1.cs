namespace BuilderPattern.Director
{
    using Builder;
    using ConcreteBuilder;
    using Product;
    using Product.Parts;

    public class BmwSeries1
    {
        public BmwSeries1()
        {
            this.Car = new VehicleBuilder()
                .WithBrand(Brand.Bmw)
                .WithEngine(
                    new EngineBuilder()
                        .WithType(EngineType.TwinTurbo)
                        .Build())
                .WithWheels(
                    new WheelsBuilder()
                        .WithQuantity(4)
                        .WithType("chrome")
                        .Build())
                .WithSeats(
                    new SeatsBuilder()
                        .WithSeatsBrand(SeatsBrand.Regular)
                        .WithTotalOf(5)
                        .Build())
                .Build();
        }

        public Vehicle Car { get; set; }
    }
}