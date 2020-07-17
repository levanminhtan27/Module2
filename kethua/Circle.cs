using System;
using System.Collections.Generic;
using System.Text;

namespace kethua
{
    class Circle:Shape
    {
        private double radius = 1.0;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string newcolor, bool newfilled) : base(newcolor, newfilled)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public double GetArea()
        {
            return (radius * radius) * Math.PI;
        }
        public double GetPerimeter()
        {
            return (2 * radius * Math.PI);
        }
        // ghi đè lên 1 phương thức InFor
        public override string InFor()
        {
            return $"A Circle with radius: {this.radius} {base.InFor()}";
        }
    }
}
