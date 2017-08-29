namespace BuilderPattern.Product
{
    using System;
    using Parts;

    public class Vehicle
    {
        public Vehicle(Brand brand, Engine engine, Wheel wheel, Seat seat)
        {
            this.Brand = brand;
            this.Engine = engine;
            this.Seats = seat;
            this.Wheels = wheel;
        }

        public Brand Brand { get; set; }

        public Engine Engine { get; set; }

        public Wheel Wheels { get; set; }

        public Seat Seats { get; set; }

        public void ShowDescription()
        {
            Console.WriteLine("-------- Vehicle Description ----------");
            Console.WriteLine($"Brand: {this.Brand}");
            Console.WriteLine($"Engine: {this.Engine.PrintDetails()}");
            Console.WriteLine($"Wheels: {this.Wheels.PrintDetails()}");
            Console.WriteLine($"Seats: {this.Seats.PrintDetails()}");
            Console.WriteLine();
        }
    }
}