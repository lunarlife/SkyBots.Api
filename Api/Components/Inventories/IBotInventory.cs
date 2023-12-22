using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Inventories.Tasks;
using SkyBots.Api.Events.Inventories.SlotChange;
using Undefined.Events;

namespace SkyBots.Api.Components.Inventories;

public interface IBotInventory : IInventory<Bot>, IStorageInventory
{
    public int ActiveSlot { get; set; }
    public new IEventAccess<BotInventorySlotChangeEventArgs> OnSlotChange { get; }
    public IInventoryMoveSlotTask Move(int source, int target, int count);
    IEventAccess<StorageInventorySlotChangeEventArgs> IStorageInventory.OnSlotChange => OnSlotChange;
}