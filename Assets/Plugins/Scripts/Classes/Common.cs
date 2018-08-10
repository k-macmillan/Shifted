using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    /// <summary>
    /// Simple 2D point since Vector2 in Unity is bloated.
    /// </summary>
    public struct Point2
    {
        public double X { get; set; }
        public double Y { get; set; }

    }

    /// <summary>
    /// Simple 3D point since Vector3 in Unity is bloated
    /// </summary>
    public struct Point3
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
