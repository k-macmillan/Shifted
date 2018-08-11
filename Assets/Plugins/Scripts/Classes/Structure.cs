using BuildingStyle;

/// <summary>
/// Structures are built on a LandLot. 
/// </summary>
public class Structure : BuildingStyles {
    
    /// <summary>
    /// Reference to the land which this structure sits on
    /// </summary>
    public LandLot LandLot { get; private set; }

    /// <summary>
    /// Floor Area Ratio of the structure to the land...restricted by zoning
    /// </summary>
	private float FAR { get; set; }


    /*  Base class so the Styles could be any (modern, ancient, etc.)
     */
    private BuildingStyles Styles {get; set;}

    public Structure(Town town, LandLot landLot)
    {
        LandLot = landLot;
        Styles = Generate(town.TechLevel);
    }
    
}
