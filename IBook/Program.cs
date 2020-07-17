using System;
using System.Collections.Generic;
using System.Linq;

namespace IBook
{
    class Program
    {
        public static List<Book> newbook = new List<Book>();
        public static int tangID = 0;
        static void Main(string[] args)
        {
            do
            {
                int tim = 0;
                Console.WriteLine("enter 1 Insert new book");
                Console.WriteLine("enter 2 View list of books");
                Console.WriteLine("enter 3 Average Price");
                Console.WriteLine("enter 4 Exit");
                tim = Convert.ToInt32(Console.ReadLine());
                switch (tim)
                {
                    case 1:
                        enter();
                        break;
                    case 2:
                        show();
                        break;
                    case 3:
                        Average();
                        break;
                    case 4:
                        Console.WriteLine("exit....");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter again");
                        break;
                }
            } while (true);
        }

        public static void enter()

        {
            tangID ++;
            var book = new Book();
            book.ID = tangID;
            Console.WriteLine("enter your name");
            book.name = Console.ReadLine();
            Console.WriteLine("enter PublishDate");
            book.PublishDate =  Console.ReadLine();
            Console.WriteLine("enter Author");
            book.Author = Console.ReadLine();
            Console.WriteLine("enter Language");
            book.Language = Console.ReadLine();
           
            for(int i =0; i< book.PriceList.Length; i++)
            {
                Console.WriteLine("enter price"+(i+1));
                book.PriceList[i] = MustDouble();
            }

            //for (int i = 0; i < book.PriceList.Length; i++)
            //{
            //    Console.Write($" rate {i + 1} :");
            //    book.PriceList[i] = int.Parse(Console.ReadLine());
            //}
            newbook.Add(book);
        }

        public static int MustDouble()
        {
            bool checkstr;
            int Valuedouble;
            do
            {
                checkstr = int.TryParse(Console.ReadLine(),out Valuedouble);
            } while (checkstr==false);
            return Valuedouble;
        }

        public static void show()
        {
            foreach (var books in newbook)
            {
                books.Display();

            }
        }
        
        public static void Average()
        {
            foreach(var item in newbook)
            {
                Console.WriteLine(item.Calculate(item.PriceList));
            }
        }
    }
}
