namespace ChainOfReponsibilityPattern
{
    using System;
    using System.Collections.Generic;
    using Client;
    using LimitedButFunctional.ConcreteHandler;
    using Reusable.ConcreteHandler;
    using Reusable.Specification;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Chain Of Responsibility Pattern");

            Console.WriteLine("Functional but not reusable example!");
            var fundingList = new List<Funding>
            {
                new Funding(FundingType.DebtFunding, 35000, 24),
                new Funding(FundingType.EquityFunding, 10000, 12),
                new Funding(FundingType.Bootstrap, 12000, 12),
                new Funding(FundingType.Bootstrap, 5000, 10)
            };

            var investor = new Investor();
            var ventureCapitalist = new VentureCapitalist();
            var seniorVentureCapitalist = new SeniorVentureCapitalist();

            investor.SetSucessor(ventureCapitalist);
            ventureCapitalist.SetSucessor(seniorVentureCapitalist);

            fundingList.ForEach(f => investor.HandleRequest(f));

            Console.ReadLine();

            Console.WriteLine("Reusable example!");

            var bootstrapSpec = new Specification<Funding>(f => f.FundingType == FundingType.Bootstrap);
            var debtFundingSpec = new Specification<Funding>(f => f.FundingType == FundingType.DebtFunding);
            var equityFundingSpec = new Specification<Funding>(f => f.FundingType == FundingType.EquityFunding);

            var lowBudgetAmountSpec = new Specification<Funding>(f => f.Amount < 10000);
            var mediumBudgetAmountSpec = new Specification<Funding>(f => f.Amount < 30000);

            var reusableInvestor = new Handler<Funding>("Investor");
            var reusableVentureCapitalist = new Handler<Funding>("Venture Capitalist");
            var reusableSeniorVentureCapitalist = new Handler<Funding>("Senior Venture Capitalist");

            reusableInvestor.SetSpecification(bootstrapSpec.And(lowBudgetAmountSpec));
            reusableVentureCapitalist.SetSpecification(bootstrapSpec.Or(equityFundingSpec).And(mediumBudgetAmountSpec));
            reusableSeniorVentureCapitalist.SetSpecification(debtFundingSpec);

            reusableInvestor.SetSucessor(reusableVentureCapitalist);
            reusableVentureCapitalist.SetSucessor(reusableSeniorVentureCapitalist);

            fundingList.ForEach(f => reusableInvestor.HandleRequest(f));
            Console.ReadLine();
        }
    }
}