using SkyBots.Api.Components.Inventories.Enums;
using SkyBots.Api.Worlds.Data;

namespace SkyBots.Api.Components.Inventories.Blocks;

public interface IFurnaceInventory : IInventory<IFurnace>, IBlockInventory, IFunctionalInventory<FurnaceSlot>;