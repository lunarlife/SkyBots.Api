using SkyBots.Api.Components.Entities;

namespace SkyBots.Api.Components;

public interface IComponentEntry
{
    public Transform Transform { get; }
    public IReadOnlyList<Component> Components { get; }


    public T GetComponent<T>() where T : Component;
    public bool TryGetComponent<T>(out T? component) where T : Component;
    public IEnumerable<T> GetComponents<T>() where T : Component;
    public T GetOrAdd<T>() where T : Component, new();

    public bool HasComponent<T>() where T : Component;

    public T AddComponent<T>() where T : Component, new();
    public Component AddComponent(Type type);
    public bool TryAddComponent<T>(out T? component) where T : Component, new();
    public bool TryAddComponent(Type type, out Component? component);
}