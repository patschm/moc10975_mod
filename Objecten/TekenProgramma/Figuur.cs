using System;
using System.Collections.Generic;
using System.Text;

namespace TekenProgramma
{
    abstract class Figuur
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Teken();
        
    }
}
