using System;
using System.Data.Common;
using System.Globalization;
using System.Threading.Channels;

namespace D7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Inventory inventory = new Inventory();
        }
        // решение с помощью классов
        //class Product
        //{
        //    public int price;
        //    public string identifier;
        //    public int amount;

        //    public Product()
        //    {
        //        price = 0;
        //        identifier = string.Empty;
        //        amount = 0;
        //    }

        //    public Product(int priceProduct, string identifierName, int amountValue)
        //    {
        //        price = priceProduct;
        //        identifier = identifierName;
        //        amount = amountValue;
        //    }
        //}

        //class Inventory
        //{



        //    Product apple = new Product(3, "Apple", 10);
        //    Product cherry = new Product(5, "Cherry", 5);
        //    Product chips = new Product(7, "Chips", 8);
        //    Product bread = new Product(15, "Bread", 4);

        //    public Inventory()
        //    {
        //        Product[] products = new Product[] { apple, cherry, chips, bread };

        //        int valueApple = 0;
        //        int valueCherry = 0;
        //        int valueChips = 0;
        //        int valueBread = 0;

        //        for (int i = 0; i < products.Length; i++)
        //        {
        //            Console.WriteLine("Продукт: |" + products[i].identifier + "|" + " Стоимость: |" + products[i].price + "|" +
        //                " Количество: |" + products[i].amount + "|");
        //            Console.WriteLine("Общая стоимость  продукта: " + products[i].price * products[i].amount);
        //            valueApple = products[0].price * products[0].amount;
        //            valueCherry = products[1].price * products[1].amount;
        //            valueChips = products[2].price * products[2].amount;
        //            valueBread = products[3].price * products[3].amount;
        //        }
        //        int result = valueApple + valueCherry + valueChips + valueBread;



        //        Console.WriteLine("Вся стоимость инвентаря - " + result);
        //    }

        //}
        //решение с помощью структур
        struct Product
        {
            public int price;
            public string identifier;
            public int amount;

            public Product()
            {
                price = 0;
                identifier = string.Empty;
                amount = 0;
            }
            public Product(int priceProduct, string identifierName, int amountValue)
            {
                price = priceProduct;
                identifier = identifierName;
                amount = amountValue;
            }
        }

        struct Inventory
        {

            Product pencil;
            Product copyBook;
            Product book;
            Product dictionary;



            public Inventory()
            {
                pencil.price = 4;
                pencil.identifier = "Карандаш";
                pencil.amount = 4;

                copyBook.price = 6;
                copyBook.identifier = "Тетрадь";
                copyBook.amount = 5;

                book.price = 10;
                book.identifier = "Книга";
                book.amount = 2;

                dictionary.price = 8;
                dictionary.identifier = "Словарь";
                dictionary.amount = 10;

                Product[] products = new Product[] { pencil, copyBook, book, dictionary };

                int valuePencil = 0;
                int valueCopyBook = 0;
                int valueBook = 0;
                int valueDictionary = 0;

                for (int i = 0; i < products.Length; i++)
                {

                    Console.WriteLine("Продукт: |" + products[i].identifier + "|" + " Стоимость: |" + products[i].price + "|" +
                        " Количество: |" + products[i].amount + "|");
                    Console.WriteLine("Общая стоимость  продукта: " + products[i].price * products[i].amount);
                    valuePencil = products[0].price * products[0].amount;
                    valueCopyBook = products[1].price * products[1].amount;
                    valueBook = products[2].price * products[2].amount;
                    valueDictionary = products[3].price * products[3].amount;
                }
                int result = valuePencil + valueCopyBook + valueBook + valueDictionary;
                Console.WriteLine("Вся стоимость инвентаря - " + result);
            }
        }


    }
}
