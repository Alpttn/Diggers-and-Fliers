using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    class Program
    {
        static void Main(string[] args)
        {

        //Before you write any classes for the above animals, determine the common properties and behaviors that some of them share and define interfaces first.
        // Once you believe you have a good set of interfaces, then start creating your specific animal classes and have them implement the appropriate interface.
        // Then define classes to represent the containers that will hold various animals. Each container class should have a single property - a list to hold animal instances.
        // Lastly, in Main() create one (or more if you like) instances of each type of animal and each container. Then add the animals to their corresponding container.
        
            Ant ant1 = new Ant() {
                MaxWalkingSpeed = 20,
                BurrowDepth = 5
            };
            Ant ant2 = new Ant();
            BetaFish betaFish1 = new BetaFish();
            CopperHeadSnake copperHeadSnake1 = new CopperHeadSnake();
            Earthworm earthworm1 = new Earthworm();
            Finch finch1 = new Finch();
            Gerbil gerbil1 = new Gerbil();
            Mouse mouse1 = new Mouse();
            Parakeet parakeet1 = new Parakeet();
            Terrapin terrapin1 = new Terrapin();
            TimberRattlesnake timberRattleSnake1 = new TimberRattlesnake();

           AviaryContainer aviaryContainer = new AviaryContainer();
           aviaryContainer.AnimalsThatFly.Add(finch1);
           aviaryContainer.AnimalsThatFly.Add(parakeet1);

           DirtContainer dirtContainer = new DirtContainer();
           dirtContainer.AnimalsThatDig.Add(ant1);
           dirtContainer.AnimalsThatDig.Add(mouse1);
           dirtContainer.AnimalsThatDig.Add(gerbil1);
           dirtContainer.AnimalsThatDig.Add(earthworm1);


           WaterContainer waterContainer = new WaterContainer();
           waterContainer.AnimalsThatSwim.Add(betaFish1);


           GroundContainer groundContainer = new GroundContainer();
           groundContainer.AnimalsOnGround.Add(terrapin1);
           groundContainer.AnimalsOnGround.Add(timberRattleSnake1);
           groundContainer.AnimalsOnGround.Add(copperHeadSnake1);

        }
    }
}
