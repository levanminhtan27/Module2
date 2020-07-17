using System;

namespace baitap6
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Rectangle[] hinhs = new Rectangle[2];
            hinhs[0] = new Rectangle(5, 3, "blue");
            hinhs[1] = new Rectangle(1, 2);
            foreach (var hinh in hinhs) 
            {
                Console.WriteLine(hinh.Area());
                if (hinh is IColorable)
                {
                    hinh.HowToColor();
                }
            }*/


            Circle circle = new Circle(5.3);
            Random rnd = new Random();
            Rectangle rectangle = new Rectangle(2.2, 3.2);

            rectangle.HowToColor();
            Console.WriteLine($"dien tich hinh tron truoc khi tang: {Math.Round(circle.Area())}");
            circle.Resize(rnd.Next(1, 100));
            Console.WriteLine($"dien tich hinh tron sau khi tang : {Math.Round(circle.Area())}");

            Console.WriteLine($"chu vi hinh tron truoc khi tang: {Math.Round(circle.Perimeter())}");
            circle.Resize(rnd.Next(1, 100));
            Console.WriteLine($"chu vi hinh tron sau khi tang : {Math.Round(circle.Perimeter())}");

            Console.WriteLine($"dien tich hinh chu nhat truoc khi tang : {Math.Round(rectangle.Area())}");
            rectangle.Resize(rnd.Next(1, 100));
            Console.WriteLine($"dien tich hinh chu nhat sau khi tang : {Math.Round(rectangle.Area())}");


            Console.WriteLine($"chu vi hinh chu nhat truoc khi tang : {Math.Round(rectangle.Perimeter())}");
            rectangle.Resize(rnd.Next(1, 100));
            Console.WriteLine($"chu vi hinh chu nhat sau khi tang : {Math.Round(rectangle.Perimeter())}");
        }
    }
}
