using SkyBots.Api.Components.Entities;
using SkyBots.Api.Entities;

namespace SkyBots.Api.Components;

public abstract class Component : IComponentEntry
{
    public IEntity Entity { get; }
    public Transform Transform => Entity.Transform;
    public IReadOnlyList<Component> Components => Entity.Components;

    public T GetComponent<T>() where T : Component => Entity.GetComponent<T>();

    public bool TryGetComponent<T>(out T? component) where T : Component => Entity.TryGetComponent(out component);

    public IEnumerable<T> GetComponents<T>() where T : Component => Entity.GetComponents<T>();

    public T GetOrAdd<T>() where T : Component, new() => Entity.GetOrAdd<T>();

    public bool HasComponent<T>() where T : Component => Entity.HasComponent<T>();

    public T AddComponent<T>() where T : Component, new() => Entity.AddComponent<T>();

    public Component AddComponent(Type type) => Entity.AddComponent(type);

    public bool TryAddComponent<T>(out T? component) where T : Component, new() => Entity.TryAddComponent(out component);

    public bool TryAddComponent(Type type, out Component? component) => Entity.TryAddComponent(type, out component);


    public virtual void OnLoad()
    {
    }

    public virtual void OnUnload()
    {
    }

}