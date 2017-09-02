namespace FactoryMethodPattern
{
    using System;
    using CompositionExample.Creator;
    using ConcreteCreator;
    using FactoryMethodPattern.CompositionExample.ConcreteCreator;

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
        }
    }
}