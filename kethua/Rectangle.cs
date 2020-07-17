using System;
using System.Collections.Generic;
using System.Text;

namespace kethua
{
    class Rectangle:Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public Rectangle()
        {
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string newcolor, bool newfilled) : base(newcolor, newfilled)
        {
            this.width = width;
            this.length = length;
        }
        public virtual double Width
        {
            get => width;
            set => width = value;
        }
        public virtual double Length
        {
            get => length;
            set => length = value;
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return (length + width) * 2;
        }
        public virtual string InFor()
        {
            return $"A Rectangle with width {width} and length {length} {base.InFor()}";
        }
    }
}
