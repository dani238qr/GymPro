using GymPro.Core.Enums;

namespace GymPro.Core
{
    public class Subscription
    {
        public SubscriptionType Type { get; set; }
        public string Options { get; set; }
        public decimal Price { get; set; }
        public int DurationDays { get; set; }

        public Subscription(SubscriptionType type, string options, decimal price, int durationDays)
        {
            Type = type;
            Options = options;
            Price = price;
            DurationDays = durationDays;
        }

        public override string ToString()
        {
            return $"{Type},{Options},{Price},{DurationDays}";
        }
    }
}
