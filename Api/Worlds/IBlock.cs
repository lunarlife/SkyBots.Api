using SkyBots.Api.Mathematics;
using SkyBots.Api.Worlds.Data;

namespace SkyBots.Api.Worlds;

public interface IBlock
{
    public IWorld World { get; }
    public Vector3<int> Position { get; }
    public Material Type { get; }
    public IBlockData? Data { get; }
    public IBlock Copy();
}