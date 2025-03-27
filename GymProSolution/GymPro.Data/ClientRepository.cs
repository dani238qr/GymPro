using System;
using System.Collections.Generic;
using System.IO;
using GymPro.Core;

namespace GymPro.Data
{
    public class ClientRepository
    {
        private List<Client> clients = new List<Client>();
        private string filePath;

        public ClientRepository(string fileName = "clients.txt")
        {
            filePath = fileName;  
            LoadClientsFromFile();
        }


        public void AddClient(Client client)
        {
            clients.Add(client);
            SaveClientsToFile();
        }

        public List<Client> GetClients()
        {
            return new List<Client>(clients); 
        }

        public List<Client> SearchClientsByName(string name)
        {
            return clients.FindAll(c => c.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase)
                                     || c.LastName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        private void LoadClientsFromFile()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    try
                    {
                        clients.Add(Client.FromString(line)); // Convert string to Client object
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading client: {ex.Message}");
                    }
                }
            }
        }

        private void SaveClientsToFile()
        {
            List<string> lines = new List<string>();
            foreach (var client in clients)
            {
                lines.Add(client.ToString()); // Convert Client object to string
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}
