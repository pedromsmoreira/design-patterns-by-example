namespace ChainOfReponsibilityPattern.Reusable.Specification
{
    using System;

    public class Specification<T> : ISpecification<T>
    {
        private Func<T, bool> expression;

        public Specification(Func<T, bool> expression)
        {
            this.expression = expression;
        }

        public bool IsSatisfiedBy(T rule)
        {
            return this.expression(rule);
        }
    }
}