using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers {
    public class Terrapin : ISwimming, IWalking
    {
        public int MaxWalkingSpeed { get; set; }
        public int MaxDepth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Move()
        {
            Console.WriteLine("I move like a Terrapin");
        }

        public void Swim()
        {
            Console.WriteLine("I swim like a Terrapin");
        }
    }
}