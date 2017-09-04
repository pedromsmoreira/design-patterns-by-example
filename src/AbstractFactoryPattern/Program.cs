namespace AbstractFactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using AbstractFactory;
    using CompositionExample.AbstractFactory;
    using CompositionExample.ConcreteProduct;
    using CompositionExample.Product;
    using Factory;

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory using only Composition");

            IManufacturerFactory manufacturerFactory = new ManufacturerFactory();

            var bmwFactory = manufacturerFactory.CreateFactory(Manufacturer.Bmw);
            var merdecesFactory = manufacturerFactory.CreateFactory(Manufacturer.Mercedes);

            var bmwSeries1 = bmwFactory.Create(typeof(BmwSeries1));
            var mercedesClassA = merdecesFactory.Create(typeof(MercedesClassA));

            bmwSeries1.Driving.Accelerate(10);

            mercedesClassA.Driving.Accelerate(25);

            bmwSeries1.Driving.Accelerate(20);

            bmwSeries1.PrintDetails();
            mercedesClassA.PrintDetails();

            Console.ReadLine();

            char input;
            do
            {
                Console.WriteLine("Choose a brand. (B)MW or (M)ercedes or (K)TM? Press E to (E)xit.");

                input = Console.ReadKey().KeyChar;

                VehicleFactory factory;

                switch (char.ToUpper(input))
                {
                    case 'B':
                        factory = new BmwFactory();
                        break;

                    case 'M':
                        factory = new MercedesFactory();
                        break;

                    case 'K':
                        factory = new KtmFactory();
                        break;

                    case 'E':
                        Environment.Exit(0);
                        return;

                    default:
                        throw new NotImplementedException();
                }

                var car = factory.CreateCar();
                var bike = factory.CreateBike();

                if (!car.IsNullable())
                {
                    Console.WriteLine($"\nCar: {car.GetType().Name}.");
                }

                if (!bike.IsNullable())
                {
                    Console.WriteLine($"\nBike: {bike.GetType().Name}.");
                }

                Console.ReadLine();
            }
            while (!input.Equals(char.ToUpper('e')));
        }
    }
}