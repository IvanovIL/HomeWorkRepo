using System;

namespace DZ11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 задание
            ComparablePair<int,int> comparablePairFirst = new ComparablePair<int, int>(userInput(),userInput());
            ComparablePair<int, int> comparablePairSecond = new ComparablePair<int, int>(userInput(), userInput());

            Console.WriteLine($"{comparablePairFirst.First} , {comparablePairFirst.Second} \n" +
                $"{comparablePairSecond.First} , {comparablePairSecond.Second}");
            if (comparablePairFirst.CompareTo(comparablePairSecond) == 0)
            {
                Console.WriteLine("Пары равны");
            }
            if (comparablePairFirst.CompareTo(comparablePairSecond) == 1)
            {
                Console.WriteLine("Первя пара больше");
            }
            if (comparablePairFirst.CompareTo(comparablePairSecond) == -1)
            {
                Console.WriteLine("Вторая пара больше");
            }


            //    //1 задание
            //    Pair<int, string> pair = new Pair<int, string>(68, "Hello, world!");
            //    Console.WriteLine("Pair S = " + pair.intValue +  " Pair T = " + pair.stringValue);
        }
        ////1 задание
        //class Pair<S, T>
        //{
        //    public S intValue;
        //    public T stringValue;
        //    public Pair(S intValue, T stringValue)
        //    {
        //        this.intValue = intValue;
        //        this.stringValue = stringValue;
        //    }
        //}

        // 2 задание
        class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
            where T : IComparable<T>
            where U : IComparable<U>
        {
            public T first;
            public U second;

            public T First
            {
                get
                {
                    return first;
                }
                set
                {
                    first = value;
                }
            }
            public U Second
            {
                get
                {
                    return second;
                }
                set
                {
                    second = value;
                }
            }

            public ComparablePair(T first, U second)
            {
                First = first;
                Second = second;
            }

            public int CompareTo(ComparablePair<T, U>? other)
            {
                if (other == null)
                {
                    return 1;
                }

                int Comparison = First.CompareTo(other.First);
                if (Comparison != 0)
                {
                    return Comparison;
                }

                return Second.CompareTo(other.Second);
            }

        }
        public static int userInput()
        {
            int user;
            Console.WriteLine("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out user))
            {
                Console.Clear();
                Console.WriteLine("Ошибка!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Введите число: ");
            }
            Console.Clear();
            return user;
        }
    }
}
