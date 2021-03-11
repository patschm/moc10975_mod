using System;
using System.Collections.Generic;
using System.Text;

namespace TekenProgramma
{
    class Canvas
    {
        private List<Figuur> figuren = new List<Figuur>();

        public void Refresh()
        {
            foreach(Figuur f in figuren)
            {
                f.Teken();
            }
        }
        public void Add(Figuur figuur)
        {
            figuren.Add(figuur);
        }
    }
}
