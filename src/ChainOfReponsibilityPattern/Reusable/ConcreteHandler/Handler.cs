namespace ChainOfReponsibilityPattern.Reusable.ConcreteHandler
{
    using System;
    using Client;
    using Handler;
    using Specification;

    public class Handler<T> : IHandler<T> where T : IProcessable
    {
        private readonly string name;
        private IHandler<T> sucessor;
        private ISpecification<T> specification;

        public Handler(string name)
        {
            this.name = name;
        }

        public void SetSucessor(IHandler<T> handler)
        {
            this.sucessor = handler;
        }

        public void HandleRequest(T request)
        {
            if (this.CanHandle(request))
            {
                Console.WriteLine($"Handled by {this.name}");
                request.Process();
                return;
            }

            this.sucessor.HandleRequest(request);
        }

        public void SetSpecification(ISpecification<T> specification)
        {
            this.specification = specification;
        }

        public bool CanHandle(T request)
        {
            return this.specification.IsSatisfiedBy(request);
        }
    }
}