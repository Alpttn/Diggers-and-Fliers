using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers {
    public class Earthworm : IDigging
    {
        public int BurrowDepth { get; set; }

        public void Dig()
        {
            Console.WriteLine("I dig like an Earthworm");
        }
    }
}