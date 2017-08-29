namespace VisitorPattern.Solution
{
    using System;

    public class Man : IVisitor
    {
        public virtual void Loves(Woman woman)
        {
            Console.WriteLine("Every man loves every woman!");
        }
        public virtual void Loves(Mary mary)
        {
            Console.WriteLine("Every man loves Mary.");
        }
    };
}