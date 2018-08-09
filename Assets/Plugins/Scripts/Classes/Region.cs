using System;

public class Region {
    
    public UInt64 Population { get; set; }
    public UInt64 Wealth { get; set; }
    public Amiability Amiability { get; set; }
    public NatResources NatResources { get; set; }
    public Tech.TechLevel TechLevel { get; set; }
    public Culture.WorldCulture WorldCulture { get; set; }
    public RaceMakeup RaceMakeup { get; set; }
    public Flora Flora { get; set; }
    public Fauna Fauna { get; set; }

}
