using SkyBots.Api.Worlds;
using Undefined.Events;

namespace SkyBots.Api.Events.World;

public class WorldBlockChangeEventArgs : IEventArgs
{
    public IWorld World { get; }
    public IBlock Old { get; }
    public IBlock New { get; }

    public WorldBlockChangeEventArgs(IWorld world, IBlock old, IBlock @new)
    {
        World = world;
        Old = old;
        New = @new;
    }
}