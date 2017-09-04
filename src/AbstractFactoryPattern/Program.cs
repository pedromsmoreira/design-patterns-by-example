namespace AbstractFactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using AbstractFactory;
    using CompositionExample.AbstractFactory;
    using CompositionExample.ConcreteProduct;
    using CompositionExample.Factory;
    using CompositionExample.Product;
    using Factory;
    using BmwFactory = Factory.BmwFactory;
    using MercedesFactory = Factory.MercedesFactory;

    public class Program
    {
        private static void Main(string[] args)
        {
            char input;
            do
            {
                Console.WriteLine("Choose a brand. (B)MW or (M)ercedes or (K)TM? Press E to (E)xit.");

                input = Console.ReadKey().KeyChar;

                VehicleFactory factory;
                IManufacturerFactory compositionFactory = new ManufacturerFactory();
                IFactory carFactory;

                switch (char.ToUpper(input))
                {
                    case 'B':
                        factory = new BmwFactory();
                        carFactory = compositionFactory.CreateFactory(Manufacturer.Bmw);
                        break;

                    case 'M':
                        factory = new MercedesFactory();
                        carFactory = compositionFactory.CreateFactory(Manufacturer.Mercedes);
                        break;

                    case 'K':

                        factory = new KtmFactory();
                        carFactory = compositionFactory.CreateFactory(Manufacturer.None);
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

                if (!carFactory.IsNull())
                {
                    Console.WriteLine("Abstract Factory using only Composition");

                    var createdCar = carFactory.Create("Super Model");
                    createdCar.PrintDetails();
                }

                Console.ReadLine();
            }
            while (!input.Equals(char.ToUpper('e')));
        }
    }
}