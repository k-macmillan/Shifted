

namespace Common
{
    /// <summary>
    /// Simple 2D point since Vector2 in Unity is bloated.
    /// </summary>
    public class Point2
    {

        public double X { get; set; }
        public double Y { get; set; }
        
        /// <summary>
        /// Empty constructor. Initializes to 0, 0
        /// </summary>
        public Point2() : this(0.0d, 0.0d) { }

        /// <summary>
        /// Constructor with two variables
        /// </summary>
        /// <param name="x">Value to be set for X</param>
        /// <param name="y">Value to be set for Y</param>
        public Point2(double x, double y)
        {
            X = x;
            Y = y;
        }

    }

    /// <summary>
    /// Simple 3D point since Vector3 in Unity is bloated
    /// </summary>
    public class Point3
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        /// <summary>
        /// Empty constructor. Initializes to 0, 0, 0
        /// </summary>
        public Point3() : this(0.0d, 0.0d, 0.0d) { }

        /// <summary>
        /// Constructor with 3 variables
        /// </summary>
        /// <param name="x">Value to be set for X</param>
        /// <param name="y">Value to be set for Y</param>
        /// <param name="z">Value to be set for Z</param>
        public Point3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
