using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// A World class object
/// </summary>
public class World : Region {
    private const UInt64 maxWorldPop = 20000000000;

    public World(int seed) : base(seed, maxWorldPop)
    {
        Debug.Log(this.ToString());
    }
	
}
