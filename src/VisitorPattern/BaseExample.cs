namespace VisitorPattern
{
    using System;

    public abstract class BaseExample
    {
        public void Run()
        {
            Console.WriteLine("Running ExpectedResult()");
            this.ExpectedResult();

            Console.WriteLine("Running UnexpectedResult()");
            this.UnexpectedResult();
        }

        public abstract void ExpectedResult();

        public abstract void UnexpectedResult();
    }
}
