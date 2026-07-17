namespace RukhlyadaApp.HW2._4
{
    internal class OrderConsole
    {
        public static void Run()
        {
            Order order1 = new Order();
            order1.AddDish(new Dish("shavarma", 5.99m, 4));
            order1.AddDishes(new List<Dish> { new Dish("Cola", 1.99m, 4), new Dish("Fries", 2.99m, 2) });
            Console.WriteLine("Order Info");
            Console.WriteLine("Order Number:{0} CreatedAt:{1} TotalCost:{2}", order1.OrderNumber, order1.CreatedAt, order1.TotalPrice); 
            string dishesInfo = "";
            foreach (Dish dish in order1.Dishes)
            {
                dishesInfo += $"DishName:{dish.DishName} Price:{dish.Price} Quantity:{dish.Quantity} TotalPrice:{dish.TotalPrice}\n";
            }
            Console.WriteLine($"Dishes:{dishesInfo}" );
        }
    }
}

