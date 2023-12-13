namespace SkyBots.Api.Entities;

public readonly struct EntityType
{
    public static readonly EntityType[] TYPES = new EntityType[ENTITY_TYPES_COUNT];
    public int Id { get; }
    public string Name { get; }
    public bool IsAlive { get; }
    public bool IsSpawnable { get; }

    private EntityType(int id, string name, bool isAlive, bool isSpawnable)
    {
        Id = id;
        Name = name;
        IsAlive = isAlive;
        IsSpawnable = isSpawnable;
        TYPES[id] = this;
    }

    public EntityType()
    {
        Id = 124; //UNKNOWN
    }

    public static bool operator ==(EntityType left, EntityType right) => left.Id == right.Id;

    public static bool operator !=(EntityType left, EntityType right) => !(left == right);
    private bool Equals(EntityType other) => Id == other.Id;

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((EntityType)obj);
    }

    public override int GetHashCode() => Id;
    public override string ToString() => Name;

    public const int ENTITY_TYPES_COUNT = 126;

    public static readonly EntityType DROPPED_ITEM = new(0, "dropped_item", false, false);
    public static readonly EntityType EXPERIENCE_ORB = new(1, "experience_orb", false, true);
    public static readonly EntityType AREA_EFFECT_CLOUD = new(2, "area_effect_cloud", false, true);
    public static readonly EntityType ELDER_GUARDIAN = new(3, "elder_guardian", true, true);
    public static readonly EntityType WITHER_SKELETON = new(4, "wither_skeleton", true, true);
    public static readonly EntityType STRAY = new(5, "stray", true, true);
    public static readonly EntityType EGG = new(6, "egg", false, true);
    public static readonly EntityType LEASH_HITCH = new(7, "leash_hitch", false, true);
    public static readonly EntityType PAINTING = new(8, "painting", false, true);
    public static readonly EntityType ARROW = new(9, "arrow", false, true);
    public static readonly EntityType SNOWBALL = new(10, "snowball", false, true);
    public static readonly EntityType FIREBALL = new(11, "fireball", false, true);
    public static readonly EntityType SMALL_FIREBALL = new(12, "small_fireball", false, true);
    public static readonly EntityType ENDER_PEARL = new(13, "ender_pearl", false, true);
    public static readonly EntityType ENDER_SIGNAL = new(14, "ender_signal", false, true);
    public static readonly EntityType SPLASH_POTION = new(15, "splash_potion", false, false);
    public static readonly EntityType THROWN_EXP_BOTTLE = new(16, "thrown_exp_bottle", false, true);
    public static readonly EntityType ITEM_FRAME = new(17, "item_frame", false, true);
    public static readonly EntityType WITHER_SKULL = new(18, "wither_skull", false, true);
    public static readonly EntityType PRIMED_TNT = new(19, "primed_tnt", false, true);
    public static readonly EntityType FALLING_BLOCK = new(20, "falling_block", false, false);
    public static readonly EntityType FIREWORK = new(21, "firework", false, false);
    public static readonly EntityType HUSK = new(22, "husk", true, true);
    public static readonly EntityType SPECTRAL_ARROW = new(23, "spectral_arrow", false, true);
    public static readonly EntityType SHULKER_BULLET = new(24, "shulker_bullet", false, true);
    public static readonly EntityType DRAGON_FIREBALL = new(25, "dragon_fireball", false, true);
    public static readonly EntityType ZOMBIE_VILLAGER = new(26, "zombie_villager", true, true);
    public static readonly EntityType SKELETON_HORSE = new(27, "skeleton_horse", true, true);
    public static readonly EntityType ZOMBIE_HORSE = new(28, "zombie_horse", true, true);
    public static readonly EntityType ARMOR_STAND = new(29, "armor_stand", true, true);
    public static readonly EntityType DONKEY = new(30, "donkey", true, true);
    public static readonly EntityType MULE = new(31, "mule", true, true);
    public static readonly EntityType EVOKER_FANGS = new(32, "evoker_fangs", false, true);
    public static readonly EntityType EVOKER = new(33, "evoker", true, true);
    public static readonly EntityType VEX = new(34, "vex", true, true);
    public static readonly EntityType VINDICATOR = new(35, "vindicator", true, true);
    public static readonly EntityType ILLUSIONER = new(36, "illusioner", true, true);
    public static readonly EntityType MINECART_COMMAND = new(37, "minecart_command", false, true);
    public static readonly EntityType BOAT = new(38, "boat", false, true);
    public static readonly EntityType MINECART = new(39, "minecart", false, true);
    public static readonly EntityType MINECART_CHEST = new(40, "minecart_chest", false, true);
    public static readonly EntityType MINECART_FURNACE = new(41, "minecart_furnace", false, true);
    public static readonly EntityType MINECART_TNT = new(42, "minecart_tnt", false, true);
    public static readonly EntityType MINECART_HOPPER = new(43, "minecart_hopper", false, true);
    public static readonly EntityType MINECART_MOB_SPAWNER = new(44, "minecart_mob_spawner", false, true);
    public static readonly EntityType CREEPER = new(45, "creeper", true, true);
    public static readonly EntityType SKELETON = new(46, "skeleton", true, true);
    public static readonly EntityType SPIDER = new(47, "spider", true, true);
    public static readonly EntityType GIANT = new(48, "giant", true, true);
    public static readonly EntityType ZOMBIE = new(49, "zombie", true, true);
    public static readonly EntityType SLIME = new(50, "slime", true, true);
    public static readonly EntityType GHAST = new(51, "ghast", true, true);
    public static readonly EntityType ZOMBIFIED_PIGLIN = new(52, "zombified_piglin", true, true);
    public static readonly EntityType ENDERMAN = new(53, "enderman", true, true);
    public static readonly EntityType CAVE_SPIDER = new(54, "cave_spider", true, true);
    public static readonly EntityType SILVERFISH = new(55, "silverfish", true, true);
    public static readonly EntityType BLAZE = new(56, "blaze", true, true);
    public static readonly EntityType MAGMA_CUBE = new(57, "magma_cube", true, true);
    public static readonly EntityType ENDER_DRAGON = new(58, "ender_dragon", true, true);
    public static readonly EntityType WITHER = new(59, "wither", true, true);
    public static readonly EntityType BAT = new(60, "bat", true, true);
    public static readonly EntityType WITCH = new(61, "witch", true, true);
    public static readonly EntityType ENDERMITE = new(62, "endermite", true, true);
    public static readonly EntityType GUARDIAN = new(63, "guardian", true, true);
    public static readonly EntityType SHULKER = new(64, "shulker", true, true);
    public static readonly EntityType PIG = new(65, "pig", true, true);
    public static readonly EntityType SHEEP = new(66, "sheep", true, true);
    public static readonly EntityType COW = new(67, "cow", true, true);
    public static readonly EntityType CHICKEN = new(68, "chicken", true, true);
    public static readonly EntityType SQUID = new(69, "squid", true, true);
    public static readonly EntityType WOLF = new(70, "wolf", true, true);
    public static readonly EntityType MUSHROOM_COW = new(71, "mushroom_cow", true, true);
    public static readonly EntityType SNOWMAN = new(72, "snowman", true, true);
    public static readonly EntityType OCELOT = new(73, "ocelot", true, true);
    public static readonly EntityType IRON_GOLEM = new(74, "iron_golem", true, true);
    public static readonly EntityType HORSE = new(75, "horse", true, true);
    public static readonly EntityType RABBIT = new(76, "rabbit", true, true);
    public static readonly EntityType POLAR_BEAR = new(77, "polar_bear", true, true);
    public static readonly EntityType LLAMA = new(78, "llama", true, true);
    public static readonly EntityType LLAMA_SPIT = new(79, "llama_spit", false, true);
    public static readonly EntityType PARROT = new(80, "parrot", true, true);
    public static readonly EntityType VILLAGER = new(81, "villager", true, true);
    public static readonly EntityType ENDER_CRYSTAL = new(82, "ender_crystal", false, true);
    public static readonly EntityType TURTLE = new(83, "turtle", true, true);
    public static readonly EntityType PHANTOM = new(84, "phantom", true, true);
    public static readonly EntityType TRIDENT = new(85, "trident", false, true);
    public static readonly EntityType COD = new(86, "cod", true, true);
    public static readonly EntityType SALMON = new(87, "salmon", true, true);
    public static readonly EntityType PUFFERFISH = new(88, "pufferfish", true, true);
    public static readonly EntityType TROPICAL_FISH = new(89, "tropical_fish", true, true);
    public static readonly EntityType DROWNED = new(90, "drowned", true, true);
    public static readonly EntityType DOLPHIN = new(91, "dolphin", true, true);
    public static readonly EntityType CAT = new(92, "cat", true, true);
    public static readonly EntityType PANDA = new(93, "panda", true, true);
    public static readonly EntityType PILLAGER = new(94, "pillager", true, true);
    public static readonly EntityType RAVAGER = new(95, "ravager", true, true);
    public static readonly EntityType TRADER_LLAMA = new(96, "trader_llama", true, true);
    public static readonly EntityType WANDERING_TRADER = new(97, "wandering_trader", true, true);
    public static readonly EntityType FOX = new(98, "fox", true, true);
    public static readonly EntityType BEE = new(99, "bee", true, true);
    public static readonly EntityType HOGLIN = new(100, "hoglin", true, true);
    public static readonly EntityType PIGLIN = new(101, "piglin", true, true);
    public static readonly EntityType STRIDER = new(102, "strider", true, true);
    public static readonly EntityType ZOGLIN = new(103, "zoglin", true, true);
    public static readonly EntityType PIGLIN_BRUTE = new(104, "piglin_brute", true, true);
    public static readonly EntityType AXOLOTL = new(105, "axolotl", true, true);
    public static readonly EntityType GLOW_ITEM_FRAME = new(106, "glow_item_frame", false, true);
    public static readonly EntityType GLOW_SQUID = new(107, "glow_squid", true, true);
    public static readonly EntityType GOAT = new(108, "goat", true, true);
    public static readonly EntityType MARKER = new(109, "marker", false, true);
    public static readonly EntityType ALLAY = new(110, "allay", true, true);
    public static readonly EntityType CHEST_BOAT = new(111, "chest_boat", false, true);
    public static readonly EntityType FROG = new(112, "frog", true, true);
    public static readonly EntityType TADPOLE = new(113, "tadpole", true, true);
    public static readonly EntityType WARDEN = new(114, "warden", true, true);
    public static readonly EntityType CAMEL = new(115, "camel", true, true);
    public static readonly EntityType BLOCK_DISPLAY = new(116, "block_display", false, true);
    public static readonly EntityType INTERACTION = new(117, "interaction", false, true);
    public static readonly EntityType ITEM_DISPLAY = new(118, "item_display", false, true);
    public static readonly EntityType SNIFFER = new(119, "sniffer", true, true);
    public static readonly EntityType TEXT_DISPLAY = new(120, "text_display", false, true);
    public static readonly EntityType FISHING_HOOK = new(121, "fishing_hook", false, false);
    public static readonly EntityType LIGHTNING = new(122, "lightning", false, false);
    public static readonly EntityType PLAYER = new(123, "player", true, false);
    public static readonly EntityType UNKNOWN = new(124, "unknown", false, false);

    public static readonly EntityType BOT = new(125, "bot", true, true);
}