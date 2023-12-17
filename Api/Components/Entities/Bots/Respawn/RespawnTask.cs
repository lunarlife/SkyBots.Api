using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.Respawn;

public abstract class RespawnTask : SkyTask
{
    public abstract override IEventAccess<TaskBotRespawnEventArgs> OnCompleted { get; }
}