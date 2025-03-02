using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro
{
    class Client
    {
        public string CNP { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Subscription Subscription { get; set; }
        public string ExpirationDate { get; set; }
        public string Contact { get; set; }

        public Client(string cnp, string lastName, string firstName, Subscription subscription, string expirationDate, string contact)
        {
            CNP = cnp;
            LastName = lastName;
            FirstName = firstName;
            Subscription = subscription;
            ExpirationDate = expirationDate;
            Contact = contact;
        }

        public override string ToString()
        {
            return $"{CNP},{LastName},{FirstName},{Subscription.Type},{ExpirationDate},{Contact}";
        }
    }
}
