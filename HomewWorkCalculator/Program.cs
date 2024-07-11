using System;
using System.ComponentModel;
using System.Data;

namespace HomewWorkCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool buttonExit = true;
            decimal secondNumber, firstNumber;
            decimal results = 0;

            while (buttonExit)
            {
                Console.Clear();

                Console.WriteLine("Нажмите 1 что бы выйти из калькулятора");
                string userExit = Console.ReadLine();

                if (Convert.ToInt32(userExit) == 1)
                {
                    buttonExit = false;
                    break;
                }

                try
                {
                    Console.Write("Введите первое число: ");
                    firstNumber = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    secondNumber = Convert.ToDecimal(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Такого числа не существует");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Введите операцию: ");
                string userOper = Console.ReadLine();

                switch (userOper)
                {
                    case "+":
                        results = firstNumber + secondNumber;
                        break;
                    case "-":
                        results = firstNumber - secondNumber;
                        break;
                    case "*":
                        results = firstNumber * secondNumber;
                        break;
                    case "/":
                        results = firstNumber / secondNumber;
                        break;
                    case "%":
                        results = (firstNumber * secondNumber) / 100;
                        break;
                    default:
                        Console.WriteLine("Я не знаю такой операции!");
                        break;

                }
                Console.WriteLine($"Ответ: {results}");
                Console.ReadKey();

            }
        }
    }
}
