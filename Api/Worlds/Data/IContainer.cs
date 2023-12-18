using SkyBots.Api.Components.Inventories;

namespace SkyBots.Api.Worlds.Data;

public interface IContainer : IBlockData, IInventoryHolder
{
    public ContainerState State { get; }
}

public interface IContainer<out TInventory> : IContainer, IInventoryHolder<TInventory> where TInventory : IInventory
{
    public new TInventory? Inventory { get; }
    TInventory IInventoryHolder<TInventory>.Inventory => Inventory!;
}