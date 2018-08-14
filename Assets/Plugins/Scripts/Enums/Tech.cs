using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}

