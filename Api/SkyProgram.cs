using SkyBots.Api.Core;
using SkyBots.Api.Core.Internal;
using SkyBots.Api.Server;

namespace SkyBots.Api;

public abstract class SkyProgram
{
    public abstract Token Token { get; }
    public abstract string Password { get; }
    public IIsland Island => SkyBotsBase.Implementation.Island;
    public abstract void Init(AuthResult result);
}