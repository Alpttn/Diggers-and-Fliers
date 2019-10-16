using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers {
    public class AviaryContainer 
    {
        public List<IFlying> AnimalsThatFly { get; set; } = new List<IFlying>();
    }
}