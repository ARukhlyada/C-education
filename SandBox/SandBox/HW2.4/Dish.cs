namespace RukhlyadaApp.HW2._4
{
    internal class Dish
    {
        private decimal m_price;

        public string DishName { get; set; }

        public decimal Price
        {
            get
            {
                return m_price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Price cannot be zero or negative.");
                }
                m_price = value;
            }
        }

        public int Quantity { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        public Dish(int quantity = 1)
        {
            Quantity = quantity;
        }

        public Dish(string dishName, decimal price, int quantity = 1): this(quantity)
        {
            if (string.IsNullOrWhiteSpace(dishName))
            {
                throw new ArgumentException("Dish name cannot be null or empty.", nameof(dishName));
            }
            DishName = dishName;
            Price = price;
        }
    }
}
