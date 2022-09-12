using System;


namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            char simbol;
            int counter = 1;

            while (true)
            {

                Console.Clear();
                Console.WriteLine("\t\tКалькулятор");
                Console.WriteLine("Итерация " + counter);
                try
                {
                    Console.WriteLine("Введите первое число");
                    firstValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    secondValue = double.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат ввода данных");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Введите символоперации ( + , - , / или * )");
                simbol = char.Parse(Console.ReadLine());

                switch (simbol)
                {
                    case '+':
                        Console.WriteLine("Сумма чисел " + firstValue + " и " + secondValue + " равна " + (firstValue + secondValue));
                        break;
                    case '-':
                        Console.WriteLine("Разность чисел " + firstValue + " и " + secondValue + " равна " + (firstValue - secondValue));
                        break;
                    case '/':
                        if (secondValue == 0)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine("Частное чисел " + firstValue + " и " + secondValue + " равно " + (firstValue / secondValue));
                        break;
                    case '*':
                        Console.WriteLine("Произведение чисел " + firstValue + " и " + secondValue + " равно " + (firstValue * secondValue));
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция!!");
                        break;
                }
                Console.ReadLine();
                counter++;

            }
        }
    }
}
