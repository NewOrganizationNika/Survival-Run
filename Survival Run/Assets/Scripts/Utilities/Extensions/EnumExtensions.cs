namespace Utilities.Extensions
{
    public static class EnumExtensions
    {
        public static T Loop<T>(this T element) where T : System.Enum
        {
            var e = (int) (System.IConvertible) element;
            ++e;
            if (e >= System.Enum.GetNames(typeof(T)).Length) e = 0;
            element = (T) (e as System.IConvertible);
            return element;
        }

        public static UnityEngine.Vector2Int PositionValue(this Direction value)
        {
            switch (value)
            {
                case Direction.UP:
                    return new UnityEngine.Vector2Int(0, 1);
                case Direction.RIGHT:
                    return new UnityEngine.Vector2Int(1, 0);
                case Direction.DOWN:
                    return new UnityEngine.Vector2Int(0, -1);
                case Direction.LEFT:
                    return new UnityEngine.Vector2Int(-1, 0);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }

        public static Direction Opposite(this Direction value)
        {
            switch (value)
            {
                case Direction.UP:
                    return Direction.DOWN;
                case Direction.RIGHT:
                    return Direction.LEFT;
                case Direction.DOWN:
                    return Direction.UP;
                case Direction.LEFT:
                    return Direction.RIGHT;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}