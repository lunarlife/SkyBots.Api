using SkyBots.Api.Connection;

namespace SkyBots.Api;

public abstract class SkyProgram
{
    public abstract Token Token { get; }
    public IIsland Island => SkyBots.Implementation.Island;
    public abstract void Init(AuthResult result);
}