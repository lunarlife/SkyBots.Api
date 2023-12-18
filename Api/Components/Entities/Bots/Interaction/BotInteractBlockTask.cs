using SkyBots.Api.Components.Entities.Bots.Interaction.Events;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.Interaction;

public abstract class BotInteractBlockTask : BotInteractTask
{
    public abstract override IEventAccess<BotBlockInteractCompletedEventArgs> OnCompleted { get; }
}