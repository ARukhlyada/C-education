using RukhlyadaApp.HW1;

Console.WriteLine("choose HW");

double homeWorkNumber = Convert.ToDouble(Console.ReadLine());
switch (homeWorkNumber)    
{
    case 1:
        CalConsole.Run();
        break;
    case 2.2:
        RukhlyadaApp.HW2._2.CitiesSearcherConsole.Run();
        break;
    case 2.4:
        RukhlyadaApp.HW2._4.OrderConsole.Run();
        break;
    default:
        Console.WriteLine("Invalid argument. Use 'calc' or 'cities'.");
        break;
}

