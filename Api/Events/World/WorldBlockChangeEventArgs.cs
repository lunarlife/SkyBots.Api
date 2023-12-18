using SkyBots.Api.Worlds;
using Undefined.Events;

namespace SkyBots.Api.Events.World;

public class WorldBlockChangeEventArgs : IEventArgs
{
    public IWorld World { get; }
    public Block Old { get; }
    public Block New { get; }

    public WorldBlockChangeEventArgs(IWorld world, Block old, Block @new)
    {
        World = world;
        Old = old;
        New = @new;
    }
}