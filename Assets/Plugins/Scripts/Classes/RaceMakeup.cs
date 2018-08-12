
/// <summary>
/// Stores makeup of race for the region
/// </summary>
public class RaceMakeup  {

    // Pulled from: https://en.wikipedia.org/wiki/Race_and_ethnicity_in_the_United_States
    public float White { get; set; } = 0.63f;           // 17.1% German, 12% Irish
    public float Black { get; set; } = 0.126f;
    public float Asian { get; set; } = 0.048f;          // Includes those from India
    public float NativeAmerican { get; set; } = 0.011f; // Includes Hawaiians    
    public float TwoRaces { get; set; } = 0.029f;
    public float Other { get; set; } = 0.062f;
    public float Hispanic { get; set; } = 0.094f;       // Scalped from White


    /// <summary>
    /// Takes a WorldCulture and generates a race makeup based on the culture.
    /// </summary>
    /// <param name="culture">Primary culture of this race</param>
    public RaceMakeup(Culture.WorldCulture culture)
    {
        // Takes the "world culture" and generates a race makeup based on culture
    }

    /// <summary>
    /// Takes a WorldCulture and generates a race makeup based on the culture.
    /// </summary>
    /// <param name="PlayerSeed">Uses PlayerSeed to generate a race makeup</param>
    public RaceMakeup(int PlayerSeed)
    {
        // Takes the player seed and generates a race makeup
    }

    public override string ToString()
    {
        return "RaceMakeup:" +
            "\nWhite:         " + White +
            "\nBlack:         " + Black +
            "\nAsian:         " + Asian +
            "\nNativeAmrcn:   " + NativeAmerican +
            "\nTwoRaces:      " + TwoRaces +
            "\nOther:         " + Other +
            "\nHispanic:      " + Hispanic;        
    }
}
