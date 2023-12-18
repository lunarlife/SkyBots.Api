using SkyBots.Api.Bots;
using SkyBots.Api.Components.Entities.Bots.Interaction;
using SkyBots.Api.Components.Entities.Bots.Respawn;
using SkyBots.Api.Components.Entities.World;
using SkyBots.Api.Components.Inventories;
using SkyBots.Api.Events.Bots;
using SkyBots.Api.Events.Inventories;
using SkyBots.Api.Events.World;
using SkyBots.Api.Mathematics;
using SkyBots.Api.Worlds;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots;

public abstract class Bot : Component, IInventoryHolder<IBotInventory>
{
    public abstract IEventAccess<BotRespawnEventArgs> OnRespawn { get; }
    public abstract IEventAccess<BotHurtEventArgs> OnHurt { get; }
    public abstract IEventAccess<BlockBreakEventArgs> OnBreakBlock { get; }
    public abstract IEventAccess<BotLevelChangeEventArgs> OnLevelChange { get; }
    public abstract IEventAccess<BlockPlaceEventArgs> OnPlaceBlock { get; }
    public abstract IEventAccess<InventoryOpenEventArgs> OnInventoryOpen { get; }
    public abstract IEventAccess<InventoryCloseEventArgs> OnInventoryClose { get; }
    public abstract int Level { get; }
    public abstract float Health { get; }
    public abstract float Food { get; }
    public abstract float Vitality { get; }
    public abstract IInventory? OpenedInventory { get; }
    public abstract BotNumber Number { get; }
    public abstract string Name { get; set; }
    public abstract bool IsBound { get; }
    public abstract IBotInventory Inventory { get; }
    public abstract Task<BotBindResult> Bind(BotBindArgs args);
    public abstract void Unbind();
    public abstract RespawnTask Respawn();
    public abstract bool TryRespawn(out RespawnTask? task);
    public abstract void SetRotation(View view);
    public abstract BlockBreakTask BreakBlock(Vector3<int> target);
    public abstract BlockBreakTask BreakBlock(Vector3<int> target, int slot);
    public abstract BlockPlaceTask PlaceBlock(Vector3<int> target, int slot);
    public abstract BlockPlaceTask PlaceBlock(Vector3<int> target, BlockDirection direction);
    public abstract BlockPlaceTask PlaceBlock(Vector3<int> target, BlockDirection direction, int slot);
    public abstract BlockPlaceTask PlaceBlock(Vector3<int> target);
    public abstract BotInteractBlockTask InteractBlock(Vector3<int> target, int slot);
    public abstract BotInteractBlockTask InteractBlock(Vector3<int> target);
    public abstract BotUseItemTask UseItem(Vector3<int> target, int slot);
    public abstract BotUseItemTask UseItem(Vector3<int> target);
    public abstract void CloseInventory();
}