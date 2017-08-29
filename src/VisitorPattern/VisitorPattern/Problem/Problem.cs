namespace VisitorPattern.Problem
{
    using System;

    public class Problem
    {
        public void Run()
        {
            Console.WriteLine("Running ExpectedResult()");
            this.ExpectedResult();

            Console.WriteLine("Running UnexpectedResult()");
            this.UnexpectedResult();
        }

        public void ExpectedResult()
        {
            Man theMan = new Man();
            Jake jake = new Jake();
            Woman theWoman = new Woman();
            Mary mary = new Mary();

            theMan.Loves(theWoman);
            theMan.Loves(mary);
            jake.Loves(theWoman);
            jake.Loves(mary);

            /*  The previous code will print:
             
                    > Every man loves every woman!
                    > Every man loves Mary.
                    > Jake loves every woman!
                    > Jake loves Mary.

                As expected!
            */
        }

        public void UnexpectedResult()
        {
            // Note the different data types!
            Man jakeRef = new Jake();
            Woman maryRef = new Mary();
            jakeRef.Loves(maryRef);

            /*  The previous code will print:
               
                    > Jake loves every woman!

                instead of

                    > ExplodingAsteroid hit an ApolloSpacecraft

                Runtime chooses method dynamically based on theExplodingAsteroidRef ONLY!
            */
        }
    }
}
 