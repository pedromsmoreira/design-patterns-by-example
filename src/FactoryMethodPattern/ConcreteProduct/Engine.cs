namespace FactoryMethodPattern.ConcreteProduct
{
    using System;
    using Product;

    public class Engine : Part
    {
        public Engine(EngineType type)
        {
            this.Type = type;
        }

        public EngineType Type { get; set; }

        public enum EngineType
        {
            V6 = 0,
            V8 = 1,
            TwinTurbo = 2,
        }

        public override string PrintDetails()
        {
            return $"Type: {this.Type}";
        }
    }

    
}