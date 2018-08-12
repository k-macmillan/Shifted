using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;

public class LandLot {

    // Set Variables

    /// <summary>
    /// 2D point that sets the deterministic seed for this piece of land
    /// </summary>
    public Vector2 Origin { get; set; }

    // Deterministic Variables

    /// <summary>
    /// The anchors for this plot of land to be drawn a-> b-> c-> d->...-> a
    /// </summary>
    public List<Vector2> Anchors { get; private set; }

    /// <summary>
    /// Square foot of this LandLot
    /// </summary>
    public double SqFt { get; private set; }

    /// <summary>
    /// Weather or not this plot of land has grass and/or flora
    /// </summary>
    public bool Waterable { get; set; }


    /// <summary>
    /// Constructs a LandLot based on grid location.
    /// </summary>
    /// <param name="origin">"Center" of this LandLot</param>
    public LandLot(Vector2 origin)
    {
        Origin = origin;
        SetAnchors();
    }

    /// <summary>
    /// Uses deterministic function to set anchors based on the Origin. Will include the Anchors[0] twice
    /// </summary>
    private void SetAnchors()
    {
        // Something something convex hull?
        // Might this cause issues where it may clip neighboring landlots? Probably
    }


    /// <summary>
    /// Sets SqFt based on Anchors
    /// </summary>
    private void SetSqFt()
    {
        // https://stackoverflow.com/a/16281192/5492446

        var points = Anchors;
        
        SqFt = Math.Abs(points.Take(points.Count - 1)
           .Select((p, i) => (points[i + 1].x - p.x) * (points[i + 1].y + p.y))
           .Sum() / 2);
    }

    ///// <summary>
    ///// Adds two sections of land that are touching on one side. Not bothering to figure this ugly
    ///// one out until I need it.
    ///// </summary>
    ///// <param name="lhs"></param>
    ///// <param name="rhs"></param>
    ///// <returns></returns>
    //public static LandLot operator +(LandLot lhs, LandLot rhs)
    //{
        
    //    return new LandLot();
    //}

}
