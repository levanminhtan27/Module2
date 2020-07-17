using System;
using System.Collections.Generic;
using System.Text;

namespace kethua
{
    class Shape
    {
        private string color = "green";
        private bool filled = true;
        public Shape() { }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;

        }
        public string Color
        {
            get => color;
            set => color = value;
        }
        public bool Filled
        {
            get => filled;
            set => filled = value;
        }
        public virtual string InFor()
        {
            return $"A Shape with color of { color } and {(this.filled ? "filled" : "not filled")}";
        }
    }
}
