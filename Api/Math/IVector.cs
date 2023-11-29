using System.Numerics;

namespace SkyBots.Api.Math;

public interface IVector<T> where T : INumber<T>
{
    public int Dimension { get; }
    public T[] AsArray();
}