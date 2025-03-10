using System;

namespace GymPro.Core
{
    public class Client
    {
        public string CNP { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Subscription Subscription { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Contact { get; set; }

        public Client(string cnp, string lastName, string firstName, Subscription subscription, DateTime expirationDate, string contact)
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
            return $"{CNP},{LastName},{FirstName},{Subscription.Type},{Subscription.Options},{Subscription.Price},{Subscription.DurationDays},{ExpirationDate:yyyy-MM-dd},{Contact}";
        }

        public static Client FromString(string data)
        {
            var parts = data.Split(',');
            if (parts.Length < 8) throw new FormatException("Invalid client data format.");

            string cnp = parts[0];
            string lastName = parts[1];
            string firstName = parts[2];
            string subscriptionType = parts[3];
            string subscriptionOptions = parts[4];
            decimal price = decimal.Parse(parts[5]);
            int durationDays = int.Parse(parts[6]);
            DateTime expirationDate = DateTime.Parse(parts[7]);
            string contact = parts[8];

            Subscription subscription = new Subscription(subscriptionType, subscriptionOptions, price, durationDays);
            return new Client(cnp, lastName, firstName, subscription, expirationDate, contact);
        }
    }
}
