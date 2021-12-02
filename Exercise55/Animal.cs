using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    public abstract class Animal
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public abstract string Speak();

        public abstract string WhereLives();

    }
}
