namespace SkyBots.Api.Entities;

public class EntityType
{
    public static readonly EntityType[] Types = new EntityType[ENTITY_TYPES_COUNT];
    public int Id { get; }
    public bool IsAlive { get; init; }
    public bool IsSpawnable { get; init; }

    public EntityType(int id)
    {
        Types[id] = this;
        Id = id;
    }

    public const int ENTITY_TYPES_COUNT = 125;

    public static readonly EntityType DROPPED_ITEM = new(0)
    {
        IsAlive = false,
        IsSpawnable = false
    };

    public static readonly EntityType EXPERIENCE_ORB = new(1)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType AREA_EFFECT_CLOUD = new(2)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType ELDER_GUARDIAN = new(3)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType WITHER_SKELETON = new(4)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType STRAY = new(5)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType EGG = new(6)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType LEASH_HITCH = new(7)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType PAINTING = new(8)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType ARROW = new(9)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType SNOWBALL = new(10)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType FIREBALL = new(11)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType SMALL_FIREBALL = new(12)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType ENDER_PEARL = new(13)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType ENDER_SIGNAL = new(14)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType SPLASH_POTION = new(15)
    {
        IsAlive = false,
        IsSpawnable = false
    };

    public static readonly EntityType THROWN_EXP_BOTTLE = new(16)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType ITEM_FRAME = new(17)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType WITHER_SKULL = new(18)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType PRIMED_TNT = new(19)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType FALLING_BLOCK = new(20)
    {
        IsAlive = false,
        IsSpawnable = false
    };

    public static readonly EntityType FIREWORK = new(21)
    {
        IsAlive = false,
        IsSpawnable = false
    };

    public static readonly EntityType HUSK = new(22)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SPECTRAL_ARROW = new(23)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType SHULKER_BULLET = new(24)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType DRAGON_FIREBALL = new(25)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType ZOMBIE_VILLAGER = new(26)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SKELETON_HORSE = new(27)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ZOMBIE_HORSE = new(28)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ARMOR_STAND = new(29)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType DONKEY = new(30)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType MULE = new(31)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType EVOKER_FANGS = new(32)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType EVOKER = new(33)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType VEX = new(34)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType VINDICATOR = new(35)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ILLUSIONER = new(36)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType MINECART_COMMAND = new(37)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType BOAT = new(38)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType MINECART = new(39)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType MINECART_CHEST = new(40)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType MINECART_FURNACE = new(41)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType MINECART_TNT = new(42)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType MINECART_HOPPER = new(43)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType MINECART_MOB_SPAWNER = new(44)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType CREEPER = new(45)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SKELETON = new(46)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SPIDER = new(47)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType GIANT = new(48)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ZOMBIE = new(49)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SLIME = new(50)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType GHAST = new(51)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ZOMBIFIED_PIGLIN = new(52)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ENDERMAN = new(53)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType CAVE_SPIDER = new(54)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SILVERFISH = new(55)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType BLAZE = new(56)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType MAGMA_CUBE = new(57)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ENDER_DRAGON = new(58)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType WITHER = new(59)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType BAT = new(60)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType WITCH = new(61)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ENDERMITE = new(62)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType GUARDIAN = new(63)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SHULKER = new(64)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType PIG = new(65)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SHEEP = new(66)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType COW = new(67)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType CHICKEN = new(68)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SQUID = new(69)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType WOLF = new(70)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType MUSHROOM_COW = new(71)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SNOWMAN = new(72)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType OCELOT = new(73)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType IRON_GOLEM = new(74)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType HORSE = new(75)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType RABBIT = new(76)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType POLAR_BEAR = new(77)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType LLAMA = new(78)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType LLAMA_SPIT = new(79)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType PARROT = new(80)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType VILLAGER = new(81)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ENDER_CRYSTAL = new(82)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType TURTLE = new(83)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType PHANTOM = new(84)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType TRIDENT = new(85)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType COD = new(86)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType SALMON = new(87)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType PUFFERFISH = new(88)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType TROPICAL_FISH = new(89)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType DROWNED = new(90)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType DOLPHIN = new(91)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType CAT = new(92)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType PANDA = new(93)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType PILLAGER = new(94)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType RAVAGER = new(95)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType TRADER_LLAMA = new(96)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType WANDERING_TRADER = new(97)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType FOX = new(98)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType BEE = new(99)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType HOGLIN = new(100)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType PIGLIN = new(101)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType STRIDER = new(102)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType ZOGLIN = new(103)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType PIGLIN_BRUTE = new(104)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType AXOLOTL = new(105)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType GLOW_ITEM_FRAME = new(106)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType GLOW_SQUID = new(107)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType GOAT = new(108)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType MARKER = new(109)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType ALLAY = new(110)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType CHEST_BOAT = new(111)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType FROG = new(112)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType TADPOLE = new(113)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType WARDEN = new(114)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType CAMEL = new(115)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType BLOCK_DISPLAY = new(116)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType INTERACTION = new(117)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType ITEM_DISPLAY = new(118)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType SNIFFER = new(119)
    {
        IsAlive = true,
        IsSpawnable = true
    };

    public static readonly EntityType TEXT_DISPLAY = new(120)
    {
        IsAlive = false,
        IsSpawnable = true
    };

    public static readonly EntityType FISHING_HOOK = new(121)
    {
        IsAlive = false,
        IsSpawnable = false
    };

    public static readonly EntityType LIGHTNING = new(122)
    {
        IsAlive = false,
        IsSpawnable = false
    };

    public static readonly EntityType PLAYER = new(123)
    {
        IsAlive = true,
        IsSpawnable = false
    };

    public static readonly EntityType UNKNOWN = new(124)
    {
        IsAlive = false,
        IsSpawnable = false
    };
}