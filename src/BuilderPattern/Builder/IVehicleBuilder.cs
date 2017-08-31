namespace BuilderPattern.Builder
{
    using ConcreteBuilder;
    using Product;
    using Product.Parts;

    public interface IVehicleBuilder
    {
        IVehicleBuilder WithBrand(Brand brand);

        IVehicleBuilder WithType(VehicleType type);

        IVehicleBuilder WithEngine(Engine engine);

        IVehicleBuilder WithWheels(Wheel wheel);

        IVehicleBuilder WithSeats(Seat seat);

        Vehicle Build();
    }
}