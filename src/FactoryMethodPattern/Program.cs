namespace FactoryMethodPattern
{
    using System;
    using ConcreteCreator;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var v8Car = new V8Car();

            v8Car.PrintDetails();

            Console.ReadLine();

            var twinTurboCar = new TwinTurboCar();

            twinTurboCar.PrintDetails();

            Console.ReadLine();
        }
    }
}