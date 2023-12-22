namespace SkyBots.Api.Worlds;

public enum WorldInteractionResult : sbyte
{
    Invalid,
    NotBlock,
    LongDistance,
    NoAccess,
    MaterialIsNotBlock,
    BlockIsNotEmpty,
    Successfully,
    Cancelled,
    Continue,
    ItemNotUsable,
    ItemNotUsableForThisBlock,
    BlockNotInteractable
}