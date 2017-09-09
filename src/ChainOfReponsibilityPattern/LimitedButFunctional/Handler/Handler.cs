namespace ChainOfReponsibilityPattern.LimitedButFunctional.Handler
{
    public abstract class Handler<T>
    {
        protected Handler<T> Sucessor { get; private set; }

        public void SetSucessor(Handler<T> sucessor)
        {
            this.Sucessor = sucessor;
        }

        public abstract void HandleRequest(T request);

        public abstract bool IsNull();
    }
}