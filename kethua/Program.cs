using System;

namespace kethua
{
    class Program
    { 
        static void Main(string[] args)
        {
            Shape shape = new Shape("red",true);
            Console.WriteLine(shape.InFor());
            
        }
    }
}
