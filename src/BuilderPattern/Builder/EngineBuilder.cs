namespace BuilderPattern.Builder
{
    using Product.Parts;

    public class EngineBuilder
    {
        private EngineType type;

        public EngineBuilder()
        {
            this.type = EngineType.None;
        }

        public EngineBuilder WithType(EngineType type)
        {
            this.type = type;
            return this;
        }

        public Engine Build()
        {
            return new Engine(this.type);
        }
    }
}