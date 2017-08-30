namespace MediatorPattern.ConcreteColleague
{
    using System;
    using Colleague;
    using Mediator;

    public class BasicUser : IUser
    {
        private string name;
        private IChatMediator chatMediator;

        public BasicUser(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"User Type: Basic -- {this.name}; Sent Message: {message}");
            this.chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"User Type: Basic -- {this.name}; Received Message: {message}");
        }
    }
}