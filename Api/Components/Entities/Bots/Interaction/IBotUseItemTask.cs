using SkyBots.Api.Components.Entities.Bots.TaskMachine;

namespace SkyBots.Api.Components.Entities.Bots.Interaction;

public interface IBotUseItemTask : IBotWorldInteractionTask, ISkyTask<IBotUseItemTask>
{
    public UseItemResult Result { get; }
}