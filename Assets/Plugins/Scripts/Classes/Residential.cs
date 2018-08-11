using System.Collections;
using System.Collections.Generic;
using BuildingStyle;
using Common;

public class Residential : BuildingStyles {

    public LandLot LandLot { get; private set; }


    public Residential(Point2 origin)
    {
        
        LandLot = new LandLot(origin);
        SetResidentialLotStyle();
    }
	


    private void SetResidentialLotStyle()
    {
        // Based on landlot properties
        // Given SqFt it could be one of several types
        // Distance from city center will affect this too
    }
}
