namespace FactoryMethodPattern.CompositionExample.Product
{
    public class Wheel : IWheel
    {
        public Wheel()
        {
            this.RotationSpeed = 0.0;
        }

        public double RotationSpeed { get; set; }

        public double Angle { get; set; }
    }
}