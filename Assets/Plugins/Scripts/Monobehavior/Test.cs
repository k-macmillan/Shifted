using System.Collections.Generic;
using UnityEngine;
using MathNet.Numerics.Distributions;
using System;
using MathNet.Numerics.Random;

public class Test : MonoBehaviour {
    public List<LandLot> LandLots { get; private set; }

    // Use this for initialization
    void Start () {
        World world = new World((int)DateTime.Now.Ticks & 0x0000FFFF);
        Debug.Log(world.ToString());

        //RaceMakeup raceMakeup = new RaceMakeup((int)DateTime.Now.Ticks & 0x0000FFFF);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
