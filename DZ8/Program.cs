using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DZ8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Назовите собаку: ");
            Dog dog = new Dog();

            dog.SetName(Console.ReadLine());
            dog.GetName();
            dog.Eat();
        }
        
        abstract class Animal
        {
            string Name = string.Empty;
            public string SetName(string name)
            {
                Name = name;
                return this.Name;
            }
            public void GetName()
            {
                
                Console.WriteLine("Имя собаки " + Name);  
            }

            public abstract void Eat();

        }

        class Dog : Animal
        {
           
            public Dog()
            {
               
                Animal animal;
            }

            public override void Eat()
            {
                Console.WriteLine("Собака ест!");
            }
            

            

        }
    }

}

