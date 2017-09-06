namespace ChainOfReponsibilityPattern.Reusable.Handler
{
    using Specification;

    public interface IHandler<T>
    {
        void SetSucessor(IHandler<T> handler);

        void HandleRequest(T request);

        void SetSpecification(ISpecification<T> specification);

        bool CanHandle(T request);
    }
}