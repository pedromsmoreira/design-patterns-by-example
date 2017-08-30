namespace MediatorPattern.Mediator
{
    using Colleague;

    public interface IChatMediator
    {
        void AddCharacter(ICharacter character);

        void SendMessage(string message, ICharacter sender);
    }
}