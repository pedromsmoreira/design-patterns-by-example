namespace MediatorPattern.ConcreteColleague
{
    using System;
    using Colleague;
    using Mediator;

    public class YoungCharacter : ICharacter
    {
        private string name;
        private IChatMediator chatMediator;

        public YoungCharacter(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Character Type: Young -- {this.name}; Sent Message: {message}");
            this.chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Character Type: Young -- {this.name}; Received Message: {message}");
        }
    }
}