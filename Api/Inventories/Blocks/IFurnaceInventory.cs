using SkyBots.Api.Inventories.Enums;
using SkyBots.Api.Worlds.Data;

namespace SkyBots.Api.Inventories.Blocks;

public interface IFurnaceInventory : IInventory<IFurnace>, IBlockInventory, IFunctionalInventory<FurnaceSlot>;