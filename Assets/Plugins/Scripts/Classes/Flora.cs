
using System;
/// <summary>
/// Represents Flora of a region
/// </summary>
public class Flora  {

	public float Density { get; set; }
    public float Diversity { get; set; }

    /// <summary>
    /// Construct flora class for the particular weather
    /// </summary>
    /// <param name="weather">Weather of the region this flora exists</param>
    public Flora(Weather.Weather weather)
    {
        // Presumaby won't need the weather object after initial setup
    }


    public override string ToString()
    {
        string density = String.Format("\nDensity:   {0:f6}", Density);
        string diversity = String.Format("\nDensity:   {0:f6}", Diversity);

        return "Flora:" +
            density +
            diversity;
    }

}
