using System;
namespace Tech
{
    /// <summary>
    /// Tech level of a world. Will not vary between towns in a world
    /// </summary>
    public enum TechLevel
    {
        ANCIENT,        // Which flavor? Native, Greek, Egypt
        MEDIEVAL,       // Swords, horses, filth, religion, castles
        WESTERN,        // Wild wild west
        INDUSTRIAL,     // Early 1900s
        PREMODERN,      // 50s, 60s, 70s, or 80s...whichever people most want to see (probably 50s)
        MODERN,         // Today + 10-20 years
        FUTURE,         // Cyberpunk style
        WASTELAND,      // To be implemented much later
    }

    public static class BetaTechDist
    {
        /// <summary>
        /// Alpha and beta of population/wealth follow similar curves over time. This can be broken apart
        /// later if there is a need for more fidelity. Returns alpha and beta based on the tech level.
        /// </summary>
        /// <param name="techLevel">Region's tech level</param>
        /// <returns>Alpha and Beta</returns>
        public static Tuple<double, double> GetDistributionAlphaBeta(TechLevel techLevel)
        {
            // Beta distribution shape params
            double a = 0.0d;
            double b = 0.0d;

            switch (techLevel)
            {
                case TechLevel.ANCIENT:
                    a = 0.5d;
                    b = 200.0d;
                    break;
                case TechLevel.MEDIEVAL:
                    a = 1.5d;
                    b = 150.0d;
                    break;
                case TechLevel.INDUSTRIAL:
                    a = 2.0d;
                    b = 60.0d;
                    break;
                case TechLevel.WESTERN:         // Same levels as Industrial but totally different setting
                    a = 2.0d;
                    b = 60.0d;
                    break;
                case TechLevel.PREMODERN:
                    a = 8.0d;
                    b = 40.0d;
                    break;
                case TechLevel.MODERN:
                    a = 8.0d;
                    b = 6.4d;
                    break;
                case TechLevel.FUTURE:
                    a = 100.0d;
                    b = 1.0d;
                    break;
                case TechLevel.WASTELAND:       // Larger pop so the cities are amazing
                    a = 6.0d;
                    b = 2.4d;
                    break;
                default:
                    a = 0.0001d;
                    b = 1000.0d;
                    break;
            }
            return Tuple.Create(a, b);
        }
    }
}

