using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Electronics : Product
    {
        public int WarrantyPeriod { get; set; }
        public bool RequiresSpecialPermission { get; set; }

        public Electronics(string name, string article, int price, int expirationDays, int warrantyPeriod, bool requiresSpecialPermission)
            : base(name, article, price, expirationDays, false)
        {
            WarrantyPeriod = warrantyPeriod;
            RequiresSpecialPermission = requiresSpecialPermission;
        }

        public override bool CanBeSold(int customerAge)
        {
            if (RequiresSpecialPermission && !HasSpecialPermission(customerAge))
            {
                return false; 
            }

            return true;
        }

        public string GetWarrantyInfo()
        {
            return $"Гарантия на {Name}: {WarrantyPeriod} месяцев.";
        }

        private bool HasSpecialPermission(int customerAge)
        {
            return customerAge >= 18;
        }
    }
}
