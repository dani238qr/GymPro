using System;
using System.Collections.Generic;
using GymPro.Core;

namespace GymPro.Data
{
    public class ClientRepository
    {

        private List<Client> clients = new List<Client>();

       
        public void AddClient(Client client)
        {
            clients.Add(client);
        }

       
        public List<Client> GetClients()
        {
            return clients;
        }

     
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
    }
}
