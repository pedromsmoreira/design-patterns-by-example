namespace BuilderPattern
{
    using System;
    using ConcreteBuilder;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Builder Pattern!");

            Console.WriteLine("Director!!");

            var bmw = new BmwSeries1();

            bmw.Car.ShowDescription();

            Console.ReadLine();
        }
    }
}