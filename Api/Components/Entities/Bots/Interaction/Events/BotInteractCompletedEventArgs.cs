using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Events.Tasks;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.Bots.Interaction.Events;

public abstract class BotInteractCompletedEventArgs : ITaskCompletedEventArgs
{
    public Bot Bot { get; }
    public BlockChangeResult Result { get; }
    public SkyTask Task { get; }

    public BotInteractCompletedEventArgs(SkyTask task, Bot bot, BlockChangeResult result)
    {
        Task = task;
        Bot = bot;
        Result = result;
    }
}