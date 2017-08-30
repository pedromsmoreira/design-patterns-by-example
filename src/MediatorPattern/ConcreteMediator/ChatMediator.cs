namespace MediatorPattern.ConcreteMediator
{
    using System;
    using System.Collections.Generic;
    using Colleague;
    using Mediator;

    public class ChatMediator : IChatMediator
    {
        private List<IUser> users;

        public ChatMediator()
        {
            this.users = new List<IUser>();    
        }

        public void AddUser(IUser user)
        {
            this.users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (var user in this.users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}