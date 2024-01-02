using SkyBots.Api.Mathematics;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Inventories;

public struct ItemStack
{
    public const int STACK_SIZE = 64;
    private readonly Enchantment[] _enchantments = [];
    private int _count;
    private Material _material;
    public bool IsEmpty => Material == Material.AIR;

    public Material Material
    {
        readonly get => _material;
        set
        {
            _material = value;
            if (_material == Material.AIR) _count = 0;
        }
    }

    public int Count
    {
        readonly get => _count;
        set
        {
            _count = value;
            if (_count == 0) _material = Material.AIR;
        }
    }

    public IReadOnlyList<Enchantment> Enchantments => _enchantments.AsReadOnly();

    public ItemStack(Material material, int count) : this(material, count, Array.Empty<Enchantment>())
    {
    }

    public ItemStack(Material material, int count, Enchantment[] enchantments)
    {
        Material = material;
        Count = count;
    }

    public ItemStack()
    {
        Material = Material.AIR;
    }

    public bool HasSpace(ItemStack stack) => HasSpace(stack, out _);

    public bool HasSpace(ItemStack stack, out int rest)
    {
        rest = 0;
        if (stack.IsEmpty) return false;

        if (!IsEmpty && stack._material != _material) return false;
        if (!stack._material.IsStackable && !IsEmpty) return false;
        rest = Mathe.Clamp(stack._count + _count - STACK_SIZE, 0, STACK_SIZE);
        return rest == 0;
    }

    public static bool operator ==(ItemStack left, ItemStack right) =>
        left._material == right._material && left._count == right._count;

    public static bool operator !=(ItemStack left, ItemStack right) => !(left == right);
    public bool Equals(ItemStack other) => _count == other._count && _material.Equals(other._material);

    public override bool Equals(object? obj) => obj is ItemStack other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(_count, _material);
    public override string ToString() => $"{Material}:{Count}";
}