namespace ChainOfReponsibilityPattern.Reusable.Specification
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T rule);
    }
}