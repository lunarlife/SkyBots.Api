namespace SkyBots.Api.Components.Inventories.Tasks;

public enum InventoryMoveResult
{
    Invalid,
    CountOutOfRange,
    NotOpenedInventory,
    FromSlotOutOfRange,
    ToSlotOutOfRange,
    ItemFromIsNull,
    ItemFromIsNotSimilarItemTo,
    ItemToIsFull,
    Successfully,
}