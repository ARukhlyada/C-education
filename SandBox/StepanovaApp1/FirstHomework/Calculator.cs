using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepanovaApp1.FirstHomework
{
    internal class Calculator
    {
        internal double Calculate(double num1, double num2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0 && num1 != 0)
                        result = num1 / num2;
                    else
                        throw new DivideByZeroException("Cannot divide by zero.");
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
            return result;
        }
    }
}