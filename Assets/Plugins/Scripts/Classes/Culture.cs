using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Culture
{
    class Culture : RaceMakeup
    {
        public CultureType CultureType { get; private set; }

        public Culture(int seed) : base(seed)
        {

        }

    }

    /// <summary>
    /// Enum to represent culture of the world...Needs to be structs?
    /// </summary>
    public enum CultureType
    {
        CURRENT,
        AMERICAN,
        NATIVE,
        BRITISH,
        ASIAN,
        GERMAN,
        AFRICAN,
        MIDDLEEAST,
        WASTELAND,
    }
}
