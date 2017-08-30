namespace VisitorPattern.Solution
{
    internal interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
