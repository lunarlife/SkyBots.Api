using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.World;

public interface IBlockChangeTask : ISkyTask
{
    public IBlock Old { get; }
    public IBlock Neu { get; }
}