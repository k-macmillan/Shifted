
using System;
/// <summary>
/// Represents Fauna of a region
/// </summary>
public class Fauna  {
    
    public float Density { get; set; }
    public float Diversity { get; set; }

    /// <summary>
    /// Construct fauna class for the particular weather
    /// </summary>
    /// <param name="weather">Weather of the region this fauna exists</param>
    public Fauna(Weather.Weather weather)
    {
        // Presumaby won't need the weather object after initial setup
    }

    public override string ToString()
    {
        string density = String.Format("\nDensity:   {0:f6}", Density);
        string diversity = String.Format("\nDensity:   {0:f6}", Diversity);

        return "Fauna:" +
            density +
            diversity;
    }
}
