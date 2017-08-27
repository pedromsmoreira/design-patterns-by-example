namespace FactoryMethodPattern.ConcreteCreator
{
    using ConcreteProduct;
    using Creator;

    public class TwinTurboCar : Vehicle
    {
        public override void CreateParts()
        {
            this.Parts.Add(new Engine(Engine.EngineType.TwinTurbo));
            this.Parts.Add(new Seat(4));
            this.Parts.Add(new Wheel(4));
        }

        public override string Name => nameof(TwinTurboCar);
    }
}