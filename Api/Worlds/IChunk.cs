using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Worlds;

public interface IChunk
{
    public Vector2<int> Position { get; }
    public int X { get; }
    public int Y { get; }
    public IWorld World { get; }
    public IBlock GetBlockAt(int x, int y, int z);
    public IBlock GetBlockAt(Vector3<int> position);
    public bool TryGetBlockAt(Vector3<int> position, out IBlock? block);
    public bool TryGetBlockAt(int x, int y, int z, out IBlock? block);


    public bool FindBlock(Material type, out IBlock? block);
    public bool FindBlock(Predicate<IBlock> predicate, out IBlock? block, bool cutEmptyAreas = true);

    public bool FindBlock(Cube<int> area, Material type, out IBlock? block);
    public bool FindBlock(Cube<int> area, Predicate<IBlock> predicate, out IBlock? block, bool cutEmptyAreas = true);
}