using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers {
    public class Mouse : IWalking, IDigging
    {
        public int MaxWalkingSpeed { get; set; }
        public int BurrowDepth { get; set; }

        public void Dig()
        {
            Console.WriteLine("I dig like a mouse");
        }

        public void Move()
        {
            Console.WriteLine("I move like a mouse");
        }
    }
}