using System.Numerics;

namespace SkyBots.Api.Mathematics;

public struct Vector2<T> : IVector<T> where T : INumber<T>
{

    public static readonly Vector2<T> ZERO = new(T.Zero, T.Zero);
    public static readonly Vector2<T> ONE = new(T.One, T.One);
    public static readonly Vector2<T> LEFT = new(-T.One, T.Zero);
    public static readonly Vector2<T> RIGHT = new(T.One, T.Zero);
    public static readonly Vector2<T> UP = new(T.Zero, T.One);
    public static readonly Vector2<T> DOWN = new(T.Zero, -T.One);

    
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
        return (T)Convert.ChangeType(Math.Sqrt(((IConvertible)(X * X + Y * Y)).ToDouble(null)), typeof(T));
    }

    public Vector2<T> Normalized()
    {
        var length = Length();
        return new Vector2<T>(X / length, Y / length);
    }

    public bool Equals(Vector2<T> other) => EqualityComparer<T>.Default.Equals(X, other.X) &&
                                            EqualityComparer<T>.Default.Equals(Y, other.Y);

    public override bool Equals(object? obj) => obj is Vector2<T> other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(X, Y);
    public override string ToString() => $"{{{X:F2};{Y:F2}}}";

    public static bool operator ==(Vector2<T> left, Vector2<T> right) =>
        left.X == right.X && left.Y == right.Y;

    public static bool operator !=(Vector2<T> left, Vector2<T> right) => !(left == right);

    public static implicit operator Vector2<float>(Vector2<T> vector) =>
        new(Convert.ToSingle(vector.X), Convert.ToSingle(vector.Y));

    public static implicit operator Vector2<int>(Vector2<T> vector) =>
        new(Convert.ToInt32(vector.X), Convert.ToInt32(vector.Y));

    public static implicit operator Vector3<T>(Vector2<T> vector) => new(vector.X, vector.Y, T.Zero);
    public static bool operator >(Vector2<T> left, Vector2<T> right) => left.X > right.X || left.Y > right.Y;
    public static bool operator <(Vector2<T> left, Vector2<T> right) => left.X < right.X || left.Y < right.Y;
    public static bool operator <=(Vector2<T> left, Vector2<T> right) => left.X <= right.X || left.Y <= right.Y;
    public static bool operator >=(Vector2<T> left, Vector2<T> right) => left.X >= right.X || left.Y >= right.Y;

    public static Vector2<T> operator +(Vector2<T> left, Vector2<T> right) => new(left.X + right.X, left.Y + right.Y);
    public static Vector2<T> operator -(Vector2<T> left, Vector2<T> right) => new(left.X - right.X, left.Y - right.Y);
    public static Vector2<T> operator -(Vector2<T> vector) => new(-vector.X, -vector.Y);

    public static Vector2<T> operator *(Vector2<T> vector, T scalar) => new(vector.X * scalar, vector.Y * scalar);
    public static Vector2<T> operator *(T scalar, Vector2<T> vector) => new(vector.X * scalar, vector.Y * scalar);
    public static Vector2<T> operator *(Vector2<T> left, Vector2<T> right) => new(left.X * right.X, left.Y * right.Y);

    public static Vector2<T> operator /(Vector2<T> vector, T scalar) => new(vector.X / scalar, vector.Y / scalar);

    public static Vector2<T> operator /(Vector2<T> vector, Vector2<T> divisor) =>
        new(vector.X / divisor.X, vector.Y / divisor.Y);
}