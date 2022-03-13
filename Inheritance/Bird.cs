using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird: Animal
    {
         
        public bool CanFly { get; set; } 
        public string WingColor { get; set; }
        public bool Migrates { get; set; }
        public double BeakLength { get; set; }
    }
}
