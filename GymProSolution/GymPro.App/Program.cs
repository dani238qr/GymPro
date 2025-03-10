using System;
using GymPro.Core;
using GymPro.Data;

namespace GymPro.App
{
    class Program
    {
        static ClientRepository clientRepository = new ClientRepository();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("--- GymPro ---");
                Console.WriteLine("1. Add client");
                Console.WriteLine("2. Show clients");
                Console.WriteLine("3. Search client by name");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1": AddClient(); break;
                    case "2": ShowClients(); break;
                    case "3": SearchClientByName(); break;
                    case "4": return;
                    default: Console.WriteLine("Invalid option"); break;
                }
            }
        }

        static void AddClient()
        {
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Personal Numeric Code (CNP): ");
            string cnp = Console.ReadLine();
            Console.Write("Subscription Type: ");
            string subscriptionType = Console.ReadLine();
            Console.Write("Subscription Options: ");
            string options = Console.ReadLine();
            Console.Write("Subscription Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Duration (days): ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Expiration Date (YYYY-MM-DD): ");
            DateTime expirationDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Contact: ");
            string contact = Console.ReadLine();

            Subscription subscription = new Subscription(subscriptionType, options, price, duration);
            Client client = new Client(cnp, lastName, firstName, subscription, expirationDate, contact);

            clientRepository.AddClient(client);
            Console.WriteLine("Client successfully added!\n");
        }

        static void ShowClients()
        {
            var clients = clientRepository.GetClients();
            if (clients.Count > 0)
            {
                Console.WriteLine("Client list:");
                foreach (var client in clients)
                {
                    Console.WriteLine(client);
                }
            }
            else
            {
                Console.WriteLine("No registered clients.");
            }
        }

        static void SearchClientByName()
        {
            Console.Write("Enter name to search (First or Last Name): ");
            string name = Console.ReadLine();

            var foundClients = clientRepository.SearchClientsByName(name);
            if (foundClients.Count > 0)
            {
                Console.WriteLine("Found clients:");
                foreach (var client in foundClients)
                {
                    Console.WriteLine(client);
                }
            }
            else
            {
                Console.WriteLine("No clients found with that name.");
            }
        }
    }
}
