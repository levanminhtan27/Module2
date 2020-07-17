using System;
using System.Collections.Generic;
using System.Text;

namespace bai6
{
    public abstract class Animal
    {
        public abstract string MakeSound();
    }

    public interface Edible
    {
        public string HowToEat();
    }
}

