namespace AbstractFactoryPattern.CompositionExample.Product
{
    public interface ISteering
    {
        void TurnLeft(double degrees);

        void TurnRight(double degrees);
    }
}