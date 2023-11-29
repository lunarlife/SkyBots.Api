using System.Numerics;

namespace SkyBotsApi.Math;

public interface IVector<T> where T : INumber<T>
{
    public int Dimension { get; }
    public T[] AsArray();
}