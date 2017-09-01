namespace FactoryMethodPattern
{
    using System;
    using CompositionExample.Creator;
    using ConcreteCreator;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Factory Method with Inheritance");

            var v8mCar = new V8Car();

            v8mCar.PrintDetails();

            Console.ReadLine();

            var twinTurboCar = new TwinTurboCar();

            twinTurboCar.PrintDetails();

            Console.ReadLine();

            Console.WriteLine("Factory Method with Composition");

            var bmwSeries1 = CarFactory.BmwSeries1();
            var mercedesClassA = CarFactory.MercedesClassA();

            bmwSeries1.Driving.Accelerate(10);

            mercedesClassA.Driving.Accelerate(25);

            bmwSeries1.Driving.Accelerate(20);

            bmwSeries1.PrintDetails();
            mercedesClassA.PrintDetails();

            Console.ReadLine();
        }
    }
}