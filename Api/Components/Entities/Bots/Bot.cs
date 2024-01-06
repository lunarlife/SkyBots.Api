using SkyBots.Api.Bots;
using SkyBots.Api.Components.Entities.Bots.Interaction;
using SkyBots.Api.Components.Entities.Bots.Respawn;
using SkyBots.Api.Components.Entities.World;
using SkyBots.Api.Entities;
using SkyBots.Api.Events.Bots;
using SkyBots.Api.Events.Inventories;
using SkyBots.Api.Events.World;
using SkyBots.Api.Inventories;
using SkyBots.Api.Mathematics;
using SkyBots.Api.Worlds;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots;

public abstract class Bot : Component, IInventoryHolder<IBotInventory>
{
    public abstract IEventAccess<BotRespawnEventArgs> OnRespawn { get; }
    public abstract IEventAccess<BotBoundChangeEventArgs> OnBoundChange { get; }
    public abstract IEventAccess<BotHurtEventArgs> OnHurt { get; }
    public abstract IEventAccess<BlockBreakEventArgs> OnBreakBlock { get; }
    public abstract IEventAccess<BotLevelChangeEventArgs> OnLevelChange { get; }
    public abstract IEventAccess<BlockPlaceEventArgs> OnPlaceBlock { get; }
    public abstract IEventAccess<InventoryOpenEventArgs> OnInventoryOpen { get; }
    public abstract IEventAccess<InventoryCloseEventArgs> OnInventoryClose { get; }
    public bool IsAlive => Entity.AliveStatus == AliveStatus.Alive;
    public abstract int Level { get; }
    public abstract float Health { get; }
    public abstract float Food { get; }
    public abstract float Vitality { get; }
    public abstract bool IsFree { get; }
    public abstract IInventory? OpenedInventory { get; }
    public abstract BotNumber Number { get; }
    public abstract string Name { get; set; }
    public abstract bool IsBound { get; }
    public abstract IBotInventory Inventory { get; }

    public abstract bool CanInteract(Vector3<int> position);
    public abstract Task<BotBindResult> Bind(string displayName);
    public abstract void Unbind();
    public abstract IRespawnTask Respawn();
    public abstract bool TryRespawn(out IRespawnTask? task);
    public abstract void SetRotation(View view);
    public abstract IBlockBreakTask BreakBlock(Vector3<int> target);
    public abstract IBlockBreakTask BreakBlock(Vector3<int> target, int slot);
    public abstract IBlockPlaceTask PlaceBlock(Vector3<int> target, int slot);
    public abstract IBlockPlaceTask PlaceBlock(Vector3<int> target, BlockDirection direction);
    public abstract IBlockPlaceTask PlaceBlock(Vector3<int> target, BlockDirection direction, int slot);
    public abstract IBlockPlaceTask PlaceBlock(Vector3<int> target);
    public abstract IBotInteractBlockTask InteractBlock(Vector3<int> target, int slot);
    public abstract IBotInteractBlockTask InteractBlock(Vector3<int> target);
    public abstract IBotUseItemTask UseItem(Vector3<int> target, int slot);
    public abstract IBotUseItemTask UseItem(Vector3<int> target);
    public abstract void CloseInventory();
}