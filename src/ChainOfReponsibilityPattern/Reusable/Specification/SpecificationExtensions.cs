namespace ChainOfReponsibilityPattern.Reusable.Specification
{
    public static class SpecificationExtensions
    {
        public static Specification<T> And<T>(this ISpecification<T> left, ISpecification<T> right)
        {
            return new Specification<T>(r => left.IsSatisfiedBy(r) && right.IsSatisfiedBy(r));
        }

        public static Specification<T> Or<T>(this ISpecification<T> left, ISpecification<T> right)
        {
            return new Specification<T>(r => left.IsSatisfiedBy(r) || right.IsSatisfiedBy(r));
        }

        public static Specification<T> Not<T>(this ISpecification<T> left)
        {
            return new Specification<T>(r => !left.IsSatisfiedBy(r));
        }
    }
}