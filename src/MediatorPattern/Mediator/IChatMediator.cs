namespace MediatorPattern.Mediator
{
    using Colleague;

    public interface IChatMediator
    {
        void AddUser(IUser user);

        void SendMessage(string message, IUser sender);
    }
}