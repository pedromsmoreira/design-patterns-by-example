namespace ChainOfReponsibilityPattern.Client
{
    using System;

    public enum FundingType
    {
        Default = 0,
        DebtFunding = 1,
        Bootstrap = 2,
        EquityFunding = 3
    }

    public class Funding : IProcessable
    {
        public Funding(FundingType type, int amount, int durationInMonths)
        {
            this.FundingType = type;
            this.Amount = amount;
            this.DurationInMonths = durationInMonths <= 0 ? 1 : durationInMonths;
        }

        public FundingType FundingType { get; }

        public int Amount { get; }

        public int DurationInMonths { get; }

        public string Details()
        {
            return $"Funding is of type: {this.FundingType}";
        }

        public void Process()
        {
            var valuePerMonth = this.Amount / this.DurationInMonths;
            Console.WriteLine($"Funding: {this.FundingType}");
            Console.WriteLine($"Amount: {this.Amount}");
            Console.WriteLine($"Duration: {this.DurationInMonths} months");
            Console.WriteLine($"Value Per Month: {valuePerMonth}");
        }
    }
}