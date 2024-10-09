using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Введите 1-ое число: ");
        double numOne = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите 2-ое число: ");
        double numTwo = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите операцию:\n 1)Сложение(+)\n 2)Вычитание(-)\n 3)Умножение(*)\n 4)Деление(/)");
        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
                {
                    result = plusNum(numOne, numTwo);
                    break;
                }

            case "-":
                {
                    result = minusNum(numOne, numTwo);
                    break;
                }

            case "*":
                {
                    result = multiplicationNum(numOne, numTwo);
                    break;
                }

            case "/":
                {
                    result = delNum(numOne, numTwo);
                    break;
                }
        }

        Console.WriteLine("Результат вычислений: " + $"{result}");
    }


    public static double plusNum(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double minusNum(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double multiplicationNum(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double delNum(double num1, double num2)
    {
        return num1 / num2;
    }

}
