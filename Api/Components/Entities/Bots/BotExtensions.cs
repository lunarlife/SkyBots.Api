using SkyBots.Api.Exceptions;
using SkyBots.Api.Inventories;
using SkyBots.Api.Jobs.Instructions;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.Bots;

public static class BotExtensions
{
    private static readonly Dictionary<Material, ToolType> Tools = new();
    private static readonly Dictionary<Material, ArmorType> Armors = new();

    static BotExtensions()
    {
        foreach (var type in Enum.GetValues<ToolType>()) AddTo(Tools, type);
        foreach (var type in Enum.GetValues<ArmorType>()) AddTo(Armors, type);
    }


    public static IInstruction?[] TakeTool(this Bot bot, ToolType type, int count = 1)
    {
        if (bot.OpenedInventory is not IFunctionalInventory)
            throw new BotException("Bot have no opened inventory.");
        if (bot.OpenedInventory.Count(type) != count) throw new BotException($"Inventory have no {count} {type}.");
        return bot.TryTakeTool(type, count, out _);
    }

    public static IInstruction?[] TryTakeTool(this Bot bot, ToolType type, int count, out int countTaken)
    {
        if (bot.OpenedInventory is not IFunctionalInventory inventory)
        {
            countTaken = 0;
            return Array.Empty<IInstruction>();
        }

        var instructions = new IInstruction[count];
        var botInventory = bot.Inventory;
        var index = 0;
        for (var i = 0; i < inventory.Size; i++)
        {
            if (!inventory[i].Material.IsTool(type))
                continue;
            if (botInventory.GetFirstEmptySlot() is not { } slot)
                break;
            instructions[index] = inventory.Take(bot, i, slot, 1).WaitJob();
            index++;
            if (index == count) break;
        }

        countTaken = index;
        return instructions;
    }

    public static int Count(this IInventory inventory, ToolType type)
    {
        var count = 0;
        for (var i = 0; i < inventory.Size; i++)
        {
            if (!Tools.TryGetValue(inventory[i].Material, out var toolType) || toolType != type) continue;
            count++;
        }

        return count;
    }

    /// <returns>Null if no empty slot found</returns>
    public static int? GetFirstEmptySlot(this IInventory inventory)
    {
        for (var i = 0; i < inventory.Size; i++)
        {
            if (!inventory[i].IsEmpty) continue;
            return i;
        }

        return null;
    }

    public static int? GetFirstSlot(this IInventory inventory, ToolType type)
    {
        for (var i = 0; i < inventory.Size; i++)
        {
            if (!inventory[i].Material.IsTool(type)) continue;
            return i;
        }

        return null;
    }

    public static int? GetFirstSlot(this IInventory inventory, ArmorType type)
    {
        for (var i = 0; i < inventory.Size; i++)
        {
            if (!inventory[i].Material.IsArmor(type)) continue;
            return i;
        }

        return null;
    }

    public static IInstruction WaitForChange(this IBlock block, Material? material = null)
    {
        var type = block.Type;
        return new WaitBool(() => material is null ? block.Type != type : block.Type == material);
    }

    public static bool IsTool(this Material material, ToolType type) =>
        Tools.TryGetValue(material, out var t) && t == type;

    public static bool IsArmor(this Material material, ArmorType type) =>
        Armors.TryGetValue(material, out var t) && t == type;

    private static void AddTo<T>(Dictionary<Material, T> dictionary, T value) where T : struct, Enum =>
        AddTo(dictionary, value, value.ToString());

    private static void AddTo<T>(Dictionary<Material, T> dictionary, T value, string endOfName) where T : struct, Enum
    {
        foreach (var material in Material.Materials)
            if (material.Name.EndsWith("_" + endOfName, StringComparison.OrdinalIgnoreCase))
                dictionary.Add(material, value);
    }
}