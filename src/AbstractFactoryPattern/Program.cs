namespace AbstractFactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using AbstractFactory;
    using CompositionExample.AbstractFactory;
    using CompositionExample.Client;
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
                IManufacturerClient compositionClient = new ManufacturerClient();
                IFactory carFactory;

                switch (char.ToUpper(input))
                {
                    case 'B':
                        factory = new BmwFactory();
                        carFactory = compositionClient.CreateFactory(Manufacturer.Bmw);
                        break;

                    case 'M':
                        factory = new MercedesFactory();
                        carFactory = compositionClient.CreateFactory(Manufacturer.Mercedes);
                        break;

                    case 'K':

                        factory = new KtmFactory();
                        carFactory = compositionClient.CreateFactory(Manufacturer.None);
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

                    var class1Car = carFactory.CreateClass1("Super Model");
                    class1Car.PrintDetails();
                    var class2Car = carFactory.CreateClass2("Super Model 2");
                    class2Car.PrintDetails();
                }
                else
                {
                    Console.WriteLine($"Factory: {carFactory.GetType()}");
                }

                Console.ReadLine();
            }
            while (!input.Equals(char.ToUpper('e')));
        }
    }
}