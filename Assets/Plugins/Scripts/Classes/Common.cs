using MathNet.Numerics.Random;

using System.Collections.Generic;

namespace Common
{
    static class Extensions
    {
        /// <summary>
        /// Shuffles elements in a list
        /// <!-- https://stackoverflow.com/a/1262619/5492446 -->
        /// </summary>
        /// <typeparam name="T">Template type</typeparam>
        /// <param name="list">The list this is called on</param>
        /// <param name="rand">Random source component</param>
        public static void Shuffle<T>(this IList<T> list, SystemRandomSource rand)
        {
            int n = list.Count;
            while (n > 1)
            {
                // Decrements n before evaluating rand.Next
                int k = rand.Next(--n + 1);
                
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        /// <summary>
        /// Gets a normal-like distribution from the 2D array
        /// </summary>
        /// <param name="rand">Random source component</param>
        /// <returns>Array of floats that sum &lt;= 1</returns>
        public static float[] GetNormalDistribution(SystemRandomSource rand)
        {
            
            float[][] ret_val = {
                new float[] { 75.0f, 17.0f, 5.0f, 2.0f, 1.0f },
                new float[] { 68.2f, 27.2f, 4.2f, 0.2f, 0.2f },
                new float[] { 52.6875f, 25.0f, 12.75f, 6.375f, 3.1875f },
                new float[] { 39.4f, 30.0f, 18.4f, 8.8f, 3.4f } };

            return ret_val[rand.Next(ret_val.Length)];
        }
    }
}
