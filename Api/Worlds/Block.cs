using SkyBots.Api.Mathematics;
using SkyBots.Api.Worlds.Data;

namespace SkyBots.Api.Worlds;

public struct Block
{
    public IWorld World { get; }
    public Vector3<int> Position { get; }
    public Material Type { get; }
    public IBlockData? Data { get; }

    public Block(IWorld world, Vector3<int> position, Material type, IBlockData? data)
    {
        World = world;
        Position = position;
        Type = type;
        Data = data;
    }
}