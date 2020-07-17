using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace posts
{
    class Program
    {
        public static Forum GetForum = new Forum();
        static void Main(string[] args)
        {
            do
            {
                int tim = 0;
                Console.WriteLine("enter 1 Create Post");
                Console.WriteLine("enter 2 Update Post");
                Console.WriteLine("enter 3 Remove Post");
                Console.WriteLine("enter 4 Show Posts");
                Console.WriteLine("enter 5 Search");
                Console.WriteLine("enter 6 Rating");
                Console.WriteLine("enter 7 Exit");
                tim = Convert.ToInt32(Console.ReadLine());
                
                switch (tim)
                {
                    case 1:
                        GetForum.Add();
                        break;
                    case 2:
                        Console.WriteLine("enter id update");
                        int getup = Convert.ToInt32(Console.ReadLine());
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
                        Console.WriteLine("enter ratting");
                        int rating= Convert.ToInt32(Console.ReadLine());
                        GetForum.Rating(id, rating);
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
