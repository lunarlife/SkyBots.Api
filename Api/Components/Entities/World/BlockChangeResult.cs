namespace SkyBots.Api.Components.Entities.World;

public enum BlockChangeResult : sbyte
{
    Invalid,
    IsNotBlock,
    LongDistance,
    NoAccess,
    TypeIsNotBlock,
    NotPlaceInBlock,
    Successfully,

    //CLIENT
    Cancelled
}