namespace StepanovaApp1.FirstHomework
{
    internal class CalculatorConsole
    {
        internal static void Start()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /)");
            string operation = Console.ReadLine();

            double result = calculator.Calculate(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
        }
    }
}
