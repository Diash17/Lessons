using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Alcohol : Product
    {
        public double AlcoholPercent { get; set; }

        public Alcohol(string name, string article, int price, int expirationDays, double alcoholPercent)
            : base(name, article, price, expirationDays, true)
        {
            AlcoholPercent = alcoholPercent;
        }

        public string GetAlcoholInfo()
        {
            return $"{Name} ({AlcoholPercent}% алкоголя)";
        }

        public bool CanBeSold(int customerAge, double alcoholPercent)
        {
            if (IsExpired())
            {
                return false;
            }

            if (customerAge < 18)
            {
                return false;
            }

            if (IsAgeRestricted && alcoholPercent >= 20.0 && customerAge < 21)
            {
                return false;

            }
                return true;
        }
    }
}
