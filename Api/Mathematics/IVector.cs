using System.Numerics;

namespace SkyBots.Api.Mathematics;

public interface IVector
{
    public int Dimension { get; }
}

public interface IVector<out T> : IVector where T : INumber<T>
{
    public T[] AsArray();
}