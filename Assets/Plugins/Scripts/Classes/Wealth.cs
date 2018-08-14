using System;
using MathNet.Numerics.Random;
using MathNet.Numerics.Distributions;
using Tech;

/// <summary>
/// Sets wealth for a region
/// </summary>
public class Wealth {

    private SystemRandomSource randSeed;
    private Beta betaDist;

    /// <summary>
    /// Region's wealth
    /// </summary>
    public UInt64 RegionWealth { get; private set; }

    /// <summary>
    /// [0, 1] value used for applying wealth weight to functions
    /// </summary>
    public double Weight { get; private set; }

    /// <summary>
    /// Sets a Region's wealth based on tech level and base region's wealth. Tech level is fed to 
    /// a switch which determines alpha/beta of the Beta distribution. A sample is then called which
    /// is between 0 and 1. That value is then multiplied by the maxWealth to determine the region's 
    /// actual wealth.
    /// </summary>
    /// <param name="seed">Seed based on player and slice</param>
    /// <param name="techLevel">Region's tech level</param>
    /// <param name="maxWealth">Max wealth for this Region</param>
    public Wealth(int seed, TechLevel techLevel, UInt64 maxWealth)
    {
        randSeed = new SystemRandomSource(seed);
        FillDistribution(techLevel);
        Weight = betaDist.Sample();
        RegionWealth = (UInt64)(Weight * maxWealth);
    }

    /// <summary>
    /// Sets up a new Beta distribution based on TechLevel. Each tech level has a specific alpha and 
    /// beta that are hand-tailored to the expected wealth of a region. These distributions are not 
    /// setup based on wealth as percieved at that time but instead as wealth compared to today.
    /// </summary>
    /// <param name="seed">Seed based on player and slice</param>
    /// <param name="techLevel">Region's tech level</param>
    private void FillDistribution(TechLevel techLevel)
    {
        Tuple<double, double> alphaBeta = BetaTechDist.GetDistributionAlphaBeta(techLevel);
        betaDist = new Beta(alphaBeta.Item1, alphaBeta.Item2, randSeed);
    }
}
