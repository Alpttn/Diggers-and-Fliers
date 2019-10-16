using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers {
    public class GroundContainer 
    {
        public List<IWalking> AnimalsOnGround { get; set; } = new List<IWalking>();
    }
}