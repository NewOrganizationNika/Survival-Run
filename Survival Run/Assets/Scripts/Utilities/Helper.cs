using UnityEngine;

namespace Utilities
{
    public static class Helper
    {
        /// <summary>
        /// Checking x or y is outside of 2D array.
        /// Returns True if inside boundaries.
        /// </summary>
        /// <param name="grid">Two Dimensional Array</param>
        /// <param name="x">X Position in array</param>
        /// <param name="y">Y Position in array</param>
        /// <returns>True if inside boundaries</returns>
        // public static bool CheckingFor2DArrayBoundaries(Node[,] grid, int x, int y) =>
        //     !(x >= grid.GetLength(0) ||
        //       y >= grid.GetLength(1) ||
        //       x < 0 || y < 0);
        private static AnimationCurve plot = new AnimationCurve();

        /// <summary>
        /// Debug value change though graphical visual
        /// </summary>
        public static void DebuggerWithGraphVisual(float value)
        {
            plot.AddKey(Time.timeSinceLevelLoad, value);
        }
    }
}