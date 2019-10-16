using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers {
    public class BetaFish : ISwimming
    {
        public int MaxDepth { get; set; }
        public void Swim()
        {
            Console.WriteLine("I swim like a Beta Fish");
        }
    }
}