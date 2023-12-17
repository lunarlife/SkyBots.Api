using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Events.Tasks;
using Undefined.Events;

namespace SkyBots.Api.Events.Bots;

public abstract class TaskBotEventArgs : BotEventArgs, ITaskCompletedEventArgs
{
    public SkyTask Task { get; }

    public TaskBotEventArgs(BotComponent bot, SkyTask task) : base(bot)
    {
        Task = task;
    }
}