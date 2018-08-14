using Tech;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;

using System;


public class Population  {
    // https://en.wikipedia.org/wiki/World_population_estimates#Historical_population inspiration

    /// <summary>
    /// Population
    /// </summary>
    public UInt64 Pop { get; set; } = 0;
    private Region Region{ get; set; }



    private const UInt64 maxPop = 20000000000;          // 20,000,000,000
    private const UInt64 minPop = 300000000;            // 300,000,000 estimated population at 1 C.E. 1.5% of our maxPop    
    private const float techMultiplier = 0.60f;         // Tech, by far, has the largest impact on population
    private const float amiableMultiplier = 0.285f;     // Friendly societies will have more population than hostile ones
    private const float wealthMultiplier = 0.10f;       // Wealth should influnce max population

    private SystemRandomSource techRandSeed;
    private SystemRandomSource amiableRandSeed;
    private Beta techDist;
    private Beta amiableDist;


    public Population(Region region)
    {
        Region = region;
        Pop = minPop;

        ApplyWealthPop();
        ApplyTechPop();
        ApplyAmiablePop();

    }

    private void ApplyWealthPop()
    {
        Pop += (UInt64)(Region.Wealth.Weight * wealthMultiplier * maxPop);
    }

    private void ApplyTechPop()
    {
        techRandSeed = new SystemRandomSource(Region.Seed);
        Tuple<double, double> alphaBeta = BetaTechDist.GetDistributionAlphaBeta(Region.TechLevel);
        techDist = new Beta(alphaBeta.Item1, alphaBeta.Item2, techRandSeed);
        double techWeight = techDist.Sample();
        Pop += (UInt64)(techWeight * techMultiplier * maxPop);
    }

    private void ApplyAmiablePop()
    {
        amiableRandSeed = new SystemRandomSource(Region.Seed);
        Tuple<double, double> alphaBeta = Amiability.Amiability.GetDistributionAlphaBeta(Region.Amiability.AmiabilityLevel);
        amiableDist = new Beta(alphaBeta.Item1, alphaBeta.Item2, amiableRandSeed);
        double amiableWeight = amiableDist.Sample();
        Pop += (UInt64)(amiableWeight * amiableMultiplier * maxPop);
    }

}
