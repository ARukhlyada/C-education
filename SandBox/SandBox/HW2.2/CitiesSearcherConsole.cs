namespace RukhlyadaApp.HW2._2
{
    public class CitiesSearcherConsole
    {
        public static void Run()
        {
            CitiesSearcher citiesSearcher = new CitiesSearcher();
            Console.WriteLine("enter city to find");
            string cityToFind = Console.ReadLine();
            string result = citiesSearcher.SearcherCity(cityToFind);
            Console.WriteLine(result);
        }
    }
}
