using Newtonsoft.Json;

namespace DZ13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Begin();
          
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }

        public static void Input(string chooce)
        {
            bool run = true;

            while (run)
            {
                switch (chooce)
                {
                    case "1":
                        string file = File.ReadAllText("C:\\Users\\Admin\\source\\repos\\HomeWorkRepo\\DZ13\\objects\\file1.json");
                        var json = JsonConvert.DeserializeObject<Person>(file);
                        Console.WriteLine(file);
                        ExaminationFile(file);
                        Console.WriteLine("Нажмите 5 что бы выйти или 6 что бы вернутся в начало");
                        string exit = Console.ReadLine();
                        if (exit == "5")
                        {
                            run = false;
                        }
                        else if (exit == "6")
                        {
                            Console.Clear();
                            Begin();
                        }
                        break;
   
                    case "2":
                        string file2 = File.ReadAllText("C:\\Users\\Admin\\source\\repos\\HomeWorkRepo\\DZ13\\objects\\file2.json");
                        var json2 = JsonConvert.DeserializeObject<Person>(file2);
                        Console.WriteLine(file2);
                        ExaminationFile(file2);
                        Console.WriteLine("Нажмите 5 что бы выйти или 6 что бы вернутся в начало");
                        string exit2 = Console.ReadLine();
                        if (exit2 == "5")
                        {
                            run = false;
                        }
                        else if (exit2 == "6")
                        {
                            Console.Clear();
                            Begin();
                        }
                        break;
                    case "3":
                        string file3 = File.ReadAllText("C:\\Users\\Admin\\source\\repos\\HomeWorkRepo\\DZ13\\objects\\file3.json");
                        var json3 = JsonConvert.DeserializeObject<Person>(file3);
                        Console.WriteLine(file3);
                        ExaminationFile(file3);
                        Console.WriteLine("Нажмите 5 что бы выйти или 6 что бы вернутся в начало");
                        string exit3 = Console.ReadLine();
                        if (exit3 == "5")
                        {
                            run = false;
                        }
                        else if (exit3 == "6")
                        {
                            Console.Clear();
                            Begin();
                        }
                        break;
                    case "4":
                        string file4 = File.ReadAllText("C:\\Users\\Admin\\source\\repos\\HomeWorkRepo\\DZ13\\objects\\file4.json");
                        var json4 = JsonConvert.DeserializeObject<Person>(file4);
                        Console.WriteLine(file4);
                        ExaminationFile(file4);
                        Console.WriteLine("Нажмите 5 что бы выйти или 6 что бы вернутся в начало");
                        string exit4 = Console.ReadLine();
                        if (exit4 == "5")
                        {
                            run = false;
                        }
                        else if (exit4 == "6")
                        {
                            Console.Clear();
                            Begin();
                           
                        }
                        break;
                    case "5":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Нет такого файла!");
                        Console.ReadLine();
                        return; 
                }
            }


        }

        public static void ExaminationFile(string file)
        {
            if (file.Length == 0)
            {
                Console.WriteLine("Файл пуст или не найден");

            }
        }

        public static void Begin()
        {

            try
            {
                Console.WriteLine("Выберите файл: ");
                Console.Write("1 - Первый файл\n2 - Второй файл\n3 - Третий файл\n4 - Четвертый файл\n5 - Выход\nВаш выбор: ");
                string chooce = Console.ReadLine();
                Input(chooce);
            }
            catch (NoJsonException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
