namespace AbstractFactoryPattern
{
    using System;
    using AbstractFactory;
    using CompositionExample.ConcreteCreator;
    using Factory;

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory using only Composition");

            var bmwSeries1 = new BmwSeries1().CreateCar();
            var mercedesClassA = new MercedesClassA().CreateCar();

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