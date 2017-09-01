namespace FactoryMethodPattern.CompositionExample.ConcreteProduct
{
    using Product;

    public class FrontSteering : ISteering
    {
        private readonly IWheel left;
        private readonly IWheel right;

        public FrontSteering(IWheel left, IWheel right)
        {
            this.left = left;
            this.right = right;
        }

        public void TurnLeft(double degrees)
        {
            this.left.Angle -= degrees;
            this.right.Angle -= degrees;
        }

        public void TurnRight(double degrees)
        {
            this.right.Angle += degrees;
            this.left.Angle += degrees;
        }
    }
}