using System.Numerics;

namespace SkyBots.Api.Math;

public struct Vector3<T> : IVector<T> where T : INumber<T>
{
    public int Dimension => 3;

    public T X;
    public T Y;
    public T Z;

    public Vector3(T x, T y, T z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector3(T x, T y) : this(x, y, T.Zero)
    {
    }

    public Vector3(Vector2<T> vec, T z) : this(vec.X, vec.Y, z)
    {
    }

    public Vector3(Vector2<T> vec) : this(vec.X, vec.Y, T.Zero)
    {
    }

    public T[] AsArray() => new[] { X, Y, Z };

    public T Length()
    {
        return (T)Convert.ChangeType(System.Math.Sqrt(((IConvertible)(X * X + Y * Y + Z * Z)).ToDouble(null)),
            typeof(T));
    }

    public Vector3<T> Normalized()
    {
        var length = Length();
        return new Vector3<T>(X / length, Y / length, Z / length);
    }

    public override string ToString() => $"{{{X:F2};{Y:F2};{Z:F2}}}";
}