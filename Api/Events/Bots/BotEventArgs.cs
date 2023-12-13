using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.Internal.TaskMachine;
using SkyBots.Api.Events.Tasks;

namespace SkyBots.Api.Events.Bots;

public class BotEventArgs : ITaskCompletedEventArgs
{
    public BotComponent Bot { get; }

    public BotEventArgs(BotComponent bot, SkyTask task)
    {
        Task = task;
        Bot = bot;
    }

    public SkyTask Task { get; }
}