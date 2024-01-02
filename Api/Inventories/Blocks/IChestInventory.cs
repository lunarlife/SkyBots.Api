using SkyBots.Api.Worlds.Data;

namespace SkyBots.Api.Inventories.Blocks;

public interface IChestInventory : IInventory<IChest>, IStorageInventory, IBlockInventory, IFunctionalInventory;