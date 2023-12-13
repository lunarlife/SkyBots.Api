namespace SkyBots.Api.Server;

public enum AuthResult : sbyte
{
    Invalid,
    InvalidPassword,
    IslandNotFound,
    VersionError,
    Successfully,

    //CLIENT
    ServerNotFound,
    ServerNotAnswer,
    InvalidToken,
    InternalError
}