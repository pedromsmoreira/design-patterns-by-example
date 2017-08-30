namespace MediatorPattern
{
    using System;
    using Colleague;
    using ConcreteColleague;
    using ConcreteMediator;
    using Mediator;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Mediator Pattern");

            IChatMediator chatMediator = new ChatMediator();

            // Didn't use var to explicity show the types.
            ICharacter bart = new YoungCharacter(chatMediator, "Bart");
            ICharacter grandpa = new OldCharacter(chatMediator, "Grandpa Abraham Simpson");
            ICharacter lisa = new YoungCharacter(chatMediator, "Lisa");

            chatMediator.AddCharacter(bart);
            chatMediator.AddCharacter(grandpa);
            chatMediator.AddCharacter(lisa);

            bart.SendMessage("Grandpa, why don't you tell a story?");
            lisa.SendMessage("Yeah Grandpa, you lived a long and interesting life.");
            grandpa.SendMessage("That's a lie and you know it.");

            Console.ReadLine();
        }
    }
}