namespace SkyBots.Api.Inventories;

public struct EnchantmentType
{
    public const int ENCHANTMENTS_COUNT = 38;
    private static readonly EnchantmentType[] Enchantments = new EnchantmentType[ENCHANTMENTS_COUNT];
    public string Name { get; }
    public int Id { get; }
    public int MaxLevel { get; }

    public EnchantmentType(string name, int id, int maxLevel)
    {
        Name = name;
        Id = id;
        MaxLevel = maxLevel;
        Enchantments[id] = this;
    }

    public static readonly EnchantmentType PROTECTION_FIRE = new("fire_protection", 0, 4);
    public static readonly EnchantmentType DAMAGE_ALL = new("sharpness", 1, 5);
    public static readonly EnchantmentType ARROW_FIRE = new("flame", 2, 1);
    public static readonly EnchantmentType SOUL_SPEED = new("soul_speed", 3, 3);
    public static readonly EnchantmentType WATER_WORKER = new("aqua_affinity", 4, 1);
    public static readonly EnchantmentType ARROW_KNOCKBACK = new("punch", 5, 2);
    public static readonly EnchantmentType LOYALTY = new("loyalty", 6, 3);
    public static readonly EnchantmentType DEPTH_STRIDER = new("depth_strider", 7, 3);
    public static readonly EnchantmentType VANISHING_CURSE = new("vanishing_curse", 8, 1);
    public static readonly EnchantmentType DURABILITY = new("unbreaking", 9, 3);
    public static readonly EnchantmentType KNOCKBACK = new("knockback", 10, 2);
    public static readonly EnchantmentType LUCK = new("luck_of_the_sea", 11, 3);
    public static readonly EnchantmentType BINDING_CURSE = new("binding_curse", 12, 1);
    public static readonly EnchantmentType LOOT_BONUS_BLOCKS = new("fortune", 13, 3);
    public static readonly EnchantmentType PROTECTION_ENVIRONMENTAL = new("protection", 14, 4);
    public static readonly EnchantmentType DIG_SPEED = new("efficiency", 15, 5);
    public static readonly EnchantmentType MENDING = new("mending", 16, 1);
    public static readonly EnchantmentType FROST_WALKER = new("frost_walker", 17, 2);
    public static readonly EnchantmentType LURE = new("lure", 18, 3);
    public static readonly EnchantmentType LOOT_BONUS_MOBS = new("looting", 19, 3);
    public static readonly EnchantmentType PIERCING = new("piercing", 20, 4);
    public static readonly EnchantmentType PROTECTION_EXPLOSIONS = new("blast_protection", 21, 4);
    public static readonly EnchantmentType DAMAGE_UNDEAD = new("smite", 22, 5);
    public static readonly EnchantmentType MULTISHOT = new("multishot", 23, 1);
    public static readonly EnchantmentType SWIFT_SNEAK = new("swift_sneak", 24, 3);
    public static readonly EnchantmentType FIRE_ASPECT = new("fire_aspect", 25, 2);
    public static readonly EnchantmentType CHANNELING = new("channeling", 26, 1);
    public static readonly EnchantmentType SWEEPING_EDGE = new("sweeping", 27, 3);
    public static readonly EnchantmentType THORNS = new("thorns", 28, 3);
    public static readonly EnchantmentType DAMAGE_ARTHROPODS = new("bane_of_arthropods", 29, 5);
    public static readonly EnchantmentType OXYGEN = new("respiration", 30, 3);
    public static readonly EnchantmentType RIPTIDE = new("riptide", 31, 3);
    public static readonly EnchantmentType SILK_TOUCH = new("silk_touch", 32, 1);
    public static readonly EnchantmentType QUICK_CHARGE = new("quick_charge", 33, 3);
    public static readonly EnchantmentType PROTECTION_PROJECTILE = new("projectile_protection", 34, 4);
    public static readonly EnchantmentType IMPALING = new("impaling", 35, 5);
    public static readonly EnchantmentType PROTECTION_FALL = new("feather_falling", 36, 4);
    public static readonly EnchantmentType ARROW_DAMAGE = new("power", 37, 5);
    public static readonly EnchantmentType ARROW_INFINITE = new("infinity", 38, 1);
}