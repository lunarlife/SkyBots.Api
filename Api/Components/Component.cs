using SkyBots.Api.Entities;

namespace SkyBots.Api.Components;

public abstract class Component
{
    public IEntity Entity { get; }

    public virtual void OnLoad()
    {
    }

    public virtual void OnUnload()
    {
    }
}