namespace FactoryMethodPattern.ConcreteCreator
{
    using ConcreteProduct;
    using Creator;

    public class TwinTurboCar : Vehicle
    {
        public override string Name => nameof(TwinTurboCar);

        public override void CreateParts()
        {
            this.Parts.Add(new Engine(EngineType.TwinTurbo));
            this.Parts.Add(new Seat(4));
            this.Parts.Add(new Wheel(4));
        }
    }
}