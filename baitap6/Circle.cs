using System;
using System.Collections.Generic;
using System.Text;

namespace baitap6
{
    class Circle : Resizeable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
       public double Radius
        {
            get=> radius;
            set => radius = value;
        }
        public double Area()
        {
            return radius * radius * Math.PI;
        }
        public double Perimeter()
        {
            return radius * Math.PI * 2;
        }

        public void Resize(double percent)
        {
            radius+=(radius * percent) / 100;
        }
    }


}
