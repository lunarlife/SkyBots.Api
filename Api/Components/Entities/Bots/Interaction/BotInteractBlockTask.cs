using SkyBots.Api.Components.Entities.Bots.TaskMachine;

namespace SkyBots.Api.Components.Entities.Bots.Interaction;

public interface IBotInteractBlockTask : IBotWorldInteractionTask, ISkyTask<IBotInteractBlockTask>
{
    public BlockInteractResult Result { get; }
}