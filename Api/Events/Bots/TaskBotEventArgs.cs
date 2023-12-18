using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Events.Tasks;

namespace SkyBots.Api.Events.Bots;

public abstract class TaskBotEventArgs : BotEventArgs, ITaskCompletedEventArgs
{
    public SkyTask Task { get; }

    public TaskBotEventArgs(Bot bot, SkyTask task) : base(bot)
    {
        Task = task;
    }
}