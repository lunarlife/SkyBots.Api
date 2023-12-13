using SkyBots.Api.Bots;
using SkyBots.Api.Inventories;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.Bots;

public abstract class BotComponent : Component
{
    public abstract Inventory Inventory { get; }
    public abstract BotNumber BotNumber { get; }
    public abstract string BotName { get; set; }
    public abstract bool IsBound { get; }
    public abstract Task<BotBindResult> Bind(BotBindArgs args);
    public abstract void Unbind();
    public abstract void BreakBlock(Block block);
    public abstract void PlaceBlock(Block block);
}