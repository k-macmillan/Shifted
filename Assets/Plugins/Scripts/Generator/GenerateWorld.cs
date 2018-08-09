using System;


public class GenerateWorld {

    private int seed = 0; // Will be set at player creation
    

    // Autoproperties
    public World World { get; }



    public GenerateWorld()
    {
        
        World = new World(seed);
        World.RaceMakeup = new RaceMakeup(World.WorldCulture);
        Generate();

    }
	

    private void Generate()
    {

    }
}
