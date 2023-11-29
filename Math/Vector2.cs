using System.Numerics;

namespace SkyBotsApi.Math;

public struct Vector2<T> : IVector<T> where T : INumber<T>
{
    public int Dimension => 2;

    public T X;
    public T Y;

    public Vector2(T x, T y)
    {
        X = x;
        Y = y;
    }

    public T[] AsArray() => new[] { X, Y };

    public T Length()
    {
        return (T)Convert.ChangeType(System.Math.Sqrt(((IConvertible)(X * X + Y * Y)).ToDouble(null)), typeof(T));
    }

    public Vector2<T> Normalized()
    {
        var length = Length();
        return new Vector2<T>(X / length, Y / length);
    }
}