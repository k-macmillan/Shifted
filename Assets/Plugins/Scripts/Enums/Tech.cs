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
        ANCIENT = 100,
        MEDIEVAL = 200,
        INDUSTRIAL = 300,
        PREMODERN = 400,
        MODERN = 500,
        FUTURE = 600,
        WASTELAND = 700,
    }
}

