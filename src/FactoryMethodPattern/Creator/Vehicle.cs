namespace FactoryMethodPattern.Creator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Product;

    public abstract class Vehicle
    {
        public Vehicle()
        {
            this.CreateParts();
        }

        public abstract string Name { get; }

        public List<Part> Parts { get; } = new List<Part>();

        // Factory Method
        public abstract void CreateParts();

        public void PrintDetails()
        {
            var detailsBuilder = new StringBuilder($"Car: {this.Name}");

            this.BuildDescription(detailsBuilder);

            Console.WriteLine(detailsBuilder.ToString());
        }

        private void BuildDescription(StringBuilder detailsBuilder)
        {
            foreach (var part in this.Parts)
            {
                detailsBuilder.Append($" | {part.PrintDetails()}");
            }
        }
    }
}