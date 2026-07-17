namespace RukhlyadaApp.HW2._4
{
    internal class Order
    {
        public List<Dish> Dishes { get; } = [];

        public int OrderNumber { get; }

        public DateTime CreatedAt { get; }

        public decimal TotalPrice 
        {
            get
            {
                decimal total = 0;
                foreach (Dish dish in Dishes) 
                {
                    total += dish.TotalPrice;
                }   
                return total;
            }
        }

        public static int NextOrderNumber { get; private set; } = 1;

        public void AddDish(Dish dish) 
        {
            Dishes.Add(dish);
        }

        public void AddDishes(List<Dish> dishes)
        {
            Dishes.AddRange(dishes);
        }

        public Order()
        {
            OrderNumber = NextOrderNumber;
            NextOrderNumber += 1;
            CreatedAt = DateTime.Now;
        }
    }
}
