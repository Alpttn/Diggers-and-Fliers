using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers {
    public class Parakeet : IFlying, IWalking
    {
        public int MaxFlyingSpeed { get; set; }
        public int MaxWalkingSpeed { get; set; }

        public void Move()
        {
            Console.WriteLine("I move like a parakeet");
        }
        public void Fly()
        {
            Console.WriteLine("I fly like a parakeet");
        }
    }
}
