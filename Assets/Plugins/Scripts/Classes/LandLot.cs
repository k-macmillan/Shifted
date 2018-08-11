using Common;
using System;
using System.Linq;

public class LandLot {

    // Set Variables

    /// <summary>
    /// 2D point that sets the deterministic seed for this piece of land
    /// </summary>
    public Point2 Origin { get; set; }

    // Deterministic Variables

    /// <summary>
    /// The anchors for this plot of land to be drawn a-> b-> c-> d->...-> a
    /// </summary>
    public Point2[] Anchors { get; private set; }

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
    public LandLot(Point2 origin)
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
        
        SqFt = Math.Abs(points.Take(points.Length - 1)
           .Select((p, i) => (points[i + 1].X - p.X) * (points[i + 1].Y + p.Y))
           .Sum() / 2);
    }

    

}
