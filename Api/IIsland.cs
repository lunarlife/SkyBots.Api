using SkyBots.Api.Entities;

namespace SkyBots.Api;

public interface IIsland
{
    public IReadOnlyList<IEntity> Bots { get; }
    public IReadOnlyList<IEntity> BoundBots { get; }
    public IReadOnlyList<IEntity> FreeBots { get; }
}