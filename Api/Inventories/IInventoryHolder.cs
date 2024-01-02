namespace SkyBots.Api.Inventories;

public interface IInventoryHolder
{
    public IInventory Inventory { get; }
}

public interface IInventoryHolder<out TInventory> : IInventoryHolder where TInventory : IInventory
{
    public new TInventory Inventory { get; }
    IInventory IInventoryHolder.Inventory => Inventory;
}