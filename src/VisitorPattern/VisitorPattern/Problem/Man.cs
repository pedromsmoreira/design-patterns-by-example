namespace VisitorPattern.Problem
{
    using System;

    public class Man
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