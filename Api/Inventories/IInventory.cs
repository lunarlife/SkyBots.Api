using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Events.Inventories.SlotChange;
using Undefined.Events;

namespace SkyBots.Api.Inventories;

public interface IInventory
{
    public IEventAccess<InventorySlotChangeEventArgs> OnSlotChange { get; }
    public int Size { get; }
    public IReadOnlyList<Bot> Viewers { get; }
    public IInventoryHolder Holder { get; }
    public InventoryType Type { get; }
    public ItemStack this[int slot] { get; }
}

public interface IInventory<out THolder> : IInventory where THolder : IInventoryHolder
{
    public new THolder Holder { get; }
    IInventoryHolder IInventory.Holder => Holder;
}