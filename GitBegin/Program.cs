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

                string firstStringValue = null;
                string secondStringValue = null;        // промежуточные элементы разложеные из пользлвательской строки на отдельные элементы
                string simbolS = null;                  // перенес в тело цикла чтобы при каждой итерации значения сбрасывались


                Console.Clear();
                Console.WriteLine("\t\tКалькулятор");
                Console.WriteLine("Итерация " + counter);



                Console.WriteLine("Введите выражение");
                string expression = Console.ReadLine();


                for (int i = 0; i < expression.Length; i++)                 // первый цикл заполняет промежуточную строку до математического знака
                {
                    if (expression[i] == '/' || expression[i] == '*' || expression[i] == '-' || expression[i] == '+')   // нахождение в теле строки мат. знака и использование его как разделителя
                    {
                        simbolS = Convert.ToString((char)expression[i]);    // присвоение знака к своей переменной

                        for (int k = i + 1; k < expression.Length; k++)       //вложеный цикл стартует с элемента последующего знаку и заполняет оставнимися элементами вторую строку
                        {

                            secondStringValue += Convert.ToString(expression[k]);

                        }
                        break;
                    }
                    firstStringValue += Convert.ToString(expression[i]);    // присвоение строке её значенияпосле if, для того чтобы не было исключения на момент парсинга

                }
                simbol = Convert.ToChar(simbolS);
                firstValue = double.Parse(firstStringValue);                // конвертация промежуточных строк в свои типы данных, с которыми будем работать
                secondValue = double.Parse(secondStringValue);


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
