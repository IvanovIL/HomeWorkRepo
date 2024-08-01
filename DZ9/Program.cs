using System.Runtime.CompilerServices;

namespace DZ9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 задача
            Console.Write("Введите количество бензина: ");
            int fuel = int.Parse(Console.ReadLine());
            Sportscar sportsCar = new Sportscar(fuel);

            //2 задача
            //StudentProfessorTest Test = new StudentProfessorTest();
            //Test.Main();


            // 1 задача
            //Debt mortgage = new Debt(120000.0, 1.01);
            //mortgage.PrintBalance();
            //mortgage.WaitOneYear();
            //mortgage.PrintBalance();
            //// Wait 20 years
            //int years = 0;
            //while (years < 20)
            //{
            //    mortgage.WaitOneYear();
            //    years = years + 1;
            //}
            //mortgage.PrintBalance();
        }
        // 1 задача
        //class Debt
        //{
        //    double balance = 0;
        //    double InterestRate = 0;

        //    public Debt(double initialBalance, double initialInterestRate)
        //    {
        //        balance = initialBalance;
        //        InterestRate = initialInterestRate;
        //    }
        //    public void PrintBalance()
        //    {
        //        Console.WriteLine("Текущий баланс: " + balance);
        //    }

        //    public void WaitOneYear()
        //    {
        //        Console.WriteLine("Долг увеличивается: " + (balance *= InterestRate));
        //    }

        //}
        // 2 задача
        //class Person
        //{
        //    public int age = 0;
        //    public void Greet()
        //    {
        //        Console.WriteLine("Здравствуйте");
        //    }

        //    public int SetAge(int Age)
        //    {
        //        age = Age;
        //        return this.age;
        //    }

        //}

        //class Teacher : Person
        //{
        //    public void Explain()
        //    {
        //        Console.WriteLine("Я обьясняю");
        //    }

        //    public void ShowAge()
        //    {
        //        Console.WriteLine("Мой возраст: " + SetAge(age) + " лет");
        //    }
        //}

        //class Student  : Person 
        //{

        //    public void Study()
        //    {
        //        Console.WriteLine("Я учусь");
        //    }
        //    public void ShowAge()
        //    {

        //        Console.WriteLine("Мой возраст: " + SetAge(age) + " лет");
        //    }
        //}

        //class StudentProfessorTest
        //{
        //    public void Main()
        //    {
        //        Person person = new Person();
        //        person.Greet();

        //        Student student = new Student();
        //        int age = int.Parse(Console.ReadLine());
        //        student.SetAge(age);
        //        student.Greet();
        //        student.ShowAge();
        //        student.Study();

        //        Teacher teacher = new Teacher();
        //        int age2 = int.Parse(Console.ReadLine());
        //        teacher.SetAge(age2);
        //        teacher.Greet();
        //        teacher.ShowAge();
        //        teacher.Explain();
        //    }
        //}

        //3 задача
        interface IVehicle
        {

            public void Drive(int fuel)
            {


                if (fuel > 0)
                {

                    Console.WriteLine("Автомобиль движется");
                }
                else
                {
                    Console.WriteLine("Заправка");

                }


            }
            public bool Refuel(int fuel)
            {
                if (fuel == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        abstract class Car : IVehicle
        {



            public Car(int fuel)
            {

                IVehicle transport = this;
                transport.Drive(fuel);
                transport.Refuel(fuel);

            }

        }

        class Sportscar : Car
        {
            public Sportscar(int fuel) : base(fuel)
            {
                if (fuel > 0)
                {
                    Drive(fuel);
                }
                else if (fuel == 0)
                {
                    Refuel(fuel);
                    Drive(fuel);
                }
                else
                {
                    Console.WriteLine("Бензин не может быть в отрицательном количестве");
                }



            }

            public void Drive(int fuel)
            {
                if (fuel > 0)
                {
                    Console.WriteLine("Автомобиль движется");
                }
            }

            public bool Refuel(int fuel)
            {
                Console.WriteLine("Укажиет сколько заправить бензина");
                int valuefuel = int.Parse(Console.ReadLine());
                fuel += valuefuel;
                Drive(fuel);

                return fuel > 0;

            }

        }
        class Truck : Car
        {
            public Truck(int fuel) : base(fuel)
            {
                if (fuel > 0)
                {
                    Drive(fuel);
                }
                else if (fuel == 0)
                {
                    Refuel(fuel);
                    Drive(fuel);
                }
                else
                {
                    Console.WriteLine("Бензин не может быть в отрицательном количестве");
                }



            }

            public void Drive(int fuel)
            {
                if (fuel > 0)
                {
                    Console.WriteLine("Автомобиль движется");
                }
            }

            public bool Refuel(int fuel)
            {
                Console.WriteLine("Укажиет сколько заправить бензина");
                int valuefuel = int.Parse(Console.ReadLine());
                fuel += valuefuel;
                Drive(fuel);

                return fuel > 0;

            }

        }
    }
}

