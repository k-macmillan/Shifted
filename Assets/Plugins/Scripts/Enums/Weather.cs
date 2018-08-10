using System;

namespace Weather
{

    /// <summary>
    /// This represents the weather in a specific region
    /// </summary>
    public class Weather
    {
        /// <summary>
        /// Current weather system
        /// </summary>
        public WeatherSystem WeatherSystem { get; private set; }
        

    }


    /// <summary>
    /// This represents a temporary weather system
    /// </summary>
    public class WeatherSystem
    {
        /// <summary>
        /// Weather duration in seconds
        /// </summary>
        public Int32 Duration { get; set; }

        /// <summary>
        /// Constructs a weather system based on current weather.
        /// </summary>
        /// <param name="weather">WeatherSystems are based on current weather</param>
        public WeatherSystem(Weather weather)
        {

        }

    }

    
}
