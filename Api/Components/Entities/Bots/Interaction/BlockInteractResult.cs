using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.Bots.Interaction;

public enum BlockInteractResult
{
    LongDistance = WorldInteractionResult.LongDistance,
    NoAccess = WorldInteractionResult.NoAccess,
    Successfully = WorldInteractionResult.Successfully,
    Cancelled = WorldInteractionResult.Cancelled,
    BlockNotInteractable = WorldInteractionResult.BlockNotInteractable
}