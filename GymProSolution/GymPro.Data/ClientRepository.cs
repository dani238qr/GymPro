using System;
using System.Collections.Generic;
using System.IO;
using GymPro.Core;

namespace GymPro.Data
{
    public class ClientRepository
    {
        private List<Client> clients = new List<Client>();
        private readonly string filePath = "clients.txt";

        public ClientRepository()
        {
            LoadClientsFromFile();
        }

        // Add a new client and save to file
        public void AddClient(Client client)
        {
            clients.Add(client);
            SaveClientToFile(client);
        }

        // Get all clients
        public List<Client> GetClients()
        {
            return clients;
        }

        // Search for clients by name (either first or last name)
        public List<Client> SearchClientsByName(string name)
        {
            var foundClients = new List<Client>();

            foreach (var client in clients)
            {
                if (client.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                    client.LastName.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    foundClients.Add(client);
                }
            }

            return foundClients;
        }

        // Save a single client to the file
        private void SaveClientToFile(Client client)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(client.ToString());
            }
        }

        // Load all clients from the file at startup
        private void LoadClientsFromFile()
        {
            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                try
                {
                    clients.Add(Client.FromString(line));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error loading client: {ex.Message}");
                }
            }
        }
    }
}
