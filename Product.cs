namespace Lesson8
{
    public class Product
    {
        public string Name { get; set; }
        private string _article;
        public string Article
        {
            get
            {
                return _article;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _article = value;
                }
                else
                {
                    throw new ArgumentException("не может быть пустым");
                }
            }
        }

        private int _price;
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }

                else
                {
                    throw new ArgumentException("цена не может быть отрицательной или равной нулю");
                }
            }
        }
        public int ExpirationDays { get; private set; }
        public bool IsAgeRestricted { get; set; }

        public Product(string name, string article, int price, int expirationDays, bool isAgeRestricted = false)
        {
            Name = name;
            Article = article; 
            Price = price;     
            if (expirationDays > 0)
            {
                ExpirationDays = expirationDays;
            }
            else
            {
                throw new ArgumentException("cрок годности должен быть положительным");
            }
            IsAgeRestricted = isAgeRestricted;
        }

        public bool IsExpired()
        {
            DateTime now = DateTime.Now;

            DateTime expirationDate = now.AddDays(ExpirationDays);

            if (now > expirationDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CanBeSold(int customerAge)
        {
            if (IsExpired())
            {
                return false;
            }
            else
            {
                if (customerAge < 18 && IsAgeRestricted)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
