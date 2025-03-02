using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPro
{
    class Subscription
    {
        public string Type { get; set; }
        public string Options { get; set; }
        public decimal Price { get; set; }
        public int DurationDays { get; set; }

        public Subscription(string type, string options, decimal price, int durationDays)
        {
            Type = type;
            Options = options;
            Price = price;
            DurationDays = durationDays;
        }
    }
}
