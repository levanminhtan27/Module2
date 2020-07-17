using System;
using System.Collections.Generic;
using System.Text;

namespace baitap6
{
    class Rectangle : Resizeable,IColorable
    {
        private double width;
        private double length;
        private string color = "red";
        
        public Rectangle(double width, double length,string color)
        {
            this.width = width;
            this.length = length;
            this.color = color;
        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
     

        public double Width
        {
            get => width;
            set => width = value;
        }
        public double Length
        {
            get => length;
            set => length = value;
        }
        
        public string Color
        {
            get => color;
            set => color = value;
        }
        public double Area()
        {
            return length * width;
        }
       
        public double Perimeter()
        {
            return 2 * (length + width);
        }

        public void Resize(double percent)
        {
            width += (width * percent) / 100;
            length += (length * percent) / 100;
        }
        public void HowToColor()
        {
            Console.WriteLine($"Color all four sides {color}");
        }
    }
}
