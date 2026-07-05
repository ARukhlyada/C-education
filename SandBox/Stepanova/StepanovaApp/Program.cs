Console.WriteLine("--- Консольный калькулятор ---");

// 1. Ввод первого числа
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

// 2. Ввод оператора
Console.Write("Введите оператор (+, -, *, /): ");
string op = Console.ReadLine();

// 3. Ввод второго числа
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result = 0;
bool validOperation = true;

// 4. Расчет результата
switch (op)
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
        if (num2 == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль невозможно!");
            validOperation = false;
        }
        else
        {
            result = num1 / num2;
        }
        break;
    default:
        Console.WriteLine("Ошибка: неверный оператор!");
        validOperation = false;
        break;
}

// 5. Вывод результата
if (validOperation)
{
    Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
}

Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();