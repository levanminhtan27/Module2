using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    class Circle
    {
        private double radius;
        private string color;
        
        public Circle()
        {

        }
        public Circle (double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double Radius
        {
            get => radius;
            set => radius = value;
        }
        public string Color
        {
            get => color;
            set => color = value;
        }
        public double Area()
        {
            return (radius * radius) * Math.PI;
        }
        public double Perimeter()
        {
            return 2 * radius * Math.PI;
        }
        public virtual string inf()
        {
            return $"dien tich hinh tron la : {Area()} chu vi hinh tron la {Perimeter()} ";
        }
    }
}
