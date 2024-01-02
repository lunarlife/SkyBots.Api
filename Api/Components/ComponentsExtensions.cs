using SkyBots.Api.Components.Entities.Bots;

namespace SkyBots.Api.Components;

public static class ComponentsExtensions
{
    public static Bot GetBot(this IComponentEntry entry) => entry.GetComponent<Bot>();
}