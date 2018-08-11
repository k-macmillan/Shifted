using System.Collections;
using System.Collections.Generic;
using BuildingStyle;
using Common;

/// <summary>
/// Represents a section of land that is marked for residential use. Can have one or many
/// LandLot objects.
/// </summary>
public class Residential {

    public Point2[] Anchors { get; private set; }
    public List<LandLot> LandLots { get; private set; }

    public Residential(Point2 origin)
    {
        SetResidentialLotStyle();
        BuildLandLots();
        
    }
	


    private void SetResidentialLotStyle()
    {
        // Based on landlot properties
        // Given SqFt it could be one of several types
        // Distance from city center will affect this too
    }


    private void BuildLandLots()
    {
        
    }
}
