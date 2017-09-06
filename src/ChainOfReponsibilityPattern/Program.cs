namespace ChainOfReponsibilityPattern
{
    using System;
    using System.Collections.Generic;
    using Client;
    using LimitedButFunctional.ConcreteHandler;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Chain Of Responsibility Pattern");

            var fundingList = new List<Funding>
            {
                new Funding(FundingType.DebtFunding, 35000, 24),
                new Funding(FundingType.EquityFunding, 10000, 12),
                new Funding(FundingType.Bootstrap, 5000, 12)
            };

            var investor = new Investor();
            var ventureCapitalist = new VentureCapitalist();
            var seniorVentureCapitalist = new SeniorVentureCapitalist();

            investor.SetSucessor(ventureCapitalist);
            ventureCapitalist.SetSucessor(seniorVentureCapitalist);

            fundingList.ForEach(f => investor.HandleRequest(f));

            Console.ReadLine();
        }
    }
}