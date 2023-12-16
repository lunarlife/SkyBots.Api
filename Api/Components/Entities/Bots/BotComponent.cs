using SkyBots.Api.Bots;
using SkyBots.Api.Components.Entities.World;
using SkyBots.Api.Components.Inventories;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Components.Entities.Bots;

public abstract class BotComponent : Transform
{
    public abstract float Health { get; }
    public abstract float Food { get; }
    public abstract Inventory Inventory { get; }
    public abstract BotNumber Number { get; }
    public abstract string Name { get; set; }
    public abstract bool IsBound { get; }
    public abstract Task<BotBindResult> Bind(BotBindArgs args);
    public abstract void Unbind();
    public abstract void Respawn();
    public abstract bool TryRespawn();
    public abstract void Rotate(float newYaw, float newPitch);
    public abstract BlockBreakTask BreakBlock(Vector3<int> target);
    public abstract BlockBreakTask BreakBlock(Vector3<int> target, int slot);
    public abstract BlockPlaceTask PlaceBlock(Vector3<int> target, int slot);
    public abstract BlockPlaceTask PlaceBlock(Vector3<int> target);
}