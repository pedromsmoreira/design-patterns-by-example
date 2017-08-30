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
            IUser bart = new PremiumUser(chatMediator, "Bart");
            IUser grandpa = new PremiumUser(chatMediator, "Grandpa Abraham Simpson");
            IUser lisa = new BasicUser(chatMediator, "Lisa");

            chatMediator.AddUser(bart);
            chatMediator.AddUser(grandpa);
            chatMediator.AddUser(lisa);

            bart.SendMessage("Grandpa, why don't you tell a story?");
            lisa.SendMessage("Yeah Grandpa, you lived a long and interesting life.");
            grandpa.SendMessage("That's a lie and you know it.");

            Console.ReadLine();
        }
    }
}