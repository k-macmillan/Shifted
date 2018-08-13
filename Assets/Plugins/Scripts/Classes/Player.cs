using System;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    Int32[] RandomInts { get; set; }
    double[] RandomDouble { get; set; }


    public Player()
    {
        System.Random rnd = new System.Random(42);
        System.Random rnd2 = new System.Random(42);

        int qty = 5;
        RandomInts = new Int32[qty];
        RandomDouble = new double[qty];

        

        for(int i = 0; i < qty; ++i)
        {
            RandomInts[i] = rnd.Next();
            RandomDouble[i] = rnd2.NextDouble();
        }

        for (int i = 0; i < qty; ++i)
        {
            Debug.Log("INT: " + RandomInts[i] % 1000);
        }

        for (int i = 0; i < qty; ++i)
        {
            Debug.Log("DBL: " + RandomDouble[i]);
        }
    }
}
