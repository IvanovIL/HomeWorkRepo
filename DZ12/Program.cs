using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace DZ12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                switch (Choose())
                {
                    case "1":

                        Registration();
                        break;
                    case "2":
                        Authorization();
                        break;
                    case "3":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }

            }

        }

        public static string Choose()
        {
            string choose;
            Console.Write("Выберите действие\n1 - Регистрация\n2 - Авторизация\n3 - Выход из программы\nВаш выбор: ");
            choose = Console.ReadLine();
            return choose;

        }

        class UserPassword
        {
            string Login;
            string Password;
            string ConfirmPassword;
            public string[] Data;
            public UserPassword(string userLogin, string userPassword, string userConfirmPassword)
            {
                Login = userLogin;
                Password = userPassword;
                ConfirmPassword = userConfirmPassword;
            }
            
        }
        public static void Registration()
        {


            try
            {
                Console.Write("Введите логин в соответствии с инструкцией" +
                           "(он должен быть меньше 20 символов и не должен содержать пробелы): ");
                string userLogin = Console.ReadLine();
                SpaceWord(userLogin);


                Console.WriteLine("-----------------------------------");
                Console.Write("Длина пароля должна быть меньше 20 символов,\n" +
                    "он не должен содержать пробелом и должен содержать хотя бы одну цифру:");
                string password = Console.ReadLine();
                Password(password);

                Console.WriteLine("-----------------------------------");
                Console.Write("Повторите пароль для подтверждения: ");
                string confirmPassword = Console.ReadLine();
                if (confirmPassword == password)
                {
                    Console.WriteLine("Вы успешно зарегистрировались!");

                }
                else
                {
                    Console.WriteLine("Пароль не соответствует требованиям для подтверждения");
                }
                UserPassword userPassword = new UserPassword(userLogin, password, confirmPassword);
                using (StreamWriter streamWriter = new StreamWriter("E:\\login.txt"))
                {

                    streamWriter.WriteLine(userLogin);
                    streamWriter.Close();
                }
                using (StreamWriter streamWriter1 = new StreamWriter("E:\\password.txt"))
                {
                    streamWriter1.WriteLine(password);
                    streamWriter1.Close();

                }
               
            }
            catch (WrongLoginException loginException)
            {
                Console.WriteLine(loginException.Message);

            }
            catch (WrongPasswordException passwordException)
            {
                Console.WriteLine(passwordException.Message);
            }





        }


        public static void SpaceWord(string user)
        {
            var valueWord = user.Split(' ');
            int value = 0;

            foreach (string s in valueWord)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsLetterOrDigit(s[i]))
                    {
                        value++;
                    }
                }
            }
            if (value > 20)
            {
                throw new WrongLoginException("Логин должен быть меньше 20 символов;");
            }
            string[] space = Regex.Split(user, @"' '");

            for (int i = 0; i < space.Length; i++)
            {
                if (space[i].Contains(' '))
                {
                    throw new WrongLoginException("Логин должен быть Без пробелов");
                }
            }
        }
        public static void Password(string password)
        {
            var numbers = password.Split(' ');
            int value = 0;
            int valueDigit = 0;
            foreach (string s in numbers)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsLetterOrDigit(s[i]))
                    {
                        value++;
                    }
                    if (char.IsDigit(s[i]))
                    {
                        valueDigit++;
                    }
                }
            }
            if (valueDigit == 0)
            {
                throw new WrongPasswordException("Пароль должен содержать хотя бы одну цифру;");
            }
            if (value > 20)
            {
                throw new WrongPasswordException("Пароль должен быть меньше 20 символов;");
            }


            string[] space = Regex.Split(password, @"' '");

            for (int i = 0; i < space.Length; i++)
            {
                if (space[i].Contains(' '))
                {
                    throw new WrongPasswordException("Пароль должен быть без пробелов");
                }


            }
        }

        

        public static void Authorization()
        {

            using (StreamReader streamReader = new StreamReader("E:\\login.txt"))
            {
              
                string userLogin = streamReader.ReadLine();
                
                Console.Write("Введите логин: ");
               string login = Console.ReadLine();

                if (login != null)
                {
                    if (login.CompareTo(userLogin) == 0)
                    {

                        Reg();
                    }
                    else
                    {
                        Console.WriteLine("Пользователя с таким логином нет");
                    }
                }

            }

        }

        public static void Reg()
        {
            using (StreamReader streamReader = new StreamReader("E:\\password.txt"))
            {

                string password = streamReader.ReadLine();

                Console.Write("Введите пароль: ");
                string Password = Console.ReadLine();

                if (Password != null)
                {
                    if (Password.CompareTo(password) == 0)
                    {
                        Console.WriteLine("Вы успешно вошли в аккаунт");

                    }
                    else
                    {
                        Console.WriteLine("Пароль не верный");
                    }
                }

            }
        }
    }

}




