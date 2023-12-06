namespace SkyBots.Api.Server;

public enum AuthResult : sbyte
{
    InvalidPassword,
    IslandNotFound,
    VersionError,
    Successfully,//         <----------
    ServerNotFound,
    ServerNotAnswer

    
}