using System;
using MathNet.Numerics.Random;
using MathNet.Numerics.Distributions;
using System.Collections.Generic;

namespace Amiability
{
    public class Amiability
    {
        private SystemRandomSource uniformRandSeed;
        private DiscreteUniform uniformDist;

        private SystemRandomSource binomialRandSeed;
        private Binomial binomialDist = null;

        /// <summary>
        /// Amiability of the Region
        /// </summary>
        public AmiabilityLevel AmiabilityLevel { get; private set; }

        /// <summary>
        /// Sets up distribution
        /// </summary>
        /// <param name="seed">Seed based on player and slice</param>
        public Amiability(int seed)
        {
            SetLevel(seed);
        }

        /// <summary>
        /// Sets this instance's AmiabilityLevel
        /// </summary>
        /// <param name="seed">Seed based on player and slice</param>
        private void SetLevel(int seed)
        {
            uniformRandSeed = new SystemRandomSource(seed);
            binomialRandSeed = new SystemRandomSource(seed);   // Doesn't matter if it's the same seed
            uniformDist = new DiscreteUniform(0, Enum.GetNames(typeof(AmiabilityLevel)).Length - 1, uniformRandSeed);
            AmiabilityLevel = (AmiabilityLevel)uniformDist.Sample();            
        }

        /// <summary>
        /// Gets a list of amiability levels
        /// </summary>
        /// <param name="quantity">How many levels are requested</param>
        /// <returns></returns>
        public List<AmiabilityLevel> GetUniformAmiabilityList(int quantity)
        {
            int[] distArray = new int[quantity];
            uniformDist.Samples(distArray);

            List<AmiabilityLevel> amiabilityList = new List<AmiabilityLevel>(quantity);
            foreach (int value in distArray)
            {
                amiabilityList.Add((AmiabilityLevel)value);
            }
            return amiabilityList;
        }


        /// <summary>
        /// Gets a list of amiability levels "centered" around the passed amiability level
        /// </summary>
        /// <param name="amiabilityLevel">Base amiability level</param>
        /// <param name="quantity">How many levels are requested</param>
        /// <returns></returns>
        public List<AmiabilityLevel> GetBiasedAmiabilityList(AmiabilityLevel amiabilityLevel, int quantity)
        {
            int enumLen = Enum.GetNames(typeof(AmiabilityLevel)).Length;
            int[] distArray = new int[quantity];
            List<AmiabilityLevel> amiabilityList = new List<AmiabilityLevel>(quantity);

            binomialDist = new Binomial(0.5d, enumLen - 1, binomialRandSeed);            
            binomialDist.Samples(distArray);
            
            foreach (int value in distArray)
            {
                amiabilityList.Add((AmiabilityLevel)Math.Max(0, Math.Min(value + (int)amiabilityLevel - enumLen/2, enumLen - 1)));                
            }
            return amiabilityList;
        }


        public static Tuple<double, double> GetDistributionAlphaBeta(AmiabilityLevel amiabilityLevel)
        {
            // Beta distribution shape params
            double a = 0.0d;
            double b = 0.0d;

            switch (amiabilityLevel)
            {
                case AmiabilityLevel.HOSTILE:
                    a = 1.0d;
                    b = 100.0d;
                    break;
                case AmiabilityLevel.UNFRIENDLY:
                    a = 1.5d;
                    b = 6.0d;
                    break;
                case AmiabilityLevel.NEUTRAL:
                    a = 10.0d;
                    b = 10.0d;
                    break;
                case AmiabilityLevel.FRIENDLY:
                    a = 2.0d;
                    b = 1.5d;
                    break;
                case AmiabilityLevel.VERYFRIENDLY:
                    a = 5.0d;
                    b = 1.0d;                    
                    break;
                default:
                    a = 0.0001d;
                    b = 1000.0d;
                    break;
            }
            return Tuple.Create(a, b);
        }

    }

    /// <summary>
    /// Amiability level of an object
    /// </summary>
    public enum AmiabilityLevel
    {        
        HOSTILE,
        UNFRIENDLY,
        NEUTRAL,
        FRIENDLY,
        VERYFRIENDLY,
    }
}
