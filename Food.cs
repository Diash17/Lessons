using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Food : Product
    {
        public bool IsVegan { get; set; }

        public Food(string name, string article, int price, int expirationDays, bool isVegan)
            : base(name, article, price, expirationDays, false)
        {
           IsVegan = isVegan;
        }


    }
}
