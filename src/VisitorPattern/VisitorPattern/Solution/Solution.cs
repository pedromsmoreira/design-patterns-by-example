namespace VisitorPattern.Solution
{
    public class Solution : BaseExample
    {
        public override void ExpectedResult()
        {
            Man theMan = new Man();
            Jake jake = new Jake();
            Woman theWoman = new Woman();
            Mary mary = new Mary();

            theWoman.Accept(theMan);
            mary.Accept(theMan);
            theWoman.Accept(jake);
            mary.Accept(jake);

            /*  The previous code will print:

                    > Every man loves every woman!
                    > Every man loves Mary.
                    > Jake loves every woman!
                    > Jake loves Mary.

                As expected!
            */
        }

        public override void UnexpectedResult()
        {
            // Note the different data types!
            Man jakeRef = new Jake();
            Woman maryRef = new Mary();
            maryRef.Accept(jakeRef);

            /*  The previous code will print:

                    > Jake loves Mary.

                As expected!
            */
        }
    }
}