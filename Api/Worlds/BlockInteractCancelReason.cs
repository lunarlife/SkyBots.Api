namespace SkyBots.Api.Worlds;

public enum BlockInteractCancelReason : sbyte
{
    Invalid,
    IsNotBlock,
    LongDistance,
    NoAccess,
    TypeIsNotBlock,
    NotPlaceInBlock
}