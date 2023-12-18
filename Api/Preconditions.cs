using System.Numerics;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api;

public static class Preconditions
{
    public static void Range<T>(T value, T min, T max, string? arg = null) where T : INumber<T>
    {
        if (!Mathe.TryClamp(value, min, max))
            throw new ArgumentOutOfRangeException(arg);
    }
    public static void Range<T>(T value, T max, string? arg = null) where T : INumber<T>
    {
        if (!Mathe.TryClamp(value, T.Zero, max))
            throw new ArgumentOutOfRangeException(arg);
    }
 
    public static void Range<T>(Vector2<T> value, Vector2<T> min, Vector2<T> max, string? arg = null)
        where T : INumber<T>
    {
        if (!Mathe.TryClamp(value, min, max))
            throw new ArgumentOutOfRangeException(arg);
    }

    public static void Range<T>(Vector3<T> value, Vector3<T> min, Vector3<T> max, string? arg = null)
        where T : INumber<T>
    {
        if (!Mathe.TryClamp(value, min, max))
            throw new ArgumentOutOfRangeException(arg);
    }

    public static void Argument(bool value, string? message = null)
    {
        if (!value)
            throw new ArgumentException(message);
    }
}