namespace BuilderPattern
{
    using System;
    using Director;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Builder Pattern!");

            var bmw = new BmwSeries1();

            bmw.Vehicle.ShowDescription();

            Console.ReadLine();
        }
    }
}