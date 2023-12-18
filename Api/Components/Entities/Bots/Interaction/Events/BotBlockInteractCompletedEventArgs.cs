using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.Bots.Interaction.Events;

public class BotBlockInteractCompletedEventArgs : BotInteractCompletedEventArgs
{
    public BotBlockInteractCompletedEventArgs(SkyTask task, Bot bot, BlockChangeResult result) : base(task, bot, result)
    {
    }
}