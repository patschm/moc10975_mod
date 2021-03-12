using System;
using System.Collections.Generic;
using System.Text;

namespace Electronica
{
    class DABRadio : Radio
    {
        public string Encoder { get; set; }

        public override void Aan()
        {
            //base.Aan();
            Console.WriteLine($"De DAB radio decodeert de stream via {Encoder}");
        }
    }
}
