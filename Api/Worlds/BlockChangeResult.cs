namespace SkyBots.Api.Worlds;

public enum BlockChangeResult : sbyte
{
    Invalid,
    IsNotBlock,
    LongDistance,
    NoAccess,
    TypeIsNotBlock,
    NotPlaceInBlock,
    Successfully,
    Cancelled,
}