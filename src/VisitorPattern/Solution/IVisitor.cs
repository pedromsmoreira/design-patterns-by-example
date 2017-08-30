namespace VisitorPattern.Solution
{
    public interface IVisitor
    {
        void Loves(Woman woman);

        void Loves(Mary mary);
    }
}