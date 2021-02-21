namespace Utilities.Extensions
{
    public static class VectorExtensions
    {
        public enum XYZ
        {
            X,
            Y,
            Z,
            XY,
            YZ,
            XZ,
            XYZ,
        }

        /// <summary>
        /// Extension for UnityEngine.Vector3 to compare 2 Vector3 to each other.
        /// Parameters are:
        /// other -> Vector3 to Compare;
        /// XYZ -> To which Axis or link of Axes to compare (Optional, default - XYZ)
        /// IsEqual -> do you want equality or not (Optional, default - true)
        /// </summary>
        /// <param name="value">This Vector3</param>
        /// <param name="other">Vector3 to Compare</param>
        /// <param name="xyz">Axis or link of Axes to compare (Optional, default - XYZ)</param>
        /// <param name="isEqual">GreaterAndEqual or only Greater (Optional, default - true)</param>
        /// <returns>boolean of the comparision result</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public static bool IsGreaterOrEqual(this UnityEngine.Vector3 value, UnityEngine.Vector3 other,
                                            XYZ xyz = XYZ.XYZ, bool isEqual = true)
        {
            switch (xyz)
            {
                case XYZ.X:
                    return isEqual ? value.x >= other.x : value.x > other.x;
                case XYZ.Y:
                    return isEqual ? value.y >= other.y : value.y > other.y;
                case XYZ.Z:
                    return isEqual ? value.z >= other.z : value.z > other.z;
                case XYZ.XY:
                    return isEqual ? value.x >= other.x && value.y >= other.y : value.x > other.x && value.y > other.y;
                case XYZ.YZ:
                    return isEqual ? value.y >= other.y && value.z >= other.z : value.y > other.y && value.z > other.z;
                case XYZ.XZ:
                    return isEqual ? value.x >= other.x && value.z >= other.z : value.x > other.x && value.z > other.z;
                case XYZ.XYZ:
                    return isEqual
                               ? value.x >= other.x && value.y >= other.y && value.z >= other.z
                               : value.x > other.x && value.y > other.y && value.z > other.z;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(xyz), xyz, null);
            }
        }

        /// <summary>
        /// Extension for UnityEngine.Vector3 to compare 2 Vector3 to each other.
        /// Parameters are:
        /// other -> Vector3 to Compare;
        /// XYZ -> To which Axis or link of Axes to compare (Optional, default - XYZ)
        /// IsEqual -> do you want equality or not (Optional, default - true)
        /// </summary>
        /// <param name="value">This Vector3</param>
        /// <param name="other">Vector3 to Compare</param>
        /// <param name="xyz">Axis or link of Axes to compare (Optional, default - XYZ)</param>
        /// <param name="isEqual">LesserAndEqual or only Lesser (Optional, default - true)</param>
        /// <returns>boolean of the comparision result</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public static bool IsLesserOrEqual(this UnityEngine.Vector3 value, UnityEngine.Vector3 other,
                                           XYZ xyz = XYZ.XYZ, bool isEqual = true)
        {
            switch (xyz)
            {
                case XYZ.X:
                    return isEqual ? value.x <= other.x : value.x < other.x;
                case XYZ.Y:
                    return isEqual ? value.y <= other.y : value.y < other.y;
                case XYZ.Z:
                    return isEqual ? value.z <= other.z : value.z < other.z;
                case XYZ.XY:
                    return isEqual ? value.x <= other.x && value.y <= other.y : value.x < other.x && value.y < other.y;
                case XYZ.YZ:
                    return isEqual ? value.y <= other.y && value.z <= other.z : value.y < other.y && value.z < other.z;
                case XYZ.XZ:
                    return isEqual ? value.x <= other.x && value.z <= other.z : value.x < other.x && value.z < other.z;
                case XYZ.XYZ:
                    return isEqual
                               ? value.x <= other.x && value.y <= other.y && value.z <= other.z
                               : value.x < other.x && value.y < other.y && value.z < other.z;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(xyz), xyz, null);
            }
        }

        /// <summary>
        /// Extension for UnityEngine.Vector2 to compare 2 Vector2 to each other.
        /// Parameters are:
        /// other -> Vector2 to Compare;
        /// XYZ -> To which Axis or link of Axes to compare (Optional, default - XY);
        /// IsEqual -> do you want equality or not (Optional, default - true);
        /// PS: Don't choose Z axis it would throw exception.
        /// </summary>
        /// <param name="value">This Vector2</param>
        /// <param name="other">Vector2 to Compare</param>
        /// <param name="xy">Axis or link of Axes to compare (Optional, default - XY)</param>
        /// <param name="isEqual">GreaterAndEqual or only Greater (Optional, default - true)</param>
        /// <returns>boolean of the comparision result</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Don't choose Z axis it would throw exception</exception>
        public static bool IsGreaterOrEqual(this UnityEngine.Vector2 value, UnityEngine.Vector2 other,
                                            XYZ xy = XYZ.XY, bool isEqual = true)
        {
            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (xy)
            {
                case XYZ.X:
                    return isEqual ? value.x >= other.x : value.x > other.x;
                case XYZ.Y:
                    return isEqual ? value.y >= other.y : value.y > other.y;
                case XYZ.XY:
                    return isEqual ? value.x >= other.x && value.y >= other.y : value.x > other.x && value.y > other.y;
                default:
                {
                    UnityEngine.Debug.LogError("It is 2 dimensional vector it doesn't have Z dimension");
                    throw new System.ArgumentOutOfRangeException(nameof(xy), xy, null);
                }
            }
        }

        /// <summary>
        /// Extension for UnityEngine.Vector2 to compare 2 Vector2 to each other.
        /// Parameters are:
        /// other -> Vector2 to Compare;
        /// XYZ -> To which Axis or link of Axes to compare (Optional, default - XY);
        /// IsEqual -> do you want equality or not (Optional, default - true);
        /// PS: Don't choose Z axis it would throw exception.
        /// </summary>
        /// <param name="value">This Vector2</param>
        /// <param name="other">Vector2 to Compare</param>
        /// <param name="xy">Axis or link of Axes to compare (Optional, default - XY)</param>
        /// <param name="isEqual">LesserAndEqual or only Lesser (Optional, default - true)</param>
        /// <returns>boolean of the comparision result</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Don't choose Z axis it would throw exception</exception>
        public static bool IsLesserOrEqual(this UnityEngine.Vector2 value, UnityEngine.Vector2 other,
                                           XYZ xy = XYZ.XY, bool isEqual = true)
        {
            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (xy)
            {
                case XYZ.X:
                    return isEqual ? value.x <= other.x : value.x < other.x;
                case XYZ.Y:
                    return isEqual ? value.y <= other.y : value.y < other.y;
                case XYZ.XY:
                    return isEqual ? value.x <= other.x && value.y <= other.y : value.x < other.x && value.y < other.y;
                default:
                {
                    UnityEngine.Debug.LogError("It is 2 dimensional vector it doesn't have Z dimension");
                    throw new System.ArgumentOutOfRangeException(nameof(xy), xy, null);
                }
            }
        }
    }
}