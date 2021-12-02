using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    public class Mammal : Animal
    {
        public string FurType { get; set; }

        public override string Speak()
        {
            return "growl";
        }

        public override string WhereLives()
        {
            return "on land";
        }
    }
}
