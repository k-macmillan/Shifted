using System;
using MathNet.Numerics.Random;
using MathNet.Numerics.Distributions;
using System.Collections.Generic;

namespace Amiability
{
    public class Amiability
    {
        private SystemRandomSource randSeed;
        private DiscreteUniform uniformDist;
        
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
            randSeed = new SystemRandomSource(seed);
            uniformDist = new DiscreteUniform(0, Enum.GetNames(typeof(AmiabilityLevel)).Length - 1, randSeed);
            AmiabilityLevel = (AmiabilityLevel)uniformDist.Sample();
        }

        /// <summary>
        /// Gets a list of amiability levels
        /// </summary>
        /// <param name="quantity">How many levels are requested</param>
        /// <returns></returns>
        public List<AmiabilityLevel> GetAmiabilityList(int quantity)
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
