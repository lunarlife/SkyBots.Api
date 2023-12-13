using SkyBots.Api.Inventories;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Worlds;

public struct Block
{
    public IWorld World { get; }
    public Vector3<int> Position { get; }
    public Material Type { get; }

    public Block(IWorld world, Vector3<int> position, Material type)
    {
        World = world;
        Position = position;
        Type = type;
    }
}