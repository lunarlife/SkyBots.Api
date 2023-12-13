using SkyBots.Api.Bots;
using SkyBots.Api.Components.Inventories;
using SkyBots.Api.Inventories;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Components.Entities.Bots;

public abstract class BotComponent : LivingDataComponent
{
    public abstract Inventory Inventory { get; }
    public abstract BotNumber Number { get; }
    public abstract string Name { get; set; }
    public abstract bool IsBound { get; }
    public abstract Task<BotBindResult> Bind(BotBindArgs args);
    public abstract void Unbind();
    public abstract void Respawn();
    public abstract bool TryRespawn();
    public abstract void BreakBlock(Vector3<int> target);
    public abstract void BreakBlock(Vector3<int> target, int slot);
    public abstract void PlaceBlock(Vector3<int> target, int slot);
    public abstract void PlaceBlock(Vector3<int> target);
}