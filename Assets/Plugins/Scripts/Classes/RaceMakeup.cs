using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using static Common.Extensions;

/// <summary>
/// Stores makeup of race for the region
/// </summary>
public class RaceMakeup  {

    private SystemRandomSource randSeed;
    //private DiscreteUniform uniformDist;


    private int Seed { get; set; }

    public float White { get; protected set; }
    public float Black { get; protected set; }
    public float Asian { get; protected set; }
    public float NativeAmerican { get; protected set; }
    public float Hispanic { get; protected set; }
    



    public RaceMakeup(int seed)
    {
        // Takes the "world culture" and generates a race makeup based on culture
        Seed = seed;
        SetRaceMakup();
    }


    private void SetRaceMakup()
    {
        var properties = this.GetType().GetProperties();
        List<PropertyInfo> attribs = new List<PropertyInfo>(properties.Length);

        foreach (var prop in properties)
        {
            if (prop.PropertyType == typeof(float))
            {
                attribs.Add(prop);
            }
        }
        randSeed = new SystemRandomSource(Seed);

        ShuffleSetValue(ref attribs);
    }

    private void ShuffleSetValue(ref List<PropertyInfo> list)
    {
        // Shuffle attributes around
        list.Shuffle(randSeed);
        var dist = GetNormalDistribution(randSeed);
        for (int i = 0; i < list.Count; ++i)
        {
            list[i].SetValue(this, dist[i]);
        }
    }

    private void PrintAttribs()
    {
        var newProperties = GetType().GetProperties();
        foreach (PropertyInfo p in newProperties)
        {
            Debug.Log("A: " + p.Name + "\tValue: " + p.GetValue(this).ToString());
        }
    }

    public override string ToString()
    {
        return "RaceMakeup:" +
            "\n\tWhite:         " + White +
            "\n\tBlack:         " + Black +
            "\n\tAsian:         " + Asian +
            "\n\tNativeAmrcn:   " + NativeAmerican +
            "\n\tHispanic:      " + Hispanic;        
    }
}
