using System;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    private const int RandomIntCount = 50;
    private const int RandomDoubleCount = 50;
    private int RndIntIndex = 0;
    private int RndDblIndex = 0;
    private System.Random rndInts;
    private System.Random rndDbls;

    public Int32[] RandomInts { get; private set; }
    public double[] RandomDouble { get; private set; }



    public Player()
    {
        RandomInts = new Int32[RandomIntCount];
        RandomDouble = new double[RandomDoubleCount];
        rndInts = new System.Random(42);
        rndDbls = new System.Random(42);


        for (int i = 0; i < RandomDoubleCount; ++i)
        {
            RandomDouble[i] = rndDbls.NextDouble();
        }
        
        for (int i = 0; i < RandomIntCount; ++i)
        {
            RandomInts[i] = rndInts.Next();            
        }

        

    }


    /// <summary>
    /// Gets a random integer from the buffer. Replenishes pool when it runs out.
    /// </summary>
    /// <returns>Random integer</returns>
    public Int32 GetRandomInt()
    {
        if (RndIntIndex == RandomIntCount)
        {
            RndIntIndex = 0;
            for (int i = 0; i < RandomIntCount; ++i)
            {
                RandomInts[i] = rndInts.Next();
            }
            Debug.LogWarning("REPLENISHED INTEGER POOL");
        }
        return RandomInts[RndIntIndex++];
    }

    /// <summary>
    /// Gets a random double from the buffer. Replenishes pool when it runs out.
    /// </summary>
    /// <returns>Random double</returns>
    public double GetRandomDouble()
    {
        if (RndDblIndex == RandomDoubleCount)
        {
            RndDblIndex = 0;
            for (int i = 0; i < RandomDoubleCount; ++i)
            {
                RandomDouble[i] = rndDbls.NextDouble();
            }
            Debug.LogWarning("REPLENISHED DOUBLE POOL");
        }
        return RandomDouble[RndDblIndex++];
    }
}
