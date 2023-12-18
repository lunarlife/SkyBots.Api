using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Events.Bots;

namespace SkyBots.Api.Components.Entities.Bots.Respawn;

public class TaskBotRespawnEventArgs : TaskBotEventArgs
{
    public TaskBotRespawnEventArgs(Bot bot, SkyTask task) : base(bot, task)
    {
    }
}