﻿namespace ChainOfReponsibilityPattern.LimitedButFunctional.ConcreteHandler
{
    using System;
    using Client;
    using Handler;

    public class Investor : Handler<Funding>
    {
        public override void HandleRequest(Funding request)
        {
            if (this.CanHandle(request))
            {
                Console.WriteLine($"Handled by {nameof(Investor)}");
                request.Process();
                return;
            }

            if (this.Sucessor.IsNull())
            {
                return;
            }

            this.Sucessor.HandleRequest(request);
        }

        public override bool IsNull()
        {
            return false;
        }

        private bool CanHandle(Funding funding)
        {
            return funding.FundingType == FundingType.Bootstrap;
        }
    }
}