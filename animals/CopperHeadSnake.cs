using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers {
    public class CopperHeadSnake : IWalking
    {
        public int MaxWalkingSpeed { get; set; }

        public void Move()
        {
            Console.WriteLine("I move like a CopperHeadsnake");
        }
    }
}