using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    public class Bird : Animal
    {
        public sealed override string Speak()
        {
            return "tweet";
        }

        public override string WhereLives()
        {
            return "land";
        }
    }
}
