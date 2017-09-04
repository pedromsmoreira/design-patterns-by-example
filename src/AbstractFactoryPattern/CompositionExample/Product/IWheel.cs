﻿namespace AbstractFactoryPattern.CompositionExample.Product
{
    public interface IWheel
    {
        double RotationSpeed { get; set; }

        double Angle { get; set; }
    }
}