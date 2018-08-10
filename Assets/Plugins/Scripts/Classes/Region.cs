using System;

/// <summary>
/// Stores region information
/// </summary>
public class Region {
    
    /// <summary>
    /// Population of a region
    /// </summary>
    public UInt64 Population { get; set; }

    /// <summary>
    /// Wealth of a region
    /// </summary>
    public UInt64 Wealth { get; set; }

    /// <summary>
    /// How friendly a region is
    /// </summary>
    public Amiability Amiability { get; set; }

    /// <summary>
    /// Natural resources available to a region
    /// </summary>
    public NatResources NatResources { get; set; }

    /// <summary>
    /// Tech level of this region
    /// </summary>
    public Tech.TechLevel TechLevel { get; set; }

    /// <summary>
    /// Culture type of this region
    /// </summary>
    public Culture.WorldCulture WorldCulture { get; set; }

    /// <summary>
    /// Racial makeup of this region
    /// </summary>
    public RaceMakeup RaceMakeup { get; set; }

    /// <summary>
    /// Flora of the region
    /// </summary>
    public Flora Flora { get; set; }

    /// <summary>
    /// Fauna of the region
    /// </summary>
    public Fauna Fauna { get; set; }

    /// <summary>
    /// Weather for the region
    /// </summary>
    public Weather.Weather Weather { get; set; }

    /// <summary>
    /// Radians of separation between this region and the center region
    /// </summary>
    public float DistanceFromCenter { get; set; }

    /// <summary>
    /// Whether or not this is a nuclear wasteland
    /// </summary>
    public bool NuclearWasteland { get; set; }

}
