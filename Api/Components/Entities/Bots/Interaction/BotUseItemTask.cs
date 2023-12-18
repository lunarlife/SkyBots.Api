using SkyBots.Api.Components.Entities.Bots.Interaction.Events;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.Interaction;

public abstract class BotUseItemTask : BotInteractTask
{
    public abstract override IEventAccess<BotUseItemCompletedEventArgs> OnCompleted { get; }
}