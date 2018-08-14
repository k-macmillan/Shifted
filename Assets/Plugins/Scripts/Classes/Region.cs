using System;
using UnityEngine;

/// <summary>
/// Stores region information
/// </summary>
abstract public class Region {

    public int Seed { get; private set; } = 42;
    
    /*  Income is a shifted normal distribution (kind of) with a spike at the highest percentage. I struggled to find the raw data so I could draw 
     *  appropriate standard deviation and distribution representation.
     */
    /// <summary>
    /// Median household income
    /// </summary>
    public UInt32 Income { get; set; } = 45000; // https://en.wikipedia.org/wiki/Household_income_in_the_United_States#Household_income_and_demographics (126.22 million households)

    /// <summary>
    /// Natural resources available to a region
    /// </summary>
    public NatResources NatResources { get; set; } = NatResources.NORMAL;

    /// <summary>
    /// Tech level of this region
    /// </summary>
    public Tech.TechLevel TechLevel { get; set; } = Tech.TechLevel.MODERN;

    /// <summary>
    /// Culture type of this region
    /// </summary>
    public Culture.WorldCulture WorldCulture { get; set; } = Culture.WorldCulture.CURRENT;

    /// <summary>
    /// Radians of separation between this region and the center region
    /// </summary>
    public float DistanceFromCenter { get; set; } = 0.0f;

    /// <summary>
    /// Whether or not this is a nuclear wasteland
    /// </summary>
    public bool NuclearWasteland { get; set; } = false;


    /////////////// Requires constructing ///////////////

    /// <summary>
    /// Amiability of the region
    /// </summary>
    public Amiability.Amiability Amiability { get; private set; }

    /// <summary>
    /// Wealth of a region
    /// </summary>
    //public UInt64 Wealth { get; set; } = 100000000000000; // 100 trillion...projected 2025 world wealth
    public Wealth Wealth { get; private set; }

    /// <summary>
    /// Population of the region
    /// </summary>
    public Population Population { get; private set; }

    /// <summary>
    /// Racial makeup of this region
    /// </summary>
    public RaceMakeup RaceMakeup { get; set; }

    /// <summary>
    /// Weather for the region
    /// </summary>
    public Weather.Weather Weather { get; set; }

    /// <summary>
    /// Flora of the region
    /// </summary>
    public Flora Flora { get; set; }

    /// <summary>
    /// Fauna of the region
    /// </summary>
    public Fauna Fauna { get; set; }

    /// <summary>
    /// Represents the slice value [0, 2 * Pi)
    /// </summary>
    public double Slice { get; set; }

    public Region(int seed)
    {
        Seed = seed;
        MockInstantiate(100000000000000);
    }

    /// <summary>
    /// This is a mock function. 
    /// </summary>    
    virtual public void MockInstantiate(UInt64 maxWealth)
    {
        /**** ORDER IS ESSENTIAL ****/
        Amiability = new Amiability.Amiability(Seed);       // Will have a bearing on TechLevel
        TechLevel = Tech.TechLevel.MODERN;                  // Need to determine how to set this
        Wealth = new Wealth(Seed, TechLevel, maxWealth);    // Dependent on TechLevel
        
        Population = new Population(this);                  // Dependent on Tech, Amiability, and Wealth

        RaceMakeup = new RaceMakeup(WorldCulture);
        Weather = new Weather.Weather();
        Flora = new Flora(Weather);
        Fauna = new Fauna(Weather);
    }

    public override String ToString()
    {
        string pop = String.Format("\nPopulation:    {0:N0}", Population.Pop);
        string wealth = String.Format("\nWealth:        ${0:N2}", Wealth.RegionWealth);
        string income = String.Format("\nIncome:        ${0:N2}", Income);
        string distance = String.Format("\nDistFrmCntr:   {0:f6}", DistanceFromCenter);

        string printstr = "Region Information:" +
            pop +
            wealth +
            income +
            "\nAmiability:    " + Amiability.AmiabilityLevel +
            "\nNatResources:  " + NatResources +
            "\nTechLevel:     " + TechLevel +
            "\nWorldCulture:  " + WorldCulture +
            distance + 
            "\nNclrWstlnd:    " + NuclearWasteland +
            "\n" + RaceMakeup.ToString() +
            "\n" + Weather.ToString() +
            "\n" + Flora.ToString() + 
            "\n" + Fauna.ToString();

        return printstr;
    }

}
