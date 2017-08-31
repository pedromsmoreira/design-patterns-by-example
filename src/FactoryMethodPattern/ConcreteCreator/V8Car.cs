namespace FactoryMethodPattern.ConcreteCreator
{
    using ConcreteProduct;
    using Creator;

    public class V8Car : Vehicle
    {
        public override string Name => nameof(V8Car);

        public override void CreateParts()
        {
            this.Parts.Add(new Engine(EngineType.V8));
            this.Parts.Add(new Seat(2));
            this.Parts.Add(new Wheel(4));
        }
    }
}