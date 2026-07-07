using StepanovaApp1.FirstHomework;

Console.WriteLine("Enter number of your homework");

int homeworkNumber = Convert.ToInt32(Console.ReadLine());

switch (homeworkNumber)
{
    case 1:
        CalculatorConsole.Start();
        break;
    case 2:
        //StepanovaApp1.SecondHomework.SecondHomework secondHomework = new StepanovaApp1.SecondHomework.SecondHomework();
        //secondHomework.Start();
        //break;
    default:
        Console.WriteLine("Invalid homework number");
        break;
}