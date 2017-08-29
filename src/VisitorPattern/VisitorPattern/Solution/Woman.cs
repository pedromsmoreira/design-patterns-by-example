namespace VisitorPattern.Solution
{
    using System;

    public class Woman : IElement
    {
        public virtual void Accept(IVisitor visitor)
        {
            visitor.Loves(this);
        }

        public void BaseWomanMethod()
        {
            Console.WriteLine("Does anyone love me?");
        }
    }
}