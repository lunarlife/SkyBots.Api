using System.Numerics;

namespace SkyBots.Api.Mathematics;

public static class Mathe
{
    public static bool TryClamp<T>(T value, T min, T max) where T : INumber<T> => Clamp(value, min, max) == value;

    public static bool TryClamp<T>(Vector3<T> value, Vector3<T> min, Vector3<T> max) where T : INumber<T> =>
        Clamp(value, min, max) == value;

    public static bool TryClamp<T>(Vector2<T> value, Vector2<T> min, Vector2<T> max) where T : INumber<T> =>
        Clamp(value, min, max) == value;

    private static T Clamp<T>(T value, T min, T max) where T : INumber<T> =>
        value < min ? min : value > max ? max : value;

    private static Vector2<T> Clamp<T>(Vector2<T> value, Vector2<T> min, Vector2<T> max) where T : INumber<T> =>
        new(Clamp(value.X, min.X, max.X), Clamp(value.Y, min.Y, max.Y));

    private static Vector3<T> Clamp<T>(Vector3<T> value, Vector3<T> min, Vector3<T> max) where T : INumber<T> =>
        new(Clamp(value.X, min.X, max.X), Clamp(value.Y, min.Y, max.Y), Clamp(value.Z, min.Z, max.Z));
}