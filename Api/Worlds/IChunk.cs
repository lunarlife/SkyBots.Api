using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Worlds;

public interface IChunk
{
    public Vector2<int> Position { get; }
    public int X { get; }
    public int Y { get; }

    public Block GetBlockAt(int x, int y, int z);
    public Block GetBlockAt(Vector3<int> position);
    public bool TryGetBlockAt(Vector3<int> position, out Block block);
    public bool TryGetBlockAt(int x, int y, int z, out Block block);
}