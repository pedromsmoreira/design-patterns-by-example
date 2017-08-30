namespace MediatorPattern.ConcreteColleague
{
    using System;
    using Colleague;
    using Mediator;

    public class OldCharacter : ICharacter
    {
        private string name;
        private IChatMediator chatMediator;

        public OldCharacter(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Character Type: Old -- {this.name}; Sent Message: {message}");
            this.chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Character Type: Old -- {this.name}; Received Message: {message}");
        }
    }
}