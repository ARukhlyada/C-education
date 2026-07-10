namespace RukhlyadaApp.HW1
{
    public static class CalConsole
    {
        public static void Run()
        {
            Console.WriteLine("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Calculator calculator = new Calculator();
            double result = calculator.Calculate(firstNumber, secondNumber, operation);

            Console.WriteLine($"result: {result}");
        }
    }

}
