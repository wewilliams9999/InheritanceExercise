using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile: Animal
    {
        public Reptile()
        {
            IsAlive = true;
            NumberOfLegs = 4;
            Age = 0;
        }
        
        public bool HasScales { get; set; }
        public string Environment { get; set; }
        public string Defense { get; set; }
        public bool CanRegenerateTail { get; set; }
    }
}
