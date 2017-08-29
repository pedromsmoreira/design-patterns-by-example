namespace VisitorPattern.Problem
{
    using System;

    public class Jake : Man
    {
        public override void Loves(Woman woman)
        {
            Console.WriteLine("Jake loves every woman!");
        }
        public override void Loves(Mary mary)
        {
            Console.WriteLine("Jake loves Mary.");
        }
    };
}