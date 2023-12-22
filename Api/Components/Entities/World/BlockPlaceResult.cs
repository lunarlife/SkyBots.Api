using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.World;

public enum BlockPlaceResult
{
    LongDistance = WorldInteractionResult.LongDistance,
    NoAccess = WorldInteractionResult.NoAccess,
    Successfully = WorldInteractionResult.Successfully,
    Cancelled = WorldInteractionResult.Cancelled,
    MaterialIsNotBlock = WorldInteractionResult.MaterialIsNotBlock,
    BlockIsNotEmpty = WorldInteractionResult.BlockIsNotEmpty

}