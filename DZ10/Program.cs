using System.ComponentModel;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace DZ10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool buttonExit = true;
            decimal secondNumber, firstNumber;
            decimal results = 0;

            Add add= AddFunc;
            Subtraction subtraction = SubtractionFunc;
            Multiplication multiplication = MultiplicationFunc;
            Division division = DivisionFunc;
            Percent percent = PercentFunc;


            while (buttonExit)
            {
                Console.Clear();

                Console.WriteLine("Нажмите 1 что бы выйти из калькулятора или любую другую цифру для продолжнеия");
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

                Console.Write("Введите операцию(+,-,*,/,%): ");
                string userOper = Console.ReadLine();

                switch (userOper)
                {
                    case "+":
                        add(firstNumber,secondNumber);
                        break;
                    case "-":
                        subtraction(firstNumber,secondNumber);
                        break;
                    case "*":
                        multiplication(firstNumber,secondNumber);
                        break;
                    case "/":
                        division(firstNumber,secondNumber);
                        break;
                    case "%":
                        percent(firstNumber,secondNumber);
                        break;
                    default:
                        Console.WriteLine("Я не знаю такой операции!");
                        break;

                }
                
                Console.ReadKey();

            }
        }
        public delegate void Add(decimal firstNumber, decimal secondNumber);
        public delegate void Subtraction(decimal firstNumber, decimal secondNumber);
        public delegate void Multiplication(decimal firstNumber, decimal secondNumber);
        public delegate void Division(decimal firstNumber, decimal secondNumber);
        public delegate void Percent(decimal firstNumber, decimal secondNumber);

        public static void AddFunc(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine("Ответ: " + (firstNumber + secondNumber));
        }
        public static void SubtractionFunc(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine("Ответ: " + (firstNumber - secondNumber));
        }
        public static void MultiplicationFunc(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine("Ответ: " + (firstNumber * secondNumber));
        }
        public static void DivisionFunc(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine("Ответ: " + (firstNumber / secondNumber));
        }
        public static void PercentFunc(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine("Ответ: " + ((firstNumber / secondNumber) / 100));
        }

    }
}
