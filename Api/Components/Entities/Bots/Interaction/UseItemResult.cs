using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.Bots.Interaction;

public enum UseItemResult
{
    LongDistance = WorldInteractionResult.LongDistance,
    NoAccess = WorldInteractionResult.NoAccess,
    Successfully = WorldInteractionResult.Successfully,
    Cancelled = WorldInteractionResult.Cancelled,
    ItemNotUsable = WorldInteractionResult.ItemNotUsable,
    ItemNotUsableForThisBlock = WorldInteractionResult.ItemNotUsableForThisBlock
}