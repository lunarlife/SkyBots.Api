using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Events.Inventories.SlotChange;
using SkyBots.Api.Inventories.Tasks;
using Undefined.Events;

namespace SkyBots.Api.Inventories;

public interface IBotInventory : IInventory<Bot>, IStorageInventory
{
    public int ActiveSlot { get; set; }
    public new IEventAccess<BotInventorySlotChangeEventArgs> OnSlotChange { get; }
    IEventAccess<StorageInventorySlotChangeEventArgs> IStorageInventory.OnSlotChange => OnSlotChange;
    public IInventoryMoveSlotTask Move(int source, int target, int count);
}