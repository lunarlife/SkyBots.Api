using SkyBots.Api.Events.Inventories.SlotChange;
using Undefined.Events;

namespace SkyBots.Api.Components.Inventories;

public interface IStorageInventory : IInventory
{
    public int Width { get; }
    public int Height { get; }

    
    public ItemStack this[int x, int y] { get; }
    public new IEventAccess<StorageInventorySlotChangeEventArgs> OnSlotChange { get; }
    IEventAccess<InventorySlotChangeEventArgs> IInventory.OnSlotChange => OnSlotChange;
}