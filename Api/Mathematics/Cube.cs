using System.Numerics;

namespace SkyBots.Api.Mathematics;

public readonly struct Cube<T> where T : INumber<T>
{
    public Vector3<T> Start { get; }
    public Vector3<T> End { get; }

    public Cube(Vector3<T> position, T width, T height, T length)
    {
        Preconditions.MoreZero(width, nameof(width));
        Preconditions.MoreZero(height, nameof(height));
        Preconditions.MoreZero(length, nameof(length));
        Start = position;
        End = new Vector3<T>(position.X + width, position.Y + height, position.Z + length);
    }

    public Cube(Vector3<T> start, Vector3<T> end)
    {
        Start = start;
        End = end;
    }
}