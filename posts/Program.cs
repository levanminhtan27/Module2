using System;
using System.ComponentModel.Design;
using System.Data;
using System.Runtime.CompilerServices;

namespace posts
{
    class Program
    {
        public static Forum GetForum = new Forum();
        public static void Menu()
        {
            Console.WriteLine("1. Create Post");
            Console.WriteLine("2. Update Post");
            Console.WriteLine("3. Remove Post");
            Console.WriteLine("4. Show Posts");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Rating");
            Console.WriteLine("7. Exit");
           /* int tim = 0;
            tim = Convert.ToInt32(Console.ReadLine());*/
        }
       
        static void Main(string[] args)
        {
            do
            {
                Menu();
                int tim = 0;
                tim = Convert.ToInt32(Console.ReadLine());
                               
                switch (tim)
                {
                    case 1:
                        GetForum.Add();
                        break;
                    case 2:
                        Console.WriteLine("enter id want to update");
                        int getup = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter content to update:");
                        GetForum.Update(getup);
                        break;
                    case 3:
                        Console.WriteLine("enter id to delete");
                        int getRemove = Convert.ToInt32(Console.ReadLine());
                        GetForum.Remove(getRemove);
                        break;
                    case 4:
                        Console.WriteLine($"ID\tTitle\tContent\tAuthor\tAverageRate");
                        GetForum.show();
                        break;
                    case 5:
                        Console.WriteLine("enter Title ");
                        string gettitle = Console.ReadLine();
                        GetForum.search(gettitle);
                        break;
                    case 6:
                        Console.WriteLine("enter ID :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter rates:");
                        int rates = Convert.ToInt32(Console.ReadLine());
                       
                        for (int i =0; i< rates; i++) 
                        {
                            Console.WriteLine($"enter rate {i+1} " );
                            int rating = Convert.ToInt32(Console.ReadLine());
                            GetForum.Rating(id, rating);
                        }

                        break;
                    case 7:
                        Console.WriteLine("exit....");
                        Environment.Exit(0);
                        break;
                }
            } 
            while (true);
        }
    }
}
