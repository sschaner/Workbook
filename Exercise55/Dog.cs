using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    public class Dog : Mammal
    {
        // Every dog will say "woof"
        public sealed override string Speak()
        {
            return "woof";
        }
    }
}
