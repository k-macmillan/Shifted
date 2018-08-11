using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public List<LandLot> LandLots { get; private set; }

    // Use this for initialization
    void Start () {
        LandLots = new List<LandLot>();
        LandLots.Add(new LandLot(new Vector2(0.1f, 0.2f)));
        TestAdd();

        foreach (LandLot lot in LandLots)
        {
            Debug.Log("Origin: " + lot.Origin);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void TestAdd()
    {
        LandLots.Add(new LandLot(new Vector2(1.1f, 2.2f)));
        //LandLots[1] = LandLots[0] + LandLots[1];
    }
}
