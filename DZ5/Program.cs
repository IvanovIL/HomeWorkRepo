using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace DZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            string userText;


            while (run)
            {
                Console.Write("Введите текст: ");
                userText = Console.ReadLine();
                Console.WriteLine("Выберите операцию: " +
                    "\n1 - найти слова, содержащие максимальное количество цифр." +
                    "\n2 - найти самое длинное слово и определить, сколько раз оно встретилось в тексте" +
                    "\n3 - заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять»." +
                    "\n4 - вывести на экран сначала вопросительные, а затем восклицательные предложения." +
                    "\n5 - вывести на экран только предложения, не содержащие запятых." +
                    "\n6 - найти слова, начинающиеся и заканчивающиеся на одну и ту же букву." +
                    "\n7 - выход из программы.");
                switch (Console.ReadLine())
                {
                    case "1":
                        MaxNumber(userText);
                        break;
                    case "2":
                        LongWord(userText);
                        break;
                    case "3":
                        ReplaceNumbers(userText);
                        break;
                    case "4":
                        Sign(userText);
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Я не знаю такой операции");
                        break;
                }
                Console.Clear();
            }
        }

        public static void MaxNumber(string userText)
        {
            string[] maxNumber = userText.Split(' ', ',', '.');
            string result = string.Empty;
            int value = 0;
            int maxValue = 0;
            foreach (string number in maxNumber)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (char.IsDigit(number[i]))
                    {
                        value++;
                    }
                }

                for (int i = 0; i < maxNumber.Length; i++)
                {
                    if (maxValue < value)
                    {
                        maxValue = value;
                        result = number;
                    }
                }
                value = 0;
            }

            Console.Clear();
            Console.WriteLine("Слово содержащие самое большое число " + result);
            Console.ReadLine();

        }
        public static void LongWord(string userText)
        {
            string[] longWord = userText.Split(' ', ',', '.');
            string result = string.Empty;
            int value = 0;
            int maxValue = 0;
            int wordCount = 0;
            foreach (string word in longWord)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLetter(word[i]))
                    {
                        value++;
                    }
                }

                for (int i = 0; i < longWord.Length; i++)
                {
                    if (maxValue < value)
                    {
                        maxValue = value;
                        result = word;
                    }
                }
                value = 0;
            }
            foreach (string word in longWord)
            {
                if (word == result)
                {
                    wordCount++;
                }
            }

            Console.Clear();
            Console.WriteLine("Самое длинное слово  " + result + " встретилось " + wordCount + " раз");
            Console.ReadLine();

        }

        public static void ReplaceNumbers(string userText)
        {
            StringBuilder text = new StringBuilder(userText);
            text.Replace("0", "Ноль");
            text.Replace("1", "Один");
            text.Replace("2", "Два");
            text.Replace("3", "Три");
            text.Replace("4", "Четыре");
            text.Replace("5", "Пять");
            text.Replace("6", "Шесть");
            text.Replace("7", "Семь");
            text.Replace("8", "Восемь");
            text.Replace("9", "Девять");

            userText = text.ToString();
            Console.WriteLine($"Результат: {userText}\n");
            Console.ReadLine();
        }
        public static void Sign(string userText)
        {
            string[] signs = Regex.Split(userText, @"(?<=[\.!\?])");

            Console.Write("Вопросительные предложения: ");
            for (int i = 0; i < signs.Length; i++) 
            {

                if (signs[i].Contains('?'))
                {
                    Console.WriteLine(signs[i] + " ");
                }

            }
            Console.Write("Восклицательные предложения: ");
            for (int i = 0;i < signs.Length; i++) 
            {

                if (signs[i].Contains('!'))
                {
                    Console.WriteLine(signs[i] + " ");
                }

            }
            Console.ReadLine();
        }

    }
}
