using System;
using System.Collections.Generic;
using System.IO;
using GymPro.Core;

namespace GymPro.Data
{
    public class ClientRepository
    {
        private const string FilePath = "clients.txt";

        public void AddClient(Client client)
        {
            File.AppendAllText(FilePath, client + "\n");
        }

        public List<string> GetClients()
        {
            if (File.Exists(FilePath))
                return new List<string>(File.ReadAllLines(FilePath));
            return new List<string>();
        }
    }
}
