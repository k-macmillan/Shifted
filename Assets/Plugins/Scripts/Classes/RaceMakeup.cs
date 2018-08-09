
/// <summary>
/// Stores makeup of race for the region
/// </summary>
public class RaceMakeup  {

	public float Caucasian { get; set; }
    public float Hispanic { get; set; }
    public float Asian { get; set; }
    public float African { get; set; }
    public float MiddleEastern { get; set; }
    public float NativeAmerican { get; set; }


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
}
