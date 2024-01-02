namespace SkyBots.Api.Inventories.Tasks;

public enum InventoryMoveResult : sbyte
{
    Invalid,
    CountOutOfRange,
    NotOpenedInventory,
    FromSlotOutOfRange,
    ToSlotOutOfRange,
    ItemFromIsNull,
    ItemFromIsNotSimilarItemTo,
    ItemToIsFull,
    Successfully
}