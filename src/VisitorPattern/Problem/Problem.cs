namespace VisitorPattern.Problem
{
    public class Problem : BaseExample
    {
        public override void ExpectedResult()
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

        public override void UnexpectedResult()
        {
            // Note the different data types!
            Man jakeRef = new Jake();
            Woman maryRef = new Mary();
            jakeRef.Loves(maryRef);

            /*  The previous code will print:

                    > Jake loves every woman!

                instead of

                    > Jake loves Mary.

                Runtime chooses method dynamically based on jakeRef ONLY!
            */
        }
    }
}