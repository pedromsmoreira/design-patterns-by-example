namespace BuilderPattern.Product
{
    using System;
    using Parts;

    public class Vehicle
    {
        public Vehicle(VehicleType type, Brand brand, Engine engine, Wheel wheel, Seat seat)
        {
            this.VehicleType = type;
            this.Brand = brand;
            this.Engine = engine;
            this.Seats = seat;
            this.Wheels = wheel;
        }

        public VehicleType VehicleType { get; }

        public Brand Brand { get; }

        public Engine Engine { get; }

        public Wheel Wheels { get; }

        public Seat Seats { get; }

        public void ShowDescription()
        {
            Console.WriteLine("-------- Vehicle Description ----------");
            Console.WriteLine($"Type: {this.VehicleType}");
            Console.WriteLine($"Brand: {this.Brand}");
            Console.WriteLine($"Engine: {this.Engine.PrintDetails()}");
            Console.WriteLine($"Wheels: {this.Wheels.PrintDetails()}");
            Console.WriteLine($"Seats: {this.Seats.PrintDetails()}");
            Console.WriteLine();
        }
    }
}