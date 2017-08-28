namespace FactoryMethodPattern
{
    using System;
    using ConcreteCreator;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var v8mCar = new V8Car();

            v8mCar.PrintDetails();

            Console.ReadLine();

            var twinTurboCar = new TwinTurboCar();

            twinTurboCar.PrintDetails();

            Console.ReadLine();
        }
    }
}