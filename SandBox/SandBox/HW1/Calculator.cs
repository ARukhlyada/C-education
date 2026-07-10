namespace RukhlyadaApp.HW1
{
    public class Calculator
    {
        public double Calculate(double firstNumber, double secondNumber, string operation)
        {
            switch (operation)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "*":
                    return firstNumber * secondNumber;
                case "/":
                    if (secondNumber == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero");
                    }  
                    return firstNumber / secondNumber;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }
}
