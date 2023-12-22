using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.World;

public interface IBlockChangeTask : ISkyTask
{
    public Block Old { get; }
    public Block Neu { get; }
}