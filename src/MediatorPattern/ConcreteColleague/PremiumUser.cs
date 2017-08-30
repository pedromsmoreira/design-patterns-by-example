namespace MediatorPattern.ConcreteColleague
{
    using System;
    using Colleague;
    using Mediator;

    public class PremiumUser : IUser
    {
        private string name;
        private IChatMediator chatMediator;

        public PremiumUser(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"User Type: Premium -- {this.name}; Sent Message: {message}");
            this.chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"User Type: Premium -- {this.name}; Received Message: {message}");
        }
    }
}