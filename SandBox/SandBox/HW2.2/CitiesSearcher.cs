namespace RukhlyadaApp.HW2._2
{
    internal class CitiesSearcher
    {
        string[] cities = { "Москва", "Париж", "Лондон", "Токио", "Берлин" };

        public string SearcherCity(string cityToFind)
        {
            foreach (string city in cities)
            {
                if (city == cityToFind)
                {
                    return "found";
                }
            }
            return "not found";            
        }     
    }   
}
