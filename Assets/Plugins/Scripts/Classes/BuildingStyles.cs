using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuildingStyle
{
    public class BuildingStyles
    {
        public static BuildingStyles Generate(Tech.TechLevel techLevel)
        {
            BuildingStyles retval = null;
            // Example:
            switch (techLevel)
            {
                case Tech.TechLevel.MODERN:
                    retval =  new Modern();
                    break;
            }

            return retval;
        }


    }

    public enum WallExterior
    {
        STYLE0,
        STYLE1,
        STYLE2,
        // etc.
    }

    public enum WallInterior
    {
        STYLE0,
        STYLE1,
        STYLE2,
        // etc.
    }

    public enum Window
    {
        STYLE0,
        STYLE1,
        STYLE2,
        // etc.
    }

    public enum Door
    {
        STYLE0,
        STYLE1,
        STYLE2,
        // etc.
    }

    public enum LightsExterior
    {
        STYLE0,
        STYLE1,
        STYLE2,
        // etc.
    }

    public enum LightsInterior
    {
        STYLE0,
        STYLE1,
        STYLE2,
        // etc.
    }


    // etc.
}