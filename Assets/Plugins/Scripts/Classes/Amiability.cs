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
