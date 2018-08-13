using System;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    private const int RandomIntCount = 5;
    private const int RandomDoubleCount = 5;

    public Int32[] RandomInts { get; private set; }
    public double[] RandomDouble { get; private set; }


    public Player()
    {

        RandomInts = new Int32[RandomIntCount];
        RandomDouble = new double[RandomDoubleCount];


        System.Random rnd2 = new System.Random(42);
        for (int i = 0; i < RandomDoubleCount; ++i)
        {
            RandomDouble[i] = rnd2.NextDouble();
        }
        System.Random rnd = new System.Random(42);
        for (int i = 0; i < RandomIntCount; ++i)
        {
            RandomInts[i] = rnd.Next();            
        }

        

        //for (int i = 0; i < RandomIntCount; ++i)
        //{
        //    Debug.Log("INT: " + RandomInts[i] % 1000);
        //}

        //for (int i = 0; i < RandomDoubleCount; ++i)
        //{
        //    Debug.Log("DBL: " + RandomDouble[i]);
        //}
    }
}
