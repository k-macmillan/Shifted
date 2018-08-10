using BuildingStyle;

public class Structure {
    

    /// <summary>
    /// Floor Area Ratio of the structure to the land...restricted by zoning
    /// </summary>
	private float FAR { get; set; }


    /*  Base class so the Styles could be any (modern, ancient, etc.)
     */
    private BuildingStyles Styles {get; set;}

    public Structure(Town town)
    {
        Styles = BuildingStyles.Generate(town.TechLevel);
    }
    
}
