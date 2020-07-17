using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    class Cylinder:Circle
    {
        private double height;
        public Cylinder()
        {

        }
        public Cylinder(double height, double newradius, string newcolor) : base(newradius,newcolor)
        {
            this.height = height;
        }
        public double Height
        {
            get => height;
            set => height = value;
        }
        public double Calculate()
        {
            return Area() * height;
        }
        public override string inf()
        {
            return $"the tich hinh tru la : {Calculate()} {base.inf()}";
        }
    }
   
}
