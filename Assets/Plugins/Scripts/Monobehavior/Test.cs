using System.Collections.Generic;
using UnityEngine;
using MathNet.Numerics.Distributions;

public class Test : MonoBehaviour {
    public List<LandLot> LandLots { get; private set; }

    // Use this for initialization
    void Start () {
        Amiability.Amiability amiability = new Amiability.Amiability(0); //(int)System.DateTime.Now.Ticks & 0x0000FFFF
        Debug.Log("Level: " + amiability.AmiabilityLevel);

        List<Amiability.AmiabilityLevel> list = amiability.GetAmiabilityList(700);

        foreach (Amiability.AmiabilityLevel lvl in list)
        {
            Debug.Log("Level: " + lvl);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
