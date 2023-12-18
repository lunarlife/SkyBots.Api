using SkyBots.Api.Entities;

namespace SkyBots.Api.Events.Entities;

public class EntityDeadEventArgs : EntityEventArgs
{
    public EntityDeadEventArgs(IEntity entity) : base(entity)
    {
    }
}