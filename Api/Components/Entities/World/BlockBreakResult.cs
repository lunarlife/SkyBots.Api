using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.World;

public enum BlockBreakResult
{
    LongDistance = WorldInteractionResult.LongDistance,
    NoAccess = WorldInteractionResult.NoAccess,
    Successfully = WorldInteractionResult.Successfully,
    Cancelled = WorldInteractionResult.Cancelled,
    NotBlock = WorldInteractionResult.NotBlock
}