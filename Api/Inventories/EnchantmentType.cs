namespace SkyBots.Api.Inventories;

public readonly struct EnchantmentType
{
    public const int ENCHANTMENTS_COUNT = 39;
    private static readonly EnchantmentType[] Enchantments = new EnchantmentType[ENCHANTMENTS_COUNT];


    public readonly string Name;
    public readonly int Id;
    public readonly int MaxLevel;

    public EnchantmentType(string name, int id, int maxLevel)
    {
        Name = name;
        Id = id;
        MaxLevel = maxLevel;
        Enchantments[id] = this;
    }

    public static EnchantmentType FromId(int id)
    {
        Preconditions.RangeArray(id, ENCHANTMENTS_COUNT);
        return Enchantments[id];
    }

    public static bool operator ==(EnchantmentType left, EnchantmentType right) => left.Id == right.Id;
    public static bool operator !=(EnchantmentType left, EnchantmentType right) => !(left == right);

    public bool Equals(EnchantmentType other) => Id == other.Id;
    public override bool Equals(object? obj) => obj is EnchantmentType other && Equals(other);
    public override int GetHashCode() => Id;

    public static readonly EnchantmentType FIRE_PROTECTION = new("fire_protection", 0, 4);
    public static readonly EnchantmentType SHARPNESS = new("sharpness", 1, 5);
    public static readonly EnchantmentType FLAME = new("flame", 2, 1);
    public static readonly EnchantmentType SOUL_SPEED = new("soul_speed", 3, 3);
    public static readonly EnchantmentType AQUA_AFFINITY = new("aqua_affinity", 4, 1);
    public static readonly EnchantmentType PUNCH = new("punch", 5, 2);
    public static readonly EnchantmentType LOYALTY = new("loyalty", 6, 3);
    public static readonly EnchantmentType DEPTH_STRIDER = new("depth_strider", 7, 3);
    public static readonly EnchantmentType VANISHING_CURSE = new("vanishing_curse", 8, 1);
    public static readonly EnchantmentType UNBREAKING = new("unbreaking", 9, 3);
    public static readonly EnchantmentType KNOCKBACK = new("knockback", 10, 2);
    public static readonly EnchantmentType LUCK_OF_THE_SEA = new("luck_of_the_sea", 11, 3);
    public static readonly EnchantmentType BINDING_CURSE = new("binding_curse", 12, 1);
    public static readonly EnchantmentType FURTUNE = new("fortune", 13, 3);
    public static readonly EnchantmentType PROTECTION = new("protection", 14, 4);
    public static readonly EnchantmentType EFFICIENCY = new("efficiency", 15, 5);
    public static readonly EnchantmentType MENDING = new("mending", 16, 1);
    public static readonly EnchantmentType FROST_WALKER = new("frost_walker", 17, 2);
    public static readonly EnchantmentType LURE = new("lure", 18, 3);
    public static readonly EnchantmentType LOOTING = new("looting", 19, 3);
    public static readonly EnchantmentType PIERCING = new("piercing", 20, 4);
    public static readonly EnchantmentType BLAST_PROTECTION = new("blast_protection", 21, 4);
    public static readonly EnchantmentType SMITE = new("smite", 22, 5);
    public static readonly EnchantmentType MULTISHOT = new("multishot", 23, 1);
    public static readonly EnchantmentType SWIFT_SNEAK = new("swift_sneak", 24, 3);
    public static readonly EnchantmentType FIRE_ASPECT = new("fire_aspect", 25, 2);
    public static readonly EnchantmentType CHANNELING = new("channeling", 26, 1);
    public static readonly EnchantmentType SWEEPING = new("sweeping", 27, 3);
    public static readonly EnchantmentType THORNS = new("thorns", 28, 3);
    public static readonly EnchantmentType BANE_OF_ARTHROPODS = new("bane_of_arthropods", 29, 5);
    public static readonly EnchantmentType RESPIRATION = new("respiration", 30, 3);
    public static readonly EnchantmentType RIPTIDE = new("riptide", 31, 3);
    public static readonly EnchantmentType SILK_TOUCH = new("silk_touch", 32, 1);
    public static readonly EnchantmentType QUICK_CHARGE = new("quick_charge", 33, 3);
    public static readonly EnchantmentType PROJECTILE_PROTECTION = new("projectile_protection", 34, 4);
    public static readonly EnchantmentType IMPALING = new("impaling", 35, 5);
    public static readonly EnchantmentType FEATHER_FALLING = new("feather_falling", 36, 4);
    public static readonly EnchantmentType POWER = new("power", 37, 5);
    public static readonly EnchantmentType INFINITE = new("infinity", 38, 1);
}