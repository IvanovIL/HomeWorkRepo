using System.Data;
using System.Net.WebSockets;

namespace DZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;

            while (true)
            {
                Console.WriteLine("Введите количество строк: ");
                var user = Console.ReadLine();
                int.TryParse(user, out rows);

                Console.WriteLine("Введите колество столбцов: ");
                user = Console.ReadLine();
                int.TryParse(user, out columns);

                if (rows != default && columns != default)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
            
            int[,] array = new int[rows, columns];

            Console.WriteLine("Введите элементы в матрицу: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Элемент {i}, {j}");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            Console.WriteLine("Ваша матрица: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("|" + array[i, j] + "|");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Выберите дейсвтие с матрицей: " +
                "\n1 - Найти количество положительных чисел в матрице." +
                "\n2 - Найти количество отрицательных чисел в матрице." +
                "\n3 - Сортировка элементов матрицы построчно (в двух направлениях)." +
                "\n4 - Инверсия элементов матрицы построчно.");

            int value1 = 0;
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (array[i, j] >= 0)
                            {
                                value1++;
                            }
                        }
                    }
                    Console.WriteLine("Количество положительных чисел: " + value1);
                    break;
                case "2":
                    ;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (array[i, j] < 0)
                            {
                                value1++;
                            }
                        }
                    }
                    Console.WriteLine("Количество отрицательных чисел: " + value1);
                    break;
                case "3":
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for( int j =0; j < array.GetLength(1); j++)
                        {
                            for (int k = 0; k < array.GetLength(1) -1; k++)
                            {
                                if (array[i,k ] > array[i, k + 1])
                                {
                                    int temp = array[i, k];
                                    array[i, k] = array[i, k + 1];
                                    array[i, k + 1] = temp;
                                   
                                }
                            }
                        }
                    }

                    Console.WriteLine("Сортировка: ");
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for ( int j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write("|" + array[i, j] + "|");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "4":
                    Console.WriteLine("Инверсия");
                    for (int i = 0; i < array.GetLength(0); i++ )
                    {
                        int str = array.GetLength(1) / 2;
                        for (int j = 0; j < str;j++)
                        {
                            int temp = array[i, j];
                            array[i, j] = array[i, array.GetLength(1) - 1 - j];
                            array[i, array.GetLength(1) - 1 - j] = temp;
                        }
                    }
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write("|" + array[i, j] + "|");
                        }
                        Console.WriteLine();
                    }
                    break;
            }




        }
    }
}
