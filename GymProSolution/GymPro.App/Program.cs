using System;
using System.Collections.Generic;
using GymPro.Core;
using GymPro.Core.Enums;
using GymPro.Data;

namespace GymPro.App
{
    class Program
    {
        static ClientRepository clientRepository = new ClientRepository();
        static List<(string Name, CoachSpecialization Specialization)> personalCoaches = new List<(string, CoachSpecialization)>
        {
            ("John Smith", CoachSpecialization.WeightTraining),
            ("Emily Johnson", CoachSpecialization.Yoga),
            ("Michael Brown", CoachSpecialization.Crossfit),
            ("Sarah Davis", CoachSpecialization.StrengthTraining)
        };

        static void Main(string[] args)
        {
            // Default file name
            string fileName = "clients.txt";

            // Check if a command-line argument was provided
            if (args.Length > 0)
            {
                fileName = args[0];  // Use the provided file name
            }

            // Pass the file name to the ClientRepository
            clientRepository = new ClientRepository(fileName);

            while (true)
            {
                Console.Clear();
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
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
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

            Console.Write("Subscription Type (Basic, Premium, VIP): ");
            string subscriptionTypeInput = Console.ReadLine();

            // Convert string to enum
            if (!Enum.TryParse(subscriptionTypeInput, true, out GymPro.Core.Enums.SubscriptionType subscriptionType))
            {
                Console.WriteLine("Invalid subscription type! Defaulting to 'Basic'.");
                subscriptionType = GymPro.Core.Enums.SubscriptionType.Basic;
            }


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


            Console.Write("Do you want a personal coach? (yes/no): ");
            string wantsCoach = Console.ReadLine().ToLower();

            string personalCoach = "None";
            // Ensure we only store the name, not "John Smith - Coach: John Smith"
            if (wantsCoach == "yes")
            {
                Console.WriteLine("Available Personal Coaches:");
                for (int i = 0; i < personalCoaches.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {personalCoaches[i].Name} - Specialization: {personalCoaches[i].Specialization}");
                }

                Console.Write("Choose a coach (enter number): ");
                if (int.TryParse(Console.ReadLine(), out int coachIndex) && coachIndex > 0 && coachIndex <= personalCoaches.Count)
                {
                    personalCoach = personalCoaches[coachIndex - 1].Name;  // Save only the name
                }
                else
                {
                    Console.WriteLine("Invalid choice, no coach assigned.");
                }
            }


            Client client = new Client(cnp, lastName, firstName, subscription, expirationDate, contact, personalCoach);
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
                    Console.WriteLine($"{client} - Coach: {client.PersonalCoach}");
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
