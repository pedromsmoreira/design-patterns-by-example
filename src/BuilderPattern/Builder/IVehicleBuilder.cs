namespace BuilderPattern.Builder
{
    using ConcreteBuilder;
    using Product;
    using Product.Parts;

    public interface IVehicleBuilder
    {
        VehicleBuilder WithBrand(Brand brand);

        VehicleBuilder WithType(VehicleType type);

        VehicleBuilder WithEngine(Engine engine);

        VehicleBuilder WithWheels(Wheel wheel);

        VehicleBuilder WithSeats(Seat seat);

        Vehicle Build();
    }
}