namespace MediatorPattern.Colleague
{
    public interface IUser
    {
        void SendMessage(string message);

        void ReceiveMessage(string message);
    }
}