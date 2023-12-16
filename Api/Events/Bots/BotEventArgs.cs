using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using Undefined.Events;

namespace SkyBots.Api.Events.Bots;

public class BotEventArgs : IEventArgs
{
    public BotComponent Bot { get; }

    public SkyTask Task { get; }

    public BotEventArgs(BotComponent bot, SkyTask task)
    {
        Task = task;
        Bot = bot;
    }
}