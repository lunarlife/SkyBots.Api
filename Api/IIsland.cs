using SkyBots.Api.Entities;
using SkyBots.Api.Math;

namespace SkyBots.Api;

public interface IIsland
{
    public IReadOnlyList<IEntity> Bots { get; }
    public IReadOnlyList<IEntity> BoundBots { get; }
    public IReadOnlyList<IEntity> FreeBots { get; }
    public Vector2<int> Size { get; }
}