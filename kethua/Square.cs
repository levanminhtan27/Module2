using System;
using System.Collections.Generic;
using System.Text;

namespace kethua
{
    class Square:Rectangle
    {
        private double size = 1;
        public Square(double size) : base(size, size)
        {
            this.size = size;
        }
        public double Size
        {
            get => size;
            set => size = value;
        }
        public override double Width
        {
            get => this.size; set => base.Width = this.size;
        }
        public override double Length
        {
            get => this.size; set => base.Length = this.size;
        }
        public override string InFor()
        {
            return $"A Square with side {this.size} {base.InFor()}";
        }
    }
}
