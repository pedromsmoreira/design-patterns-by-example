namespace MediatorPattern.Colleague
{
    public interface ICharacter
    {
        void SendMessage(string message);

        void ReceiveMessage(string message);
    }
}