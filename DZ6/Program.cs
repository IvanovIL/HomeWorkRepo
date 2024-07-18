using System.Reflection.Metadata;
using System.Threading.Channels;

namespace DZ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Phone phone1 = new Phone();
            Phone phone2 = new Phone("+7933456363","Sumsung",7);
            Phone phone3 = new Phone("+8983245826","Oppo");

            Console.WriteLine(phone1.GetNumber());
            Console.WriteLine(phone2.GetNumber());
            Console.WriteLine(phone3.GetNumber());

            phone1.receiveCall("Boris");
          
        }
        class Phone
        {
            string numbers;
            string model;
            float weight;

            public Phone()
            {
                numbers = "Uknown numbers";
                model = "Unknown model";
                weight = 7;
            }
            public Phone(string userNumbers, string userModel)
            {
                numbers = userNumbers;
                model = userModel;
                weight = 0;
            }
            public Phone(string userNumbers, string userModel, float phoneWeight)
            {
                numbers = userNumbers;
                model = userModel;
                weight = phoneWeight;
            }

            public void receiveCall(string name)
            {
                Console.WriteLine($"{name} calls");
            }
            public string GetNumber()
            {
                return this.numbers;
            }



        }
            
    }
}
