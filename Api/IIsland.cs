using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Entities;

namespace SkyBots.Api;

public interface IIsland
{
    public IReadOnlyList<Bot> Bots { get; }

    public IReadOnlyList<IEntity> Entities { get; }


    public Bot GetBot(EntityId id);
    public bool TryGetBot(EntityId id, out Bot? bot);

    public IEntity GetEntity(EntityId id);
    public bool TryGetEntity(EntityId id, out IEntity? entity);

    public Bot[] GetFreeBots();
    public Bot[] GetBoundBots();
    public Bot[] GetNotAvailableBots();
}