using UnityEngine;

public class Town : Region{

    /// <summary>
    /// Reference to World
    /// </summary>
    private World World { get; set; }
    /// <summary>
    /// Density of buildings...this will need to be an NxN matrix?
    /// </summary>
    public float BuildingDensity { get; set; }

    public Common.Point2 CityCenter { get; set; }

    /// <summary>
    /// Constructs a Town object based on a World
    /// </summary>
    /// <param name="world">World this town will live in</param>
	public Town(World world)
    {
        World = world;
    }

    private void Generate()
    {

    }

    /// <summary>
    /// Sets up building grid based on world
    /// </summary>
    private void SetBuildingMatrix()
    {

    }

}
