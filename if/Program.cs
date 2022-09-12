using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
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

                if (simbol == '+')
                {
                    Console.WriteLine("Сумма чисел " + firstValue + " и " + secondValue + " будет равна " + (firstValue + secondValue));
                }
                else if (simbol == '-')
                {
                    Console.WriteLine("Разность чисел " + firstValue + " и " + secondValue + " будет равна " + (firstValue - secondValue));
                }
                else if (simbol == '/')
                {
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine("Частное чисел " + firstValue + " и " + secondValue + " будет равно " + (firstValue / secondValue));
                }
                else if (simbol == '*')
                {
                    Console.WriteLine("Произведение чисел " + firstValue + " и " + secondValue + " будет равно " + (firstValue * secondValue));
                }
                else
                {
                    Console.WriteLine("Неизвестная операция!!");
                }
                Console.ReadLine();
                counter++;

            }
        }
    }
}
