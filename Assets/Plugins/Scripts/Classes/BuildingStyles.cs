
namespace BuildingStyle
{

    /*  I've only been aware of Euclidean zoning but apparently performance zoning and incentive zoning. Need 
     *  to explore these when determining the function(s) that will place LandLots.
     *  https://en.wikipedia.org/wiki/Zoning#Types
     */


    public class BuildingStyles
    {
        public Tech.TechLevel TechLevel { get; set; }
        public ResidentialLotStyle ResidentialLotStyle { get; set; }

        public WallExterior WallExterior { get; set; }
        public WallInterior WallInterior { get; set; }
        public Window Window { get; set; }
        public Door Door { get; set; }
        public LightsExterior LightsExterior { get; set; }
        public LightsInterior LightsInterior { get; set; }

        //abstract public int LandLot;
        // etc.

        protected static BuildingStyles Generate(Tech.TechLevel techLevel)
        {
            BuildingStyles retval = null;
            // Example:
            switch (techLevel)
            {
                case Tech.TechLevel.MODERN:
                    retval = new Modern();
                    break;
            }

            return retval;
        }

        

    }

    /// <summary>
    /// Gonna need own class?...zoning can fall under one of three main and several sub classes
    /// </summary>
    public enum Zoning
    {
        RESIDENTIAL,
        COMMERCIAL,
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


    public enum ResidentialLotStyle
    {
        PARK,
        TRAILER,
        TOWNHOUSE,
        SINGLEFAMILY,
        TWOFAMILY,
        THREEFAMILY,
        FOURFAMILY,
    }

    public enum CommercialLotStyle
    {
        RETAIL,         // Chain potential
        RESTAURANT,     // Chain potential
        ENTERTAINMENT,  // Chain potential
        OFFICE,
        HOSPITAL,
        DENTAL,
        CLINIC,         // Potential chain
        NURSINGHOME,
        MOTEL,
        HOTEL,          // Chain
        APARTMENT,
        SKYSCRAPPER,
    }
}