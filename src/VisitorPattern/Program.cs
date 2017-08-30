namespace VisitorPattern
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Running Problem.cs...");

            new Problem.Problem().Run();

            Console.WriteLine("Running Solution.cs...");
            new Solution.Solution().Run();

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}