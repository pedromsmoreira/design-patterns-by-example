namespace VisitorPattern.Solution
{
    public class Mary : Woman
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Loves(this);
        }
    }
}