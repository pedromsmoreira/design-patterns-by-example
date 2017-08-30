namespace MediatorPattern.ConcreteMediator
{
    using System;
    using System.Collections.Generic;
    using Colleague;
    using Mediator;

    public class ChatMediator : IChatMediator
    {
        private List<ICharacter> characters;

        public ChatMediator()
        {
            this.characters = new List<ICharacter>();    
        }

        public void AddCharacter(ICharacter character)
        {
            this.characters.Add(character);
        }

        public void SendMessage(string message, ICharacter sender)
        {
            foreach (var character in this.characters)
            {
                if (character != sender)
                {
                    character.ReceiveMessage(message);
                }
            }
        }
    }
}