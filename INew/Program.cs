using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;

namespace INew
{
    class Program
    {

        static void Main(string[] args)
        {
            News[] newslist = new News[0];
            int[] RateList = new int[3];

            int tim = 0;
            do
            {
                Console.WriteLine("1 insert news");
                Console.WriteLine("2 view list ");
                Console.WriteLine("3 average rate");
                Console.WriteLine("4 exit");

                tim = Convert.ToInt32(Console.ReadLine());               
                switch (tim)
                {
                    case 1:
                        Console.WriteLine("enter Title");
                        string title = Console.ReadLine();
                        Console.WriteLine("enter PublishDate");
                        string publishdate = Console.ReadLine();
                        Console.WriteLine("enter Author");
                        string author = Console.ReadLine();
                        Console.WriteLine("enter Content");
                        string content = Console.ReadLine();
                        Console.WriteLine("enter rate1");
                        int rate1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter rate2");
                        int rate2 = Convert.ToInt32(Console.ReadLine()) ;
                        Console.WriteLine("enter rate3");
                        int rate3 = Convert.ToInt32(Console.ReadLine());

                        RateList[0] = rate1;
                        RateList[1] = rate2;
                        RateList[2] = rate3;

                        News news2 = new News(title, publishdate, author, content);
                        news2.Calculate(RateList);

                        Array.Resize(ref newslist, newslist.Length + 1);
                        newslist[newslist.Length - 1] = news2;
                        break;
                    case 2:
                        foreach (var thangdien in newslist)
                        {
                            thangdien.DisPlay();
                        }
                        break;
                    case 3:
                        foreach(News item in newslist)
                        {
                            Console.WriteLine(item.AverageRate);
                        }
                        break;
                    case 4 :
                        Console.WriteLine("tam biet nhe");
                        Environment.Exit(0);
                        break;
                    default :
                        Console.WriteLine("nhap lai");
                        break;
                }
            } while (true);
        }
    }
    
}
