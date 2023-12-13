namespace SkyBots.Api.Inventories;

public readonly struct Material
{
    public const int MATERIALS_COUNT = 1402;

    private static readonly Material[] Materials = new Material[MATERIALS_COUNT];

    public int Id { get; }
    public bool IsBlock { get; }
    public bool IsBurnable { get; }
    public bool IsFuel { get; }
    public bool IsItem { get; }
    public bool IsAir { get; }
    public bool IsFlammable { get; }
    public bool IsOccluding { get; }
    public bool IsSolid { get; }
    public bool IsRecord { get; }
    public bool IsInteractable { get; }
    public int MaxStackSize { get; }
    public float BlastResistance { get; }
    public string Name { get; }

    private Material(int id, string name, bool isBlock, bool isBurnable, bool isFuel, bool isItem, bool isAir,
        bool isFlammable, bool isOccluding, bool isSolid, bool isRecord, bool isInteractable,
        int maxStackSize, float blastResistance)
    {
        Id = id;
        Name = name;
        IsBlock = isBlock;
        IsBurnable = isBurnable;
        IsFuel = isFuel;
        IsItem = isItem;
        IsAir = isAir;
        IsFlammable = isFlammable;
        IsOccluding = isOccluding;
        IsSolid = isSolid;
        IsRecord = isRecord;
        IsInteractable = isInteractable;
        MaxStackSize = maxStackSize;
        BlastResistance = blastResistance;
        Materials[id] = this;
    }

    public override string ToString() => Name;

    public static Material FromId(int id) => Materials[id];

    #region POMOIKA

    public static readonly Material AIR = new(0, "air", true, false, false, true, true, false, false, false, false,
        false, 0, 0.0f);

    public static readonly Material STONE = new(1, "stone", true, false, false, true, false, false, true, true, false,
        false, 64, 6.0f);

    public static readonly Material GRANITE = new(2, "granite", true, false, false, true, false, false, true, true,
        false, false, 64, 6.0f);

    public static readonly Material POLISHED_GRANITE = new(3, "polished_granite", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material DIORITE = new(4, "diorite", true, false, false, true, false, false, true, true,
        false, false, 64, 6.0f);

    public static readonly Material POLISHED_DIORITE = new(5, "polished_diorite", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material ANDESITE = new(6, "andesite", true, false, false, true, false, false, true, true,
        false, false, 64, 6.0f);

    public static readonly Material POLISHED_ANDESITE = new(7, "polished_andesite", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material DEEPSLATE = new(8, "deepslate", true, false, false, true, false, false, true, true,
        false, false, 64, 6.0f);

    public static readonly Material COBBLED_DEEPSLATE = new(9, "cobbled_deepslate", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_DEEPSLATE = new(10, "polished_deepslate", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material CALCITE = new(11, "calcite", true, false, false, true, false, false, true, true,
        false, false, 64, 0.75f);

    public static readonly Material TUFF = new(12, "tuff", true, false, false, true, false, false, true, true, false,
        false, 64, 6.0f);

    public static readonly Material DRIPSTONE_BLOCK = new(13, "dripstone_block", true, false, false, true, false, false,
        true, true, false, false, 64, 1.0f);

    public static readonly Material GRASS_BLOCK = new(14, "grass_block", true, false, false, true, false, false, true,
        true, false, false, 64, 0.6f);

    public static readonly Material DIRT = new(15, "dirt", true, false, false, true, false, false, true, true, false,
        false, 64, 0.5f);

    public static readonly Material COARSE_DIRT = new(16, "coarse_dirt", true, false, false, true, false, false, true,
        true, false, false, 64, 0.5f);

    public static readonly Material PODZOL = new(17, "podzol", true, false, false, true, false, false, true, true,
        false, false, 64, 0.5f);

    public static readonly Material ROOTED_DIRT = new(18, "rooted_dirt", true, false, false, true, false, false, true,
        true, false, false, 64, 0.5f);

    public static readonly Material MUD = new(19, "mud", true, false, false, true, false, false, true, true, false,
        false, 64, 0.5f);

    public static readonly Material CRIMSON_NYLIUM = new(20, "crimson_nylium", true, false, false, true, false, false,
        true, true, false, false, 64, 0.4f);

    public static readonly Material WARPED_NYLIUM = new(21, "warped_nylium", true, false, false, true, false, false,
        true, true, false, false, 64, 0.4f);

    public static readonly Material COBBLESTONE = new(22, "cobblestone", true, false, false, true, false, false, true,
        true, false, false, 64, 6.0f);

    public static readonly Material OAK_PLANKS = new(23, "oak_planks", true, true, true, true, false, true, true, true,
        false, false, 64, 3.0f);

    public static readonly Material SPRUCE_PLANKS = new(24, "spruce_planks", true, true, true, true, false, true, true,
        true, false, false, 64, 3.0f);

    public static readonly Material BIRCH_PLANKS = new(25, "birch_planks", true, true, true, true, false, true, true,
        true, false, false, 64, 3.0f);

    public static readonly Material JUNGLE_PLANKS = new(26, "jungle_planks", true, true, true, true, false, true, true,
        true, false, false, 64, 3.0f);

    public static readonly Material ACACIA_PLANKS = new(27, "acacia_planks", true, true, true, true, false, true, true,
        true, false, false, 64, 3.0f);

    public static readonly Material CHERRY_PLANKS = new(28, "cherry_planks", true, true, true, true, false, true, true,
        true, false, false, 64, 3.0f);

    public static readonly Material DARK_OAK_PLANKS = new(29, "dark_oak_planks", true, true, true, true, false, true,
        true, true, false, false, 64, 3.0f);

    public static readonly Material MANGROVE_PLANKS = new(30, "mangrove_planks", true, true, true, true, false, true,
        true, true, false, false, 64, 3.0f);

    public static readonly Material BAMBOO_PLANKS = new(31, "bamboo_planks", true, true, true, true, false, true, true,
        true, false, false, 64, 3.0f);

    public static readonly Material CRIMSON_PLANKS = new(32, "crimson_planks", true, false, false, true, false, false,
        true, true, false, false, 64, 3.0f);

    public static readonly Material WARPED_PLANKS = new(33, "warped_planks", true, false, false, true, false, false,
        true, true, false, false, 64, 3.0f);

    public static readonly Material BAMBOO_MOSAIC = new(34, "bamboo_mosaic", true, true, true, true, false, true, true,
        true, false, false, 64, 3.0f);

    public static readonly Material OAK_SAPLING = new(35, "oak_sapling", true, false, true, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material SPRUCE_SAPLING = new(36, "spruce_sapling", true, false, true, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BIRCH_SAPLING = new(37, "birch_sapling", true, false, true, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material JUNGLE_SAPLING = new(38, "jungle_sapling", true, false, true, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material ACACIA_SAPLING = new(39, "acacia_sapling", true, false, true, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material CHERRY_SAPLING = new(40, "cherry_sapling", true, false, true, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material DARK_OAK_SAPLING = new(41, "dark_oak_sapling", true, false, true, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material MANGROVE_PROPAGULE = new(42, "mangrove_propagule", true, false, true, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material BEDROCK = new(43, "bedrock", true, false, false, true, false, false, true, true,
        false, false, 64, 3600000.0f);

    public static readonly Material SAND = new(44, "sand", true, false, false, true, false, false, true, true, false,
        false, 64, 0.5f);

    public static readonly Material SUSPICIOUS_SAND = new(45, "suspicious_sand", true, false, false, true, false, false,
        true, true, false, false, 64, 0.25f);

    public static readonly Material SUSPICIOUS_GRAVEL = new(46, "suspicious_gravel", true, false, false, true, false,
        false, true, true, false, false, 64, 0.25f);

    public static readonly Material RED_SAND = new(47, "red_sand", true, false, false, true, false, false, true, true,
        false, false, 64, 0.5f);

    public static readonly Material GRAVEL = new(48, "gravel", true, false, false, true, false, false, true, true,
        false, false, 64, 0.6f);

    public static readonly Material COAL_ORE = new(49, "coal_ore", true, false, false, true, false, false, true, true,
        false, false, 64, 3.0f);

    public static readonly Material DEEPSLATE_COAL_ORE = new(50, "deepslate_coal_ore", true, false, false, true, false,
        false, true, true, false, false, 64, 3.0f);

    public static readonly Material IRON_ORE = new(51, "iron_ore", true, false, false, true, false, false, true, true,
        false, false, 64, 3.0f);

    public static readonly Material DEEPSLATE_IRON_ORE = new(52, "deepslate_iron_ore", true, false, false, true, false,
        false, true, true, false, false, 64, 3.0f);

    public static readonly Material COPPER_ORE = new(53, "copper_ore", true, false, false, true, false, false, true,
        true, false, false, 64, 3.0f);

    public static readonly Material DEEPSLATE_COPPER_ORE = new(54, "deepslate_copper_ore", true, false, false, true,
        false, false, true, true, false, false, 64, 3.0f);

    public static readonly Material GOLD_ORE = new(55, "gold_ore", true, false, false, true, false, false, true, true,
        false, false, 64, 3.0f);

    public static readonly Material DEEPSLATE_GOLD_ORE = new(56, "deepslate_gold_ore", true, false, false, true, false,
        false, true, true, false, false, 64, 3.0f);

    public static readonly Material REDSTONE_ORE = new(57, "redstone_ore", true, false, false, true, false, false, true,
        true, false, true, 64, 3.0f);

    public static readonly Material DEEPSLATE_REDSTONE_ORE = new(58, "deepslate_redstone_ore", true, false, false, true,
        false, false, true, true, false, true, 64, 3.0f);

    public static readonly Material EMERALD_ORE = new(59, "emerald_ore", true, false, false, true, false, false, true,
        true, false, false, 64, 3.0f);

    public static readonly Material DEEPSLATE_EMERALD_ORE = new(60, "deepslate_emerald_ore", true, false, false, true,
        false, false, true, true, false, false, 64, 3.0f);

    public static readonly Material LAPIS_ORE = new(61, "lapis_ore", true, false, false, true, false, false, true, true,
        false, false, 64, 3.0f);

    public static readonly Material DEEPSLATE_LAPIS_ORE = new(62, "deepslate_lapis_ore", true, false, false, true,
        false, false, true, true, false, false, 64, 3.0f);

    public static readonly Material DIAMOND_ORE = new(63, "diamond_ore", true, false, false, true, false, false, true,
        true, false, false, 64, 3.0f);

    public static readonly Material DEEPSLATE_DIAMOND_ORE = new(64, "deepslate_diamond_ore", true, false, false, true,
        false, false, true, true, false, false, 64, 3.0f);

    public static readonly Material NETHER_GOLD_ORE = new(65, "nether_gold_ore", true, false, false, true, false, false,
        true, true, false, false, 64, 3.0f);

    public static readonly Material NETHER_QUARTZ_ORE = new(66, "nether_quartz_ore", true, false, false, true, false,
        false, true, true, false, false, 64, 3.0f);

    public static readonly Material ANCIENT_DEBRIS = new(67, "ancient_debris", true, false, false, true, false, false,
        true, true, false, false, 64, 1200.0f);

    public static readonly Material COAL_BLOCK = new(68, "coal_block", true, true, true, true, false, false, true, true,
        false, false, 64, 6.0f);

    public static readonly Material RAW_IRON_BLOCK = new(69, "raw_iron_block", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material RAW_COPPER_BLOCK = new(70, "raw_copper_block", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material RAW_GOLD_BLOCK = new(71, "raw_gold_block", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material AMETHYST_BLOCK = new(72, "amethyst_block", true, false, false, true, false, false,
        true, true, false, false, 64, 1.5f);

    public static readonly Material BUDDING_AMETHYST = new(73, "budding_amethyst", true, false, false, true, false,
        false, true, true, false, false, 64, 1.5f);

    public static readonly Material IRON_BLOCK = new(74, "iron_block", true, false, false, true, false, false, true,
        true, false, false, 64, 6.0f);

    public static readonly Material COPPER_BLOCK = new(75, "copper_block", true, false, false, true, false, false, true,
        true, false, false, 64, 6.0f);

    public static readonly Material GOLD_BLOCK = new(76, "gold_block", true, false, false, true, false, false, true,
        true, false, false, 64, 6.0f);

    public static readonly Material DIAMOND_BLOCK = new(77, "diamond_block", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material NETHERITE_BLOCK = new(78, "netherite_block", true, false, false, true, false, false,
        true, true, false, false, 64, 1200.0f);

    public static readonly Material EXPOSED_COPPER = new(79, "exposed_copper", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material WEATHERED_COPPER = new(80, "weathered_copper", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material OXIDIZED_COPPER = new(81, "oxidized_copper", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material CUT_COPPER = new(82, "cut_copper", true, false, false, true, false, false, true,
        true, false, false, 64, 6.0f);

    public static readonly Material EXPOSED_CUT_COPPER = new(83, "exposed_cut_copper", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material WEATHERED_CUT_COPPER = new(84, "weathered_cut_copper", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material OXIDIZED_CUT_COPPER = new(85, "oxidized_cut_copper", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material CUT_COPPER_STAIRS = new(86, "cut_copper_stairs", true, false, false, true, false,
        false, false, true, false, true, 64, 6.0f);

    public static readonly Material EXPOSED_CUT_COPPER_STAIRS = new(87, "exposed_cut_copper_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material WEATHERED_CUT_COPPER_STAIRS = new(88, "weathered_cut_copper_stairs", true, false,
        false, true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material OXIDIZED_CUT_COPPER_STAIRS = new(89, "oxidized_cut_copper_stairs", true, false,
        false, true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material CUT_COPPER_SLAB = new(90, "cut_copper_slab", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material EXPOSED_CUT_COPPER_SLAB = new(91, "exposed_cut_copper_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material WEATHERED_CUT_COPPER_SLAB = new(92, "weathered_cut_copper_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material OXIDIZED_CUT_COPPER_SLAB = new(93, "oxidized_cut_copper_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_COPPER_BLOCK = new(94, "waxed_copper_block", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_EXPOSED_COPPER = new(95, "waxed_exposed_copper", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_WEATHERED_COPPER = new(96, "waxed_weathered_copper", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_OXIDIZED_COPPER = new(97, "waxed_oxidized_copper", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_CUT_COPPER = new(98, "waxed_cut_copper", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_EXPOSED_CUT_COPPER = new(99, "waxed_exposed_cut_copper", true, false, false,
        true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_WEATHERED_CUT_COPPER = new(100, "waxed_weathered_cut_copper", true, false,
        false, true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_OXIDIZED_CUT_COPPER = new(101, "waxed_oxidized_cut_copper", true, false,
        false, true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_CUT_COPPER_STAIRS = new(102, "waxed_cut_copper_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material WAXED_EXPOSED_CUT_COPPER_STAIRS = new(103, "waxed_exposed_cut_copper_stairs", true,
        false, false, true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material WAXED_WEATHERED_CUT_COPPER_STAIRS = new(104, "waxed_weathered_cut_copper_stairs",
        true, false, false, true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material WAXED_OXIDIZED_CUT_COPPER_STAIRS = new(105, "waxed_oxidized_cut_copper_stairs",
        true, false, false, true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material WAXED_CUT_COPPER_SLAB = new(106, "waxed_cut_copper_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_EXPOSED_CUT_COPPER_SLAB = new(107, "waxed_exposed_cut_copper_slab", true,
        false, false, true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_WEATHERED_CUT_COPPER_SLAB = new(108, "waxed_weathered_cut_copper_slab", true,
        false, false, true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material WAXED_OXIDIZED_CUT_COPPER_SLAB = new(109, "waxed_oxidized_cut_copper_slab", true,
        false, false, true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material OAK_LOG = new(110, "oak_log", true, true, true, true, false, true, true, true,
        false, false, 64, 2.0f);

    public static readonly Material SPRUCE_LOG = new(111, "spruce_log", true, true, true, true, false, true, true, true,
        false, false, 64, 2.0f);

    public static readonly Material BIRCH_LOG = new(112, "birch_log", true, true, true, true, false, true, true, true,
        false, false, 64, 2.0f);

    public static readonly Material JUNGLE_LOG = new(113, "jungle_log", true, true, true, true, false, true, true, true,
        false, false, 64, 2.0f);

    public static readonly Material ACACIA_LOG = new(114, "acacia_log", true, true, true, true, false, true, true, true,
        false, false, 64, 2.0f);

    public static readonly Material CHERRY_LOG = new(115, "cherry_log", true, true, true, true, false, true, true, true,
        false, false, 64, 2.0f);

    public static readonly Material DARK_OAK_LOG = new(116, "dark_oak_log", true, true, true, true, false, true, true,
        true, false, false, 64, 2.0f);

    public static readonly Material MANGROVE_LOG = new(117, "mangrove_log", true, true, true, true, false, true, true,
        true, false, false, 64, 2.0f);

    public static readonly Material MANGROVE_ROOTS = new(118, "mangrove_roots", true, true, true, true, false, true,
        true, true, false, false, 64, 0.7f);

    public static readonly Material MUDDY_MANGROVE_ROOTS = new(119, "muddy_mangrove_roots", true, false, false, true,
        false, false, true, true, false, false, 64, 0.7f);

    public static readonly Material CRIMSON_STEM = new(120, "crimson_stem", true, false, false, true, false, false,
        true, true, false, false, 64, 2.0f);

    public static readonly Material WARPED_STEM = new(121, "warped_stem", true, false, false, true, false, false, true,
        true, false, false, 64, 2.0f);

    public static readonly Material BAMBOO_BLOCK = new(122, "bamboo_block", true, true, true, true, false, true, true,
        true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_OAK_LOG = new(123, "stripped_oak_log", true, true, true, true, false, true,
        true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_SPRUCE_LOG = new(124, "stripped_spruce_log", true, true, true, true, false,
        true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_BIRCH_LOG = new(125, "stripped_birch_log", true, true, true, true, false,
        true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_JUNGLE_LOG = new(126, "stripped_jungle_log", true, true, true, true, false,
        true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_ACACIA_LOG = new(127, "stripped_acacia_log", true, true, true, true, false,
        true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_CHERRY_LOG = new(128, "stripped_cherry_log", true, true, true, true, false,
        true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_DARK_OAK_LOG = new(129, "stripped_dark_oak_log", true, true, true, true,
        false, true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_MANGROVE_LOG = new(130, "stripped_mangrove_log", true, true, true, true,
        false, true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_CRIMSON_STEM = new(131, "stripped_crimson_stem", true, false, false, true,
        false, false, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_WARPED_STEM = new(132, "stripped_warped_stem", true, false, false, true,
        false, false, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_OAK_WOOD = new(133, "stripped_oak_wood", true, true, true, true, false,
        true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_SPRUCE_WOOD = new(134, "stripped_spruce_wood", true, true, true, true,
        false, true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_BIRCH_WOOD = new(135, "stripped_birch_wood", true, true, true, true, false,
        true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_JUNGLE_WOOD = new(136, "stripped_jungle_wood", true, true, true, true,
        false, true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_ACACIA_WOOD = new(137, "stripped_acacia_wood", true, true, true, true,
        false, true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_CHERRY_WOOD = new(138, "stripped_cherry_wood", true, true, true, true,
        false, true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_DARK_OAK_WOOD = new(139, "stripped_dark_oak_wood", true, true, true, true,
        false, true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_MANGROVE_WOOD = new(140, "stripped_mangrove_wood", true, true, true, true,
        false, true, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_CRIMSON_HYPHAE = new(141, "stripped_crimson_hyphae", true, false, false,
        true, false, false, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_WARPED_HYPHAE = new(142, "stripped_warped_hyphae", true, false, false,
        true, false, false, true, true, false, false, 64, 2.0f);

    public static readonly Material STRIPPED_BAMBOO_BLOCK = new(143, "stripped_bamboo_block", true, true, true, true,
        false, true, true, true, false, false, 64, 2.0f);

    public static readonly Material OAK_WOOD = new(144, "oak_wood", true, true, true, true, false, true, true, true,
        false, false, 64, 2.0f);

    public static readonly Material SPRUCE_WOOD = new(145, "spruce_wood", true, true, true, true, false, true, true,
        true, false, false, 64, 2.0f);

    public static readonly Material BIRCH_WOOD = new(146, "birch_wood", true, true, true, true, false, true, true, true,
        false, false, 64, 2.0f);

    public static readonly Material JUNGLE_WOOD = new(147, "jungle_wood", true, true, true, true, false, true, true,
        true, false, false, 64, 2.0f);

    public static readonly Material ACACIA_WOOD = new(148, "acacia_wood", true, true, true, true, false, true, true,
        true, false, false, 64, 2.0f);

    public static readonly Material CHERRY_WOOD = new(149, "cherry_wood", true, true, true, true, false, true, true,
        true, false, false, 64, 2.0f);

    public static readonly Material DARK_OAK_WOOD = new(150, "dark_oak_wood", true, true, true, true, false, true, true,
        true, false, false, 64, 2.0f);

    public static readonly Material MANGROVE_WOOD = new(151, "mangrove_wood", true, true, true, true, false, true, true,
        true, false, false, 64, 2.0f);

    public static readonly Material CRIMSON_HYPHAE = new(152, "crimson_hyphae", true, false, false, true, false, false,
        true, true, false, false, 64, 2.0f);

    public static readonly Material WARPED_HYPHAE = new(153, "warped_hyphae", true, false, false, true, false, false,
        true, true, false, false, 64, 2.0f);

    public static readonly Material OAK_LEAVES = new(154, "oak_leaves", true, true, false, true, false, true, false,
        true, false, false, 64, 0.2f);

    public static readonly Material SPRUCE_LEAVES = new(155, "spruce_leaves", true, true, false, true, false, true,
        false, true, false, false, 64, 0.2f);

    public static readonly Material BIRCH_LEAVES = new(156, "birch_leaves", true, true, false, true, false, true, false,
        true, false, false, 64, 0.2f);

    public static readonly Material JUNGLE_LEAVES = new(157, "jungle_leaves", true, true, false, true, false, true,
        false, true, false, false, 64, 0.2f);

    public static readonly Material ACACIA_LEAVES = new(158, "acacia_leaves", true, true, false, true, false, true,
        false, true, false, false, 64, 0.2f);

    public static readonly Material CHERRY_LEAVES = new(159, "cherry_leaves", true, true, false, true, false, true,
        false, true, false, false, 64, 0.2f);

    public static readonly Material DARK_OAK_LEAVES = new(160, "dark_oak_leaves", true, true, false, true, false, true,
        false, true, false, false, 64, 0.2f);

    public static readonly Material MANGROVE_LEAVES = new(161, "mangrove_leaves", true, true, false, true, false, true,
        false, true, false, false, 64, 0.2f);

    public static readonly Material AZALEA_LEAVES = new(162, "azalea_leaves", true, true, false, true, false, true,
        false, true, false, false, 64, 0.2f);

    public static readonly Material FLOWERING_AZALEA_LEAVES = new(163, "flowering_azalea_leaves", true, true, false,
        true, false, true, false, true, false, false, 64, 0.2f);

    public static readonly Material SPONGE = new(164, "sponge", true, false, false, true, false, false, true, true,
        false, false, 64, 0.6f);

    public static readonly Material WET_SPONGE = new(165, "wet_sponge", true, false, false, true, false, false, true,
        true, false, false, 64, 0.6f);

    public static readonly Material GLASS = new(166, "glass", true, false, false, true, false, false, false, true,
        false, false, 64, 0.3f);

    public static readonly Material TINTED_GLASS = new(167, "tinted_glass", true, false, false, true, false, false,
        false, true, false, false, 64, 0.3f);

    public static readonly Material LAPIS_BLOCK = new(168, "lapis_block", true, false, false, true, false, false, true,
        true, false, false, 64, 3.0f);

    public static readonly Material SANDSTONE = new(169, "sandstone", true, false, false, true, false, false, true,
        true, false, false, 64, 0.8f);

    public static readonly Material CHISELED_SANDSTONE = new(170, "chiseled_sandstone", true, false, false, true, false,
        false, true, true, false, false, 64, 0.8f);

    public static readonly Material CUT_SANDSTONE = new(171, "cut_sandstone", true, false, false, true, false, false,
        true, true, false, false, 64, 0.8f);

    public static readonly Material COBWEB = new(172, "cobweb", true, false, false, true, false, false, false, false,
        false, false, 64, 4.0f);

    public static readonly Material GRASS = new(173, "grass", true, true, false, true, false, true, false, false, false,
        false, 64, 0.0f);

    public static readonly Material FERN = new(174, "fern", true, true, false, true, false, true, false, false, false,
        false, 64, 0.0f);

    public static readonly Material AZALEA = new(175, "azalea", true, true, true, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material FLOWERING_AZALEA = new(176, "flowering_azalea", true, true, true, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material DEAD_BUSH = new(177, "dead_bush", true, true, true, true, false, true, false, false,
        false, false, 64, 0.0f);

    public static readonly Material SEAGRASS = new(178, "seagrass", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material SEA_PICKLE = new(179, "sea_pickle", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material WHITE_WOOL = new(180, "white_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material ORANGE_WOOL = new(181, "orange_wool", true, true, true, true, false, true, true,
        true, false, false, 64, 0.8f);

    public static readonly Material MAGENTA_WOOL = new(182, "magenta_wool", true, true, true, true, false, true, true,
        true, false, false, 64, 0.8f);

    public static readonly Material LIGHT_BLUE_WOOL = new(183, "light_blue_wool", true, true, true, true, false, true,
        true, true, false, false, 64, 0.8f);

    public static readonly Material YELLOW_WOOL = new(184, "yellow_wool", true, true, true, true, false, true, true,
        true, false, false, 64, 0.8f);

    public static readonly Material LIME_WOOL = new(185, "lime_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material PINK_WOOL = new(186, "pink_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material GRAY_WOOL = new(187, "gray_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material LIGHT_GRAY_WOOL = new(188, "light_gray_wool", true, true, true, true, false, true,
        true, true, false, false, 64, 0.8f);

    public static readonly Material CYAN_WOOL = new(189, "cyan_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material PURPLE_WOOL = new(190, "purple_wool", true, true, true, true, false, true, true,
        true, false, false, 64, 0.8f);

    public static readonly Material BLUE_WOOL = new(191, "blue_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material BROWN_WOOL = new(192, "brown_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material GREEN_WOOL = new(193, "green_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material RED_WOOL = new(194, "red_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material BLACK_WOOL = new(195, "black_wool", true, true, true, true, false, true, true, true,
        false, false, 64, 0.8f);

    public static readonly Material DANDELION = new(196, "dandelion", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material POPPY = new(197, "poppy", true, true, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material BLUE_ORCHID = new(198, "blue_orchid", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material ALLIUM = new(199, "allium", true, true, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material AZURE_BLUET = new(200, "azure_bluet", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material RED_TULIP = new(201, "red_tulip", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material ORANGE_TULIP = new(202, "orange_tulip", true, true, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material WHITE_TULIP = new(203, "white_tulip", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material PINK_TULIP = new(204, "pink_tulip", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material OXEYE_DAISY = new(205, "oxeye_daisy", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material CORNFLOWER = new(206, "cornflower", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material LILY_OF_THE_VALLEY = new(207, "lily_of_the_valley", true, true, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material WITHER_ROSE = new(208, "wither_rose", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material TORCHFLOWER = new(209, "torchflower", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material PITCHER_PLANT = new(210, "pitcher_plant", true, true, false, true, false, true,
        false, false, false, false, 64, 0.0f);

    public static readonly Material SPORE_BLOSSOM = new(211, "spore_blossom", true, true, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BROWN_MUSHROOM = new(212, "brown_mushroom", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material RED_MUSHROOM = new(213, "red_mushroom", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material CRIMSON_FUNGUS = new(214, "crimson_fungus", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material WARPED_FUNGUS = new(215, "warped_fungus", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material CRIMSON_ROOTS = new(216, "crimson_roots", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material WARPED_ROOTS = new(217, "warped_roots", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material NETHER_SPROUTS = new(218, "nether_sprouts", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material WEEPING_VINES = new(219, "weeping_vines", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material TWISTING_VINES = new(220, "twisting_vines", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material SUGAR_CANE = new(221, "sugar_cane", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material KELP = new(222, "kelp", true, false, false, true, false, false, false, false, false,
        false, 64, 0.0f);

    public static readonly Material MOSS_CARPET = new(223, "moss_carpet", true, false, false, true, false, false, false,
        false, false, false, 64, 0.1f);

    public static readonly Material PINK_PETALS = new(224, "pink_petals", true, true, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material MOSS_BLOCK = new(225, "moss_block", true, false, false, true, false, false, true,
        true, false, false, 64, 0.1f);

    public static readonly Material HANGING_ROOTS = new(226, "hanging_roots", true, true, false, true, false, true,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BIG_DRIPLEAF = new(227, "big_dripleaf", true, true, false, true, false, false,
        false, false, false, false, 64, 0.1f);

    public static readonly Material SMALL_DRIPLEAF = new(228, "small_dripleaf", true, true, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BAMBOO = new(229, "bamboo", true, true, true, true, false, true, false, true, false,
        false, 64, 1.0f);

    public static readonly Material OAK_SLAB = new(230, "oak_slab", true, true, true, true, false, true, false, true,
        false, false, 64, 3.0f);

    public static readonly Material SPRUCE_SLAB = new(231, "spruce_slab", true, true, true, true, false, true, false,
        true, false, false, 64, 3.0f);

    public static readonly Material BIRCH_SLAB = new(232, "birch_slab", true, true, true, true, false, true, false,
        true, false, false, 64, 3.0f);

    public static readonly Material JUNGLE_SLAB = new(233, "jungle_slab", true, true, true, true, false, true, false,
        true, false, false, 64, 3.0f);

    public static readonly Material ACACIA_SLAB = new(234, "acacia_slab", true, true, true, true, false, true, false,
        true, false, false, 64, 3.0f);

    public static readonly Material CHERRY_SLAB = new(235, "cherry_slab", true, true, true, true, false, true, false,
        true, false, false, 64, 3.0f);

    public static readonly Material DARK_OAK_SLAB = new(236, "dark_oak_slab", true, true, true, true, false, true,
        false, true, false, false, 64, 3.0f);

    public static readonly Material MANGROVE_SLAB = new(237, "mangrove_slab", true, true, true, true, false, true,
        false, true, false, false, 64, 3.0f);

    public static readonly Material BAMBOO_SLAB = new(238, "bamboo_slab", true, true, true, true, false, true, false,
        true, false, false, 64, 3.0f);

    public static readonly Material BAMBOO_MOSAIC_SLAB = new(239, "bamboo_mosaic_slab", true, true, true, true, false,
        true, false, true, false, false, 64, 3.0f);

    public static readonly Material CRIMSON_SLAB = new(240, "crimson_slab", true, false, false, true, false, false,
        false, true, false, false, 64, 3.0f);

    public static readonly Material WARPED_SLAB = new(241, "warped_slab", true, false, false, true, false, false, false,
        true, false, false, 64, 3.0f);

    public static readonly Material STONE_SLAB = new(242, "stone_slab", true, false, false, true, false, false, false,
        true, false, false, 64, 6.0f);

    public static readonly Material SMOOTH_STONE_SLAB = new(243, "smooth_stone_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material SANDSTONE_SLAB = new(244, "sandstone_slab", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material CUT_SANDSTONE_SLAB = new(245, "cut_sandstone_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material PETRIFIED_OAK_SLAB = new(246, "petrified_oak_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material COBBLESTONE_SLAB = new(247, "cobblestone_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material BRICK_SLAB = new(248, "brick_slab", true, false, false, true, false, false, false,
        true, false, false, 64, 6.0f);

    public static readonly Material STONE_BRICK_SLAB = new(249, "stone_brick_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material MUD_BRICK_SLAB = new(250, "mud_brick_slab", true, false, false, true, false, false,
        false, true, false, false, 64, 3.0f);

    public static readonly Material NETHER_BRICK_SLAB = new(251, "nether_brick_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material QUARTZ_SLAB = new(252, "quartz_slab", true, false, false, true, false, false, false,
        true, false, false, 64, 6.0f);

    public static readonly Material RED_SANDSTONE_SLAB = new(253, "red_sandstone_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material CUT_RED_SANDSTONE_SLAB = new(254, "cut_red_sandstone_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material PURPUR_SLAB = new(255, "purpur_slab", true, false, false, true, false, false, false,
        true, false, false, 64, 6.0f);

    public static readonly Material PRISMARINE_SLAB = new(256, "prismarine_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material PRISMARINE_BRICK_SLAB = new(257, "prismarine_brick_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material DARK_PRISMARINE_SLAB = new(258, "dark_prismarine_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material SMOOTH_QUARTZ = new(259, "smooth_quartz", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material SMOOTH_RED_SANDSTONE = new(260, "smooth_red_sandstone", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material SMOOTH_SANDSTONE = new(261, "smooth_sandstone", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material SMOOTH_STONE = new(262, "smooth_stone", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material BRICKS = new(263, "bricks", true, false, false, true, false, false, true, true,
        false, false, 64, 6.0f);

    public static readonly Material BOOKSHELF = new(264, "bookshelf", true, true, true, true, false, true, true, true,
        false, false, 64, 1.5f);

    public static readonly Material CHISELED_BOOKSHELF = new(265, "chiseled_bookshelf", true, false, true, true, false,
        true, true, true, false, true, 64, 1.5f);

    public static readonly Material DECORATED_POT = new(266, "decorated_pot", true, false, false, true, false, false,
        false, true, false, false, 1, 0.0f);

    public static readonly Material MOSSY_COBBLESTONE = new(267, "mossy_cobblestone", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material OBSIDIAN = new(268, "obsidian", true, false, false, true, false, false, true, true,
        false, false, 64, 1200.0f);

    public static readonly Material TORCH = new(269, "torch", true, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material END_ROD = new(270, "end_rod", true, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material CHORUS_PLANT = new(271, "chorus_plant", true, false, false, true, false, false,
        false, false, false, false, 64, 0.4f);

    public static readonly Material CHORUS_FLOWER = new(272, "chorus_flower", true, false, false, true, false, false,
        false, false, false, false, 64, 0.4f);

    public static readonly Material PURPUR_BLOCK = new(273, "purpur_block", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material PURPUR_PILLAR = new(274, "purpur_pillar", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material PURPUR_STAIRS = new(275, "purpur_stairs", true, false, false, true, false, false,
        false, true, false, true, 64, 6.0f);

    public static readonly Material SPAWNER = new(276, "spawner", true, false, false, true, false, false, true, true,
        false, false, 64, 5.0f);

    public static readonly Material CHEST = new(277, "chest", true, false, true, true, false, true, false, true, false,
        true, 64, 2.5f);

    public static readonly Material CRAFTING_TABLE = new(278, "crafting_table", true, false, true, true, false, true,
        true, true, false, true, 64, 2.5f);

    public static readonly Material FARMLAND = new(279, "farmland", true, false, false, true, false, false, false, true,
        false, false, 64, 0.6f);

    public static readonly Material FURNACE = new(280, "furnace", true, false, false, true, false, false, true, true,
        false, true, 64, 3.5f);

    public static readonly Material LADDER = new(281, "ladder", true, false, true, true, false, false, false, false,
        false, false, 64, 0.4f);

    public static readonly Material COBBLESTONE_STAIRS = new(282, "cobblestone_stairs", true, false, false, true, false,
        false, false, true, false, true, 64, 6.0f);

    public static readonly Material SNOW = new(283, "snow", true, false, false, true, false, false, false, false, false,
        false, 64, 0.1f);

    public static readonly Material ICE = new(284, "ice", true, false, false, true, false, false, false, true, false,
        false, 64, 0.5f);

    public static readonly Material SNOW_BLOCK = new(285, "snow_block", true, false, false, true, false, false, true,
        true, false, false, 64, 0.2f);

    public static readonly Material CACTUS = new(286, "cactus", true, false, false, true, false, false, false, true,
        false, false, 64, 0.4f);

    public static readonly Material CLAY = new(287, "clay", true, false, false, true, false, false, true, true, false,
        false, 64, 0.6f);

    public static readonly Material JUKEBOX = new(288, "jukebox", true, false, true, true, false, true, true, true,
        false, true, 64, 6.0f);

    public static readonly Material OAK_FENCE = new(289, "oak_fence", true, true, true, true, false, true, false, true,
        false, true, 64, 3.0f);

    public static readonly Material SPRUCE_FENCE = new(290, "spruce_fence", true, true, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material BIRCH_FENCE = new(291, "birch_fence", true, true, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material JUNGLE_FENCE = new(292, "jungle_fence", true, true, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material ACACIA_FENCE = new(293, "acacia_fence", true, true, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material CHERRY_FENCE = new(294, "cherry_fence", true, true, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material DARK_OAK_FENCE = new(295, "dark_oak_fence", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material MANGROVE_FENCE = new(296, "mangrove_fence", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material BAMBOO_FENCE = new(297, "bamboo_fence", true, true, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material CRIMSON_FENCE = new(298, "crimson_fence", true, false, false, true, false, false,
        false, true, false, true, 64, 3.0f);

    public static readonly Material WARPED_FENCE = new(299, "warped_fence", true, false, false, true, false, false,
        false, true, false, true, 64, 3.0f);

    public static readonly Material PUMPKIN = new(300, "pumpkin", true, false, false, true, false, false, true, true,
        false, true, 64, 1.0f);

    public static readonly Material CARVED_PUMPKIN = new(301, "carved_pumpkin", true, false, false, true, false, false,
        true, true, false, false, 64, 1.0f);

    public static readonly Material JACK_O_LANTERN = new(302, "jack_o_lantern", true, false, false, true, false, false,
        true, true, false, false, 64, 1.0f);

    public static readonly Material NETHERRACK = new(303, "netherrack", true, false, false, true, false, false, true,
        true, false, false, 64, 0.4f);

    public static readonly Material SOUL_SAND = new(304, "soul_sand", true, false, false, true, false, false, true,
        true, false, false, 64, 0.5f);

    public static readonly Material SOUL_SOIL = new(305, "soul_soil", true, false, false, true, false, false, true,
        true, false, false, 64, 0.5f);

    public static readonly Material BASALT = new(306, "basalt", true, false, false, true, false, false, true, true,
        false, false, 64, 4.2f);

    public static readonly Material POLISHED_BASALT = new(307, "polished_basalt", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material SMOOTH_BASALT = new(308, "smooth_basalt", true, false, false, true, false, false,
        true, true, false, false, 64, 4.2f);

    public static readonly Material SOUL_TORCH = new(309, "soul_torch", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material GLOWSTONE = new(310, "glowstone", true, false, false, true, false, false, false,
        true, false, false, 64, 0.3f);

    public static readonly Material INFESTED_STONE = new(311, "infested_stone", true, false, false, true, false, false,
        true, true, false, false, 64, 0.75f);

    public static readonly Material INFESTED_COBBLESTONE = new(312, "infested_cobblestone", true, false, false, true,
        false, false, true, true, false, false, 64, 0.75f);

    public static readonly Material INFESTED_STONE_BRICKS = new(313, "infested_stone_bricks", true, false, false, true,
        false, false, true, true, false, false, 64, 0.75f);

    public static readonly Material INFESTED_MOSSY_STONE_BRICKS = new(314, "infested_mossy_stone_bricks", true, false,
        false, true, false, false, true, true, false, false, 64, 0.75f);

    public static readonly Material INFESTED_CRACKED_STONE_BRICKS = new(315, "infested_cracked_stone_bricks", true,
        false, false, true, false, false, true, true, false, false, 64, 0.75f);

    public static readonly Material INFESTED_CHISELED_STONE_BRICKS = new(316, "infested_chiseled_stone_bricks", true,
        false, false, true, false, false, true, true, false, false, 64, 0.75f);

    public static readonly Material INFESTED_DEEPSLATE = new(317, "infested_deepslate", true, false, false, true, false,
        false, true, true, false, false, 64, 0.75f);

    public static readonly Material STONE_BRICKS = new(318, "stone_bricks", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material MOSSY_STONE_BRICKS = new(319, "mossy_stone_bricks", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material CRACKED_STONE_BRICKS = new(320, "cracked_stone_bricks", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material CHISELED_STONE_BRICKS = new(321, "chiseled_stone_bricks", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material PACKED_MUD = new(322, "packed_mud", true, false, false, true, false, false, true,
        true, false, false, 64, 3.0f);

    public static readonly Material MUD_BRICKS = new(323, "mud_bricks", true, false, false, true, false, false, true,
        true, false, false, 64, 3.0f);

    public static readonly Material DEEPSLATE_BRICKS = new(324, "deepslate_bricks", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material CRACKED_DEEPSLATE_BRICKS = new(325, "cracked_deepslate_bricks", true, false, false,
        true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material DEEPSLATE_TILES = new(326, "deepslate_tiles", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material CRACKED_DEEPSLATE_TILES = new(327, "cracked_deepslate_tiles", true, false, false,
        true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material CHISELED_DEEPSLATE = new(328, "chiseled_deepslate", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material REINFORCED_DEEPSLATE = new(329, "reinforced_deepslate", true, false, false, true,
        false, false, true, true, false, false, 64, 1200.0f);

    public static readonly Material BROWN_MUSHROOM_BLOCK = new(330, "brown_mushroom_block", true, false, false, true,
        false, true, true, true, false, false, 64, 0.2f);

    public static readonly Material RED_MUSHROOM_BLOCK = new(331, "red_mushroom_block", true, false, false, true, false,
        true, true, true, false, false, 64, 0.2f);

    public static readonly Material MUSHROOM_STEM = new(332, "mushroom_stem", true, false, false, true, false, true,
        true, true, false, false, 64, 0.2f);

    public static readonly Material IRON_BARS = new(333, "iron_bars", true, false, false, true, false, false, false,
        true, false, false, 64, 6.0f);

    public static readonly Material CHAIN = new(334, "chain", true, false, false, true, false, false, false, true,
        false, false, 64, 6.0f);

    public static readonly Material GLASS_PANE = new(335, "glass_pane", true, false, false, true, false, false, false,
        true, false, false, 64, 0.3f);

    public static readonly Material MELON = new(336, "melon", true, false, false, true, false, false, true, true, false,
        false, 64, 1.0f);

    public static readonly Material VINE = new(337, "vine", true, true, false, true, false, true, false, false, false,
        false, 64, 0.2f);

    public static readonly Material GLOW_LICHEN = new(338, "glow_lichen", true, true, false, true, false, true, false,
        false, false, false, 64, 0.2f);

    public static readonly Material BRICK_STAIRS = new(339, "brick_stairs", true, false, false, true, false, false,
        false, true, false, true, 64, 6.0f);

    public static readonly Material STONE_BRICK_STAIRS = new(340, "stone_brick_stairs", true, false, false, true, false,
        false, false, true, false, true, 64, 6.0f);

    public static readonly Material MUD_BRICK_STAIRS = new(341, "mud_brick_stairs", true, false, false, true, false,
        false, false, true, false, true, 64, 3.0f);

    public static readonly Material MYCELIUM = new(342, "mycelium", true, false, false, true, false, false, true, true,
        false, false, 64, 0.6f);

    public static readonly Material LILY_PAD = new(343, "lily_pad", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material NETHER_BRICKS = new(344, "nether_bricks", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material CRACKED_NETHER_BRICKS = new(345, "cracked_nether_bricks", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material CHISELED_NETHER_BRICKS = new(346, "chiseled_nether_bricks", true, false, false,
        true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material NETHER_BRICK_FENCE = new(347, "nether_brick_fence", true, false, false, true, false,
        false, false, true, false, true, 64, 6.0f);

    public static readonly Material NETHER_BRICK_STAIRS = new(348, "nether_brick_stairs", true, false, false, true,
        false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material SCULK = new(349, "sculk", true, false, false, true, false, false, true, true, false,
        false, 64, 0.2f);

    public static readonly Material SCULK_VEIN = new(350, "sculk_vein", true, false, false, true, false, false, false,
        true, false, false, 64, 0.2f);

    public static readonly Material SCULK_CATALYST = new(351, "sculk_catalyst", true, false, false, true, false, false,
        true, true, false, false, 64, 3.0f);

    public static readonly Material SCULK_SHRIEKER = new(352, "sculk_shrieker", true, false, false, true, false, false,
        false, true, false, false, 64, 3.0f);

    public static readonly Material ENCHANTING_TABLE = new(353, "enchanting_table", true, false, false, true, false,
        false, false, true, false, true, 64, 1200.0f);

    public static readonly Material END_PORTAL_FRAME = new(354, "end_portal_frame", true, false, false, true, false,
        false, false, true, false, false, 64, 3600000.0f);

    public static readonly Material END_STONE = new(355, "end_stone", true, false, false, true, false, false, true,
        true, false, false, 64, 9.0f);

    public static readonly Material END_STONE_BRICKS = new(356, "end_stone_bricks", true, false, false, true, false,
        false, true, true, false, false, 64, 9.0f);

    public static readonly Material DRAGON_EGG = new(357, "dragon_egg", true, false, false, true, false, false, false,
        true, false, true, 64, 9.0f);

    public static readonly Material SANDSTONE_STAIRS = new(358, "sandstone_stairs", true, false, false, true, false,
        false, false, true, false, true, 64, 0.8f);

    public static readonly Material ENDER_CHEST = new(359, "ender_chest", true, false, false, true, false, false, false,
        true, false, true, 64, 600.0f);

    public static readonly Material EMERALD_BLOCK = new(360, "emerald_block", true, false, false, true, false, false,
        true, true, false, false, 64, 6.0f);

    public static readonly Material OAK_STAIRS = new(361, "oak_stairs", true, true, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material SPRUCE_STAIRS = new(362, "spruce_stairs", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material BIRCH_STAIRS = new(363, "birch_stairs", true, true, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material JUNGLE_STAIRS = new(364, "jungle_stairs", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material ACACIA_STAIRS = new(365, "acacia_stairs", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material CHERRY_STAIRS = new(366, "cherry_stairs", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material DARK_OAK_STAIRS = new(367, "dark_oak_stairs", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material MANGROVE_STAIRS = new(368, "mangrove_stairs", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material BAMBOO_STAIRS = new(369, "bamboo_stairs", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material BAMBOO_MOSAIC_STAIRS = new(370, "bamboo_mosaic_stairs", true, true, true, true,
        false, true, false, true, false, true, 64, 3.0f);

    public static readonly Material CRIMSON_STAIRS = new(371, "crimson_stairs", true, false, false, true, false, false,
        false, true, false, true, 64, 3.0f);

    public static readonly Material WARPED_STAIRS = new(372, "warped_stairs", true, false, false, true, false, false,
        false, true, false, true, 64, 3.0f);

    public static readonly Material COMMAND_BLOCK = new(373, "command_block", true, false, false, true, false, false,
        true, true, false, true, 64, 3600000.0f);

    public static readonly Material BEACON = new(374, "beacon", true, false, false, true, false, false, false, true,
        false, true, 64, 3.0f);

    public static readonly Material COBBLESTONE_WALL = new(375, "cobblestone_wall", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material MOSSY_COBBLESTONE_WALL = new(376, "mossy_cobblestone_wall", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material BRICK_WALL = new(377, "brick_wall", true, false, false, true, false, false, false,
        true, false, false, 64, 6.0f);

    public static readonly Material PRISMARINE_WALL = new(378, "prismarine_wall", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material RED_SANDSTONE_WALL = new(379, "red_sandstone_wall", true, false, false, true, false,
        false, false, true, false, false, 64, 0.8f);

    public static readonly Material MOSSY_STONE_BRICK_WALL = new(380, "mossy_stone_brick_wall", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material GRANITE_WALL = new(381, "granite_wall", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material STONE_BRICK_WALL = new(382, "stone_brick_wall", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material MUD_BRICK_WALL = new(383, "mud_brick_wall", true, false, false, true, false, false,
        false, true, false, false, 64, 3.0f);

    public static readonly Material NETHER_BRICK_WALL = new(384, "nether_brick_wall", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material ANDESITE_WALL = new(385, "andesite_wall", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material RED_NETHER_BRICK_WALL = new(386, "red_nether_brick_wall", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material SANDSTONE_WALL = new(387, "sandstone_wall", true, false, false, true, false, false,
        false, true, false, false, 64, 0.8f);

    public static readonly Material END_STONE_BRICK_WALL = new(388, "end_stone_brick_wall", true, false, false, true,
        false, false, false, true, false, false, 64, 9.0f);

    public static readonly Material DIORITE_WALL = new(389, "diorite_wall", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material BLACKSTONE_WALL = new(390, "blackstone_wall", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_BLACKSTONE_WALL = new(391, "polished_blackstone_wall", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_BLACKSTONE_BRICK_WALL = new(392, "polished_blackstone_brick_wall", true,
        false, false, true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material COBBLED_DEEPSLATE_WALL = new(393, "cobbled_deepslate_wall", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_DEEPSLATE_WALL = new(394, "polished_deepslate_wall", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material DEEPSLATE_BRICK_WALL = new(395, "deepslate_brick_wall", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material DEEPSLATE_TILE_WALL = new(396, "deepslate_tile_wall", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material ANVIL = new(397, "anvil", true, false, false, true, false, false, false, true,
        false, true, 64, 1200.0f);

    public static readonly Material CHIPPED_ANVIL = new(398, "chipped_anvil", true, false, false, true, false, false,
        false, true, false, true, 64, 1200.0f);

    public static readonly Material DAMAGED_ANVIL = new(399, "damaged_anvil", true, false, false, true, false, false,
        false, true, false, true, 64, 1200.0f);

    public static readonly Material CHISELED_QUARTZ_BLOCK = new(400, "chiseled_quartz_block", true, false, false, true,
        false, false, true, true, false, false, 64, 0.8f);

    public static readonly Material QUARTZ_BLOCK = new(401, "quartz_block", true, false, false, true, false, false,
        true, true, false, false, 64, 0.8f);

    public static readonly Material QUARTZ_BRICKS = new(402, "quartz_bricks", true, false, false, true, false, false,
        true, true, false, false, 64, 0.8f);

    public static readonly Material QUARTZ_PILLAR = new(403, "quartz_pillar", true, false, false, true, false, false,
        true, true, false, false, 64, 0.8f);

    public static readonly Material QUARTZ_STAIRS = new(404, "quartz_stairs", true, false, false, true, false, false,
        false, true, false, true, 64, 0.8f);

    public static readonly Material WHITE_TERRACOTTA = new(405, "white_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material ORANGE_TERRACOTTA = new(406, "orange_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material MAGENTA_TERRACOTTA = new(407, "magenta_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material LIGHT_BLUE_TERRACOTTA = new(408, "light_blue_terracotta", true, false, false, true,
        false, false, true, true, false, false, 64, 4.2f);

    public static readonly Material YELLOW_TERRACOTTA = new(409, "yellow_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material LIME_TERRACOTTA = new(410, "lime_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material PINK_TERRACOTTA = new(411, "pink_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material GRAY_TERRACOTTA = new(412, "gray_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material LIGHT_GRAY_TERRACOTTA = new(413, "light_gray_terracotta", true, false, false, true,
        false, false, true, true, false, false, 64, 4.2f);

    public static readonly Material CYAN_TERRACOTTA = new(414, "cyan_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material PURPLE_TERRACOTTA = new(415, "purple_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material BLUE_TERRACOTTA = new(416, "blue_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material BROWN_TERRACOTTA = new(417, "brown_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material GREEN_TERRACOTTA = new(418, "green_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material RED_TERRACOTTA = new(419, "red_terracotta", true, false, false, true, false, false,
        true, true, false, false, 64, 4.2f);

    public static readonly Material BLACK_TERRACOTTA = new(420, "black_terracotta", true, false, false, true, false,
        false, true, true, false, false, 64, 4.2f);

    public static readonly Material BARRIER = new(421, "barrier", true, false, false, true, false, false, true, true,
        false, false, 64, 3600000.8f);

    public static readonly Material LIGHT = new(422, "light", true, false, false, true, false, false, false, false,
        false, true, 64, 3600000.8f);

    public static readonly Material HAY_BLOCK = new(423, "hay_block", true, true, false, true, false, false, true, true,
        false, false, 64, 0.5f);

    public static readonly Material WHITE_CARPET = new(424, "white_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material ORANGE_CARPET = new(425, "orange_carpet", true, true, true, true, false, true,
        false, false, false, false, 64, 0.1f);

    public static readonly Material MAGENTA_CARPET = new(426, "magenta_carpet", true, true, true, true, false, true,
        false, false, false, false, 64, 0.1f);

    public static readonly Material LIGHT_BLUE_CARPET = new(427, "light_blue_carpet", true, true, true, true, false,
        true, false, false, false, false, 64, 0.1f);

    public static readonly Material YELLOW_CARPET = new(428, "yellow_carpet", true, true, true, true, false, true,
        false, false, false, false, 64, 0.1f);

    public static readonly Material LIME_CARPET = new(429, "lime_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material PINK_CARPET = new(430, "pink_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material GRAY_CARPET = new(431, "gray_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material LIGHT_GRAY_CARPET = new(432, "light_gray_carpet", true, true, true, true, false,
        true, false, false, false, false, 64, 0.1f);

    public static readonly Material CYAN_CARPET = new(433, "cyan_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material PURPLE_CARPET = new(434, "purple_carpet", true, true, true, true, false, true,
        false, false, false, false, 64, 0.1f);

    public static readonly Material BLUE_CARPET = new(435, "blue_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material BROWN_CARPET = new(436, "brown_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material GREEN_CARPET = new(437, "green_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material RED_CARPET = new(438, "red_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material BLACK_CARPET = new(439, "black_carpet", true, true, true, true, false, true, false,
        false, false, false, 64, 0.1f);

    public static readonly Material TERRACOTTA = new(440, "terracotta", true, false, false, true, false, false, true,
        true, false, false, 64, 4.2f);

    public static readonly Material PACKED_ICE = new(441, "packed_ice", true, false, false, true, false, false, true,
        true, false, false, 64, 0.5f);

    public static readonly Material DIRT_PATH = new(442, "dirt_path", true, false, false, true, false, false, false,
        true, false, false, 64, 0.65f);

    public static readonly Material SUNFLOWER = new(443, "sunflower", true, true, false, true, false, true, false,
        false, false, false, 64, 0.0f);

    public static readonly Material LILAC = new(444, "lilac", true, true, false, true, false, true, false, false, false,
        false, 64, 0.0f);

    public static readonly Material ROSE_BUSH = new(445, "rose_bush", true, true, false, true, false, true, false,
        false, false, false, 64, 0.0f);

    public static readonly Material PEONY = new(446, "peony", true, true, false, true, false, true, false, false, false,
        false, 64, 0.0f);

    public static readonly Material TALL_GRASS = new(447, "tall_grass", true, true, false, true, false, true, false,
        false, false, false, 64, 0.0f);

    public static readonly Material LARGE_FERN = new(448, "large_fern", true, true, false, true, false, true, false,
        false, false, false, 64, 0.0f);

    public static readonly Material WHITE_STAINED_GLASS = new(449, "white_stained_glass", true, false, false, true,
        false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material ORANGE_STAINED_GLASS = new(450, "orange_stained_glass", true, false, false, true,
        false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material MAGENTA_STAINED_GLASS = new(451, "magenta_stained_glass", true, false, false, true,
        false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material LIGHT_BLUE_STAINED_GLASS = new(452, "light_blue_stained_glass", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material YELLOW_STAINED_GLASS = new(453, "yellow_stained_glass", true, false, false, true,
        false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material LIME_STAINED_GLASS = new(454, "lime_stained_glass", true, false, false, true, false,
        false, false, true, false, false, 64, 0.3f);

    public static readonly Material PINK_STAINED_GLASS = new(455, "pink_stained_glass", true, false, false, true, false,
        false, false, true, false, false, 64, 0.3f);

    public static readonly Material GRAY_STAINED_GLASS = new(456, "gray_stained_glass", true, false, false, true, false,
        false, false, true, false, false, 64, 0.3f);

    public static readonly Material LIGHT_GRAY_STAINED_GLASS = new(457, "light_gray_stained_glass", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material CYAN_STAINED_GLASS = new(458, "cyan_stained_glass", true, false, false, true, false,
        false, false, true, false, false, 64, 0.3f);

    public static readonly Material PURPLE_STAINED_GLASS = new(459, "purple_stained_glass", true, false, false, true,
        false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material BLUE_STAINED_GLASS = new(460, "blue_stained_glass", true, false, false, true, false,
        false, false, true, false, false, 64, 0.3f);

    public static readonly Material BROWN_STAINED_GLASS = new(461, "brown_stained_glass", true, false, false, true,
        false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material GREEN_STAINED_GLASS = new(462, "green_stained_glass", true, false, false, true,
        false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material RED_STAINED_GLASS = new(463, "red_stained_glass", true, false, false, true, false,
        false, false, true, false, false, 64, 0.3f);

    public static readonly Material BLACK_STAINED_GLASS = new(464, "black_stained_glass", true, false, false, true,
        false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material WHITE_STAINED_GLASS_PANE = new(465, "white_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material ORANGE_STAINED_GLASS_PANE = new(466, "orange_stained_glass_pane", true, false,
        false, true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material MAGENTA_STAINED_GLASS_PANE = new(467, "magenta_stained_glass_pane", true, false,
        false, true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material LIGHT_BLUE_STAINED_GLASS_PANE = new(468, "light_blue_stained_glass_pane", true,
        false, false, true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material YELLOW_STAINED_GLASS_PANE = new(469, "yellow_stained_glass_pane", true, false,
        false, true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material LIME_STAINED_GLASS_PANE = new(470, "lime_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material PINK_STAINED_GLASS_PANE = new(471, "pink_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material GRAY_STAINED_GLASS_PANE = new(472, "gray_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material LIGHT_GRAY_STAINED_GLASS_PANE = new(473, "light_gray_stained_glass_pane", true,
        false, false, true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material CYAN_STAINED_GLASS_PANE = new(474, "cyan_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material PURPLE_STAINED_GLASS_PANE = new(475, "purple_stained_glass_pane", true, false,
        false, true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material BLUE_STAINED_GLASS_PANE = new(476, "blue_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material BROWN_STAINED_GLASS_PANE = new(477, "brown_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material GREEN_STAINED_GLASS_PANE = new(478, "green_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material RED_STAINED_GLASS_PANE = new(479, "red_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material BLACK_STAINED_GLASS_PANE = new(480, "black_stained_glass_pane", true, false, false,
        true, false, false, false, true, false, false, 64, 0.3f);

    public static readonly Material PRISMARINE = new(481, "prismarine", true, false, false, true, false, false, true,
        true, false, false, 64, 6.0f);

    public static readonly Material PRISMARINE_BRICKS = new(482, "prismarine_bricks", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material DARK_PRISMARINE = new(483, "dark_prismarine", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material PRISMARINE_STAIRS = new(484, "prismarine_stairs", true, false, false, true, false,
        false, false, true, false, true, 64, 6.0f);

    public static readonly Material PRISMARINE_BRICK_STAIRS = new(485, "prismarine_brick_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material DARK_PRISMARINE_STAIRS = new(486, "dark_prismarine_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material SEA_LANTERN = new(487, "sea_lantern", true, false, false, true, false, false, false,
        true, false, false, 64, 0.3f);

    public static readonly Material RED_SANDSTONE = new(488, "red_sandstone", true, false, false, true, false, false,
        true, true, false, false, 64, 0.8f);

    public static readonly Material CHISELED_RED_SANDSTONE = new(489, "chiseled_red_sandstone", true, false, false,
        true, false, false, true, true, false, false, 64, 0.8f);

    public static readonly Material CUT_RED_SANDSTONE = new(490, "cut_red_sandstone", true, false, false, true, false,
        false, true, true, false, false, 64, 0.8f);

    public static readonly Material RED_SANDSTONE_STAIRS = new(491, "red_sandstone_stairs", true, false, false, true,
        false, false, false, true, false, true, 64, 0.8f);

    public static readonly Material REPEATING_COMMAND_BLOCK = new(492, "repeating_command_block", true, false, false,
        true, false, false, true, true, false, true, 64, 3600000.0f);

    public static readonly Material CHAIN_COMMAND_BLOCK = new(493, "chain_command_block", true, false, false, true,
        false, false, true, true, false, true, 64, 3600000.0f);

    public static readonly Material MAGMA_BLOCK = new(494, "magma_block", true, false, false, true, false, false, true,
        true, false, false, 64, 0.5f);

    public static readonly Material NETHER_WART_BLOCK = new(495, "nether_wart_block", true, false, false, true, false,
        false, true, true, false, false, 64, 1.0f);

    public static readonly Material WARPED_WART_BLOCK = new(496, "warped_wart_block", true, false, false, true, false,
        false, true, true, false, false, 64, 1.0f);

    public static readonly Material RED_NETHER_BRICKS = new(497, "red_nether_bricks", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material BONE_BLOCK = new(498, "bone_block", true, false, false, true, false, false, true,
        true, false, false, 64, 2.0f);

    public static readonly Material STRUCTURE_VOID = new(499, "structure_void", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material SHULKER_BOX = new(500, "shulker_box", true, false, false, true, false, false, true,
        true, false, true, 1, 2.0f);

    public static readonly Material WHITE_SHULKER_BOX = new(501, "white_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material ORANGE_SHULKER_BOX = new(502, "orange_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material MAGENTA_SHULKER_BOX = new(503, "magenta_shulker_box", true, false, false, true,
        false, false, true, true, false, true, 1, 2.0f);

    public static readonly Material LIGHT_BLUE_SHULKER_BOX = new(504, "light_blue_shulker_box", true, false, false,
        true, false, false, true, true, false, true, 1, 2.0f);

    public static readonly Material YELLOW_SHULKER_BOX = new(505, "yellow_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material LIME_SHULKER_BOX = new(506, "lime_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material PINK_SHULKER_BOX = new(507, "pink_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material GRAY_SHULKER_BOX = new(508, "gray_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material LIGHT_GRAY_SHULKER_BOX = new(509, "light_gray_shulker_box", true, false, false,
        true, false, false, true, true, false, true, 1, 2.0f);

    public static readonly Material CYAN_SHULKER_BOX = new(510, "cyan_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material PURPLE_SHULKER_BOX = new(511, "purple_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material BLUE_SHULKER_BOX = new(512, "blue_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material BROWN_SHULKER_BOX = new(513, "brown_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material GREEN_SHULKER_BOX = new(514, "green_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material RED_SHULKER_BOX = new(515, "red_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material BLACK_SHULKER_BOX = new(516, "black_shulker_box", true, false, false, true, false,
        false, true, true, false, true, 1, 2.0f);

    public static readonly Material WHITE_GLAZED_TERRACOTTA = new(517, "white_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material ORANGE_GLAZED_TERRACOTTA = new(518, "orange_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material MAGENTA_GLAZED_TERRACOTTA = new(519, "magenta_glazed_terracotta", true, false,
        false, true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material LIGHT_BLUE_GLAZED_TERRACOTTA = new(520, "light_blue_glazed_terracotta", true, false,
        false, true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material YELLOW_GLAZED_TERRACOTTA = new(521, "yellow_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material LIME_GLAZED_TERRACOTTA = new(522, "lime_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material PINK_GLAZED_TERRACOTTA = new(523, "pink_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material GRAY_GLAZED_TERRACOTTA = new(524, "gray_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material LIGHT_GRAY_GLAZED_TERRACOTTA = new(525, "light_gray_glazed_terracotta", true, false,
        false, true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material CYAN_GLAZED_TERRACOTTA = new(526, "cyan_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material PURPLE_GLAZED_TERRACOTTA = new(527, "purple_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material BLUE_GLAZED_TERRACOTTA = new(528, "blue_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material BROWN_GLAZED_TERRACOTTA = new(529, "brown_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material GREEN_GLAZED_TERRACOTTA = new(530, "green_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material RED_GLAZED_TERRACOTTA = new(531, "red_glazed_terracotta", true, false, false, true,
        false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material BLACK_GLAZED_TERRACOTTA = new(532, "black_glazed_terracotta", true, false, false,
        true, false, false, true, true, false, false, 64, 1.4f);

    public static readonly Material WHITE_CONCRETE = new(533, "white_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material ORANGE_CONCRETE = new(534, "orange_concrete", true, false, false, true, false,
        false, true, true, false, false, 64, 1.8f);

    public static readonly Material MAGENTA_CONCRETE = new(535, "magenta_concrete", true, false, false, true, false,
        false, true, true, false, false, 64, 1.8f);

    public static readonly Material LIGHT_BLUE_CONCRETE = new(536, "light_blue_concrete", true, false, false, true,
        false, false, true, true, false, false, 64, 1.8f);

    public static readonly Material YELLOW_CONCRETE = new(537, "yellow_concrete", true, false, false, true, false,
        false, true, true, false, false, 64, 1.8f);

    public static readonly Material LIME_CONCRETE = new(538, "lime_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material PINK_CONCRETE = new(539, "pink_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material GRAY_CONCRETE = new(540, "gray_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material LIGHT_GRAY_CONCRETE = new(541, "light_gray_concrete", true, false, false, true,
        false, false, true, true, false, false, 64, 1.8f);

    public static readonly Material CYAN_CONCRETE = new(542, "cyan_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material PURPLE_CONCRETE = new(543, "purple_concrete", true, false, false, true, false,
        false, true, true, false, false, 64, 1.8f);

    public static readonly Material BLUE_CONCRETE = new(544, "blue_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material BROWN_CONCRETE = new(545, "brown_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material GREEN_CONCRETE = new(546, "green_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material RED_CONCRETE = new(547, "red_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material BLACK_CONCRETE = new(548, "black_concrete", true, false, false, true, false, false,
        true, true, false, false, 64, 1.8f);

    public static readonly Material WHITE_CONCRETE_POWDER = new(549, "white_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material ORANGE_CONCRETE_POWDER = new(550, "orange_concrete_powder", true, false, false,
        true, false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material MAGENTA_CONCRETE_POWDER = new(551, "magenta_concrete_powder", true, false, false,
        true, false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material LIGHT_BLUE_CONCRETE_POWDER = new(552, "light_blue_concrete_powder", true, false,
        false, true, false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material YELLOW_CONCRETE_POWDER = new(553, "yellow_concrete_powder", true, false, false,
        true, false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material LIME_CONCRETE_POWDER = new(554, "lime_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material PINK_CONCRETE_POWDER = new(555, "pink_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material GRAY_CONCRETE_POWDER = new(556, "gray_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material LIGHT_GRAY_CONCRETE_POWDER = new(557, "light_gray_concrete_powder", true, false,
        false, true, false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material CYAN_CONCRETE_POWDER = new(558, "cyan_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material PURPLE_CONCRETE_POWDER = new(559, "purple_concrete_powder", true, false, false,
        true, false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material BLUE_CONCRETE_POWDER = new(560, "blue_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material BROWN_CONCRETE_POWDER = new(561, "brown_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material GREEN_CONCRETE_POWDER = new(562, "green_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material RED_CONCRETE_POWDER = new(563, "red_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material BLACK_CONCRETE_POWDER = new(564, "black_concrete_powder", true, false, false, true,
        false, false, true, true, false, false, 64, 0.5f);

    public static readonly Material TURTLE_EGG = new(565, "turtle_egg", true, false, false, true, false, false, false,
        true, false, false, 64, 0.5f);

    public static readonly Material SNIFFER_EGG = new(566, "sniffer_egg", true, false, false, true, false, false, false,
        true, false, false, 64, 0.5f);

    public static readonly Material DEAD_TUBE_CORAL_BLOCK = new(567, "dead_tube_coral_block", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material DEAD_BRAIN_CORAL_BLOCK = new(568, "dead_brain_coral_block", true, false, false,
        true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material DEAD_BUBBLE_CORAL_BLOCK = new(569, "dead_bubble_coral_block", true, false, false,
        true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material DEAD_FIRE_CORAL_BLOCK = new(570, "dead_fire_coral_block", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material DEAD_HORN_CORAL_BLOCK = new(571, "dead_horn_coral_block", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material TUBE_CORAL_BLOCK = new(572, "tube_coral_block", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material BRAIN_CORAL_BLOCK = new(573, "brain_coral_block", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material BUBBLE_CORAL_BLOCK = new(574, "bubble_coral_block", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material FIRE_CORAL_BLOCK = new(575, "fire_coral_block", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material HORN_CORAL_BLOCK = new(576, "horn_coral_block", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material TUBE_CORAL = new(577, "tube_coral", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BRAIN_CORAL = new(578, "brain_coral", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BUBBLE_CORAL = new(579, "bubble_coral", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material FIRE_CORAL = new(580, "fire_coral", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material HORN_CORAL = new(581, "horn_coral", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material DEAD_BRAIN_CORAL = new(582, "dead_brain_coral", true, false, false, true, false,
        false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_BUBBLE_CORAL = new(583, "dead_bubble_coral", true, false, false, true, false,
        false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_FIRE_CORAL = new(584, "dead_fire_coral", true, false, false, true, false,
        false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_HORN_CORAL = new(585, "dead_horn_coral", true, false, false, true, false,
        false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_TUBE_CORAL = new(586, "dead_tube_coral", true, false, false, true, false,
        false, false, true, false, false, 64, 0.0f);

    public static readonly Material TUBE_CORAL_FAN = new(587, "tube_coral_fan", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BRAIN_CORAL_FAN = new(588, "brain_coral_fan", true, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material BUBBLE_CORAL_FAN = new(589, "bubble_coral_fan", true, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material FIRE_CORAL_FAN = new(590, "fire_coral_fan", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material HORN_CORAL_FAN = new(591, "horn_coral_fan", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material DEAD_TUBE_CORAL_FAN = new(592, "dead_tube_coral_fan", true, false, false, true,
        false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_BRAIN_CORAL_FAN = new(593, "dead_brain_coral_fan", true, false, false, true,
        false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_BUBBLE_CORAL_FAN = new(594, "dead_bubble_coral_fan", true, false, false, true,
        false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_FIRE_CORAL_FAN = new(595, "dead_fire_coral_fan", true, false, false, true,
        false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_HORN_CORAL_FAN = new(596, "dead_horn_coral_fan", true, false, false, true,
        false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material BLUE_ICE = new(597, "blue_ice", true, false, false, true, false, false, true, true,
        false, false, 64, 2.8f);

    public static readonly Material CONDUIT = new(598, "conduit", true, false, false, true, false, false, false, true,
        false, false, 64, 3.0f);

    public static readonly Material POLISHED_GRANITE_STAIRS = new(599, "polished_granite_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material SMOOTH_RED_SANDSTONE_STAIRS = new(600, "smooth_red_sandstone_stairs", true, false,
        false, true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material MOSSY_STONE_BRICK_STAIRS = new(601, "mossy_stone_brick_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material POLISHED_DIORITE_STAIRS = new(602, "polished_diorite_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material MOSSY_COBBLESTONE_STAIRS = new(603, "mossy_cobblestone_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material END_STONE_BRICK_STAIRS = new(604, "end_stone_brick_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 9.0f);

    public static readonly Material STONE_STAIRS = new(605, "stone_stairs", true, false, false, true, false, false,
        false, true, false, true, 64, 6.0f);

    public static readonly Material SMOOTH_SANDSTONE_STAIRS = new(606, "smooth_sandstone_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material SMOOTH_QUARTZ_STAIRS = new(607, "smooth_quartz_stairs", true, false, false, true,
        false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material GRANITE_STAIRS = new(608, "granite_stairs", true, false, false, true, false, false,
        false, true, false, true, 64, 6.0f);

    public static readonly Material ANDESITE_STAIRS = new(609, "andesite_stairs", true, false, false, true, false,
        false, false, true, false, true, 64, 6.0f);

    public static readonly Material RED_NETHER_BRICK_STAIRS = new(610, "red_nether_brick_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material POLISHED_ANDESITE_STAIRS = new(611, "polished_andesite_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material DIORITE_STAIRS = new(612, "diorite_stairs", true, false, false, true, false, false,
        false, true, false, true, 64, 6.0f);

    public static readonly Material COBBLED_DEEPSLATE_STAIRS = new(613, "cobbled_deepslate_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material POLISHED_DEEPSLATE_STAIRS = new(614, "polished_deepslate_stairs", true, false,
        false, true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material DEEPSLATE_BRICK_STAIRS = new(615, "deepslate_brick_stairs", true, false, false,
        true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material DEEPSLATE_TILE_STAIRS = new(616, "deepslate_tile_stairs", true, false, false, true,
        false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material POLISHED_GRANITE_SLAB = new(617, "polished_granite_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material SMOOTH_RED_SANDSTONE_SLAB = new(618, "smooth_red_sandstone_slab", true, false,
        false, true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material MOSSY_STONE_BRICK_SLAB = new(619, "mossy_stone_brick_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_DIORITE_SLAB = new(620, "polished_diorite_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material MOSSY_COBBLESTONE_SLAB = new(621, "mossy_cobblestone_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material END_STONE_BRICK_SLAB = new(622, "end_stone_brick_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 9.0f);

    public static readonly Material SMOOTH_SANDSTONE_SLAB = new(623, "smooth_sandstone_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material SMOOTH_QUARTZ_SLAB = new(624, "smooth_quartz_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material GRANITE_SLAB = new(625, "granite_slab", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material ANDESITE_SLAB = new(626, "andesite_slab", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material RED_NETHER_BRICK_SLAB = new(627, "red_nether_brick_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_ANDESITE_SLAB = new(628, "polished_andesite_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material DIORITE_SLAB = new(629, "diorite_slab", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material COBBLED_DEEPSLATE_SLAB = new(630, "cobbled_deepslate_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_DEEPSLATE_SLAB = new(631, "polished_deepslate_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material DEEPSLATE_BRICK_SLAB = new(632, "deepslate_brick_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material DEEPSLATE_TILE_SLAB = new(633, "deepslate_tile_slab", true, false, false, true,
        false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material SCAFFOLDING = new(634, "scaffolding", true, true, true, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material REDSTONE = new(635, "redstone", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material REDSTONE_TORCH = new(636, "redstone_torch", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material REDSTONE_BLOCK = new(637, "redstone_block", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material REPEATER = new(638, "repeater", true, false, false, true, false, false, false,
        false, false, true, 64, 0.0f);

    public static readonly Material COMPARATOR = new(639, "comparator", true, false, false, true, false, false, false,
        false, false, true, 64, 0.0f);

    public static readonly Material PISTON = new(640, "piston", true, false, false, true, false, false, false, true,
        false, false, 64, 1.5f);

    public static readonly Material STICKY_PISTON = new(641, "sticky_piston", true, false, false, true, false, false,
        false, true, false, false, 64, 1.5f);

    public static readonly Material SLIME_BLOCK = new(642, "slime_block", true, false, false, true, false, false, true,
        true, false, false, 64, 0.0f);

    public static readonly Material HONEY_BLOCK = new(643, "honey_block", true, false, false, true, false, false, false,
        true, false, false, 64, 0.0f);

    public static readonly Material OBSERVER = new(644, "observer", true, false, false, true, false, false, false, true,
        false, false, 64, 3.0f);

    public static readonly Material HOPPER = new(645, "hopper", true, false, false, true, false, false, false, true,
        false, true, 64, 4.8f);

    public static readonly Material DISPENSER = new(646, "dispenser", true, false, false, true, false, false, true,
        true, false, true, 64, 3.5f);

    public static readonly Material DROPPER = new(647, "dropper", true, false, false, true, false, false, true, true,
        false, true, 64, 3.5f);

    public static readonly Material LECTERN = new(648, "lectern", true, true, true, true, false, true, false, true,
        false, true, 64, 2.5f);

    public static readonly Material TARGET = new(649, "target", true, true, false, true, false, false, true, true,
        false, false, 64, 0.5f);

    public static readonly Material LEVER = new(650, "lever", true, false, false, true, false, false, false, false,
        false, true, 64, 0.5f);

    public static readonly Material LIGHTNING_ROD = new(651, "lightning_rod", true, false, false, true, false, false,
        false, true, false, false, 64, 6.0f);

    public static readonly Material DAYLIGHT_DETECTOR = new(652, "daylight_detector", true, false, true, true, false,
        true, false, true, false, true, 64, 0.2f);

    public static readonly Material SCULK_SENSOR = new(653, "sculk_sensor", true, false, false, true, false, false,
        false, true, false, false, 64, 1.5f);

    public static readonly Material CALIBRATED_SCULK_SENSOR = new(654, "calibrated_sculk_sensor", true, false, false,
        true, false, false, false, true, false, false, 64, 1.5f);

    public static readonly Material TRIPWIRE_HOOK = new(655, "tripwire_hook", true, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material TRAPPED_CHEST = new(656, "trapped_chest", true, false, true, true, false, true,
        false, true, false, true, 64, 2.5f);

    public static readonly Material TNT = new(657, "tnt", true, true, false, true, false, true, false, true, false,
        true, 64, 0.0f);

    public static readonly Material REDSTONE_LAMP = new(658, "redstone_lamp", true, false, false, true, false, false,
        true, true, false, false, 64, 0.3f);

    public static readonly Material NOTE_BLOCK = new(659, "note_block", true, false, true, true, false, true, true,
        true, false, true, 64, 0.8f);

    public static readonly Material STONE_BUTTON = new(660, "stone_button", true, false, false, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material POLISHED_BLACKSTONE_BUTTON = new(661, "polished_blackstone_button", true, false,
        false, true, false, false, false, false, false, true, 64, 0.5f);

    public static readonly Material OAK_BUTTON = new(662, "oak_button", true, false, true, true, false, false, false,
        false, false, true, 64, 0.5f);

    public static readonly Material SPRUCE_BUTTON = new(663, "spruce_button", true, false, true, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material BIRCH_BUTTON = new(664, "birch_button", true, false, true, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material JUNGLE_BUTTON = new(665, "jungle_button", true, false, true, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material ACACIA_BUTTON = new(666, "acacia_button", true, false, true, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material CHERRY_BUTTON = new(667, "cherry_button", true, false, true, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material DARK_OAK_BUTTON = new(668, "dark_oak_button", true, false, true, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material MANGROVE_BUTTON = new(669, "mangrove_button", true, false, true, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material BAMBOO_BUTTON = new(670, "bamboo_button", true, false, true, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material CRIMSON_BUTTON = new(671, "crimson_button", true, false, false, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material WARPED_BUTTON = new(672, "warped_button", true, false, false, true, false, false,
        false, false, false, true, 64, 0.5f);

    public static readonly Material STONE_PRESSURE_PLATE = new(673, "stone_pressure_plate", true, false, false, true,
        false, false, false, true, false, false, 64, 0.5f);

    public static readonly Material POLISHED_BLACKSTONE_PRESSURE_PLATE = new(674, "polished_blackstone_pressure_plate",
        true, false, false, true, false, false, false, true, false, false, 64, 0.5f);

    public static readonly Material LIGHT_WEIGHTED_PRESSURE_PLATE = new(675, "light_weighted_pressure_plate", true,
        false, false, true, false, false, false, true, false, false, 64, 0.5f);

    public static readonly Material HEAVY_WEIGHTED_PRESSURE_PLATE = new(676, "heavy_weighted_pressure_plate", true,
        false, false, true, false, false, false, true, false, false, 64, 0.5f);

    public static readonly Material OAK_PRESSURE_PLATE = new(677, "oak_pressure_plate", true, false, true, true, false,
        true, false, true, false, false, 64, 0.5f);

    public static readonly Material SPRUCE_PRESSURE_PLATE = new(678, "spruce_pressure_plate", true, false, true, true,
        false, true, false, true, false, false, 64, 0.5f);

    public static readonly Material BIRCH_PRESSURE_PLATE = new(679, "birch_pressure_plate", true, false, true, true,
        false, true, false, true, false, false, 64, 0.5f);

    public static readonly Material JUNGLE_PRESSURE_PLATE = new(680, "jungle_pressure_plate", true, false, true, true,
        false, true, false, true, false, false, 64, 0.5f);

    public static readonly Material ACACIA_PRESSURE_PLATE = new(681, "acacia_pressure_plate", true, false, true, true,
        false, true, false, true, false, false, 64, 0.5f);

    public static readonly Material CHERRY_PRESSURE_PLATE = new(682, "cherry_pressure_plate", true, false, true, true,
        false, true, false, true, false, false, 64, 0.5f);

    public static readonly Material DARK_OAK_PRESSURE_PLATE = new(683, "dark_oak_pressure_plate", true, false, true,
        true, false, true, false, true, false, false, 64, 0.5f);

    public static readonly Material MANGROVE_PRESSURE_PLATE = new(684, "mangrove_pressure_plate", true, false, true,
        true, false, true, false, true, false, false, 64, 0.5f);

    public static readonly Material BAMBOO_PRESSURE_PLATE = new(685, "bamboo_pressure_plate", true, false, true, true,
        false, true, false, true, false, false, 64, 0.5f);

    public static readonly Material CRIMSON_PRESSURE_PLATE = new(686, "crimson_pressure_plate", true, false, false,
        true, false, false, false, true, false, false, 64, 0.5f);

    public static readonly Material WARPED_PRESSURE_PLATE = new(687, "warped_pressure_plate", true, false, false, true,
        false, false, false, true, false, false, 64, 0.5f);

    public static readonly Material IRON_DOOR = new(688, "iron_door", true, false, false, true, false, false, false,
        true, false, true, 64, 5.0f);

    public static readonly Material OAK_DOOR = new(689, "oak_door", true, false, true, true, false, true, false, true,
        false, true, 64, 3.0f);

    public static readonly Material SPRUCE_DOOR = new(690, "spruce_door", true, false, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material BIRCH_DOOR = new(691, "birch_door", true, false, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material JUNGLE_DOOR = new(692, "jungle_door", true, false, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material ACACIA_DOOR = new(693, "acacia_door", true, false, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material CHERRY_DOOR = new(694, "cherry_door", true, false, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material DARK_OAK_DOOR = new(695, "dark_oak_door", true, false, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material MANGROVE_DOOR = new(696, "mangrove_door", true, false, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material BAMBOO_DOOR = new(697, "bamboo_door", true, false, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material CRIMSON_DOOR = new(698, "crimson_door", true, false, false, true, false, false,
        false, true, false, true, 64, 3.0f);

    public static readonly Material WARPED_DOOR = new(699, "warped_door", true, false, false, true, false, false, false,
        true, false, true, 64, 3.0f);

    public static readonly Material IRON_TRAPDOOR = new(700, "iron_trapdoor", true, false, false, true, false, false,
        false, true, false, true, 64, 5.0f);

    public static readonly Material OAK_TRAPDOOR = new(701, "oak_trapdoor", true, false, true, true, false, true, false,
        true, false, true, 64, 3.0f);

    public static readonly Material SPRUCE_TRAPDOOR = new(702, "spruce_trapdoor", true, false, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material BIRCH_TRAPDOOR = new(703, "birch_trapdoor", true, false, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material JUNGLE_TRAPDOOR = new(704, "jungle_trapdoor", true, false, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material ACACIA_TRAPDOOR = new(705, "acacia_trapdoor", true, false, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material CHERRY_TRAPDOOR = new(706, "cherry_trapdoor", true, false, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material DARK_OAK_TRAPDOOR = new(707, "dark_oak_trapdoor", true, false, true, true, false,
        true, false, true, false, true, 64, 3.0f);

    public static readonly Material MANGROVE_TRAPDOOR = new(708, "mangrove_trapdoor", true, false, true, true, false,
        true, false, true, false, true, 64, 3.0f);

    public static readonly Material BAMBOO_TRAPDOOR = new(709, "bamboo_trapdoor", true, false, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material CRIMSON_TRAPDOOR = new(710, "crimson_trapdoor", true, false, false, true, false,
        false, false, true, false, true, 64, 3.0f);

    public static readonly Material WARPED_TRAPDOOR = new(711, "warped_trapdoor", true, false, false, true, false,
        false, false, true, false, true, 64, 3.0f);

    public static readonly Material OAK_FENCE_GATE = new(712, "oak_fence_gate", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material SPRUCE_FENCE_GATE = new(713, "spruce_fence_gate", true, true, true, true, false,
        true, false, true, false, true, 64, 3.0f);

    public static readonly Material BIRCH_FENCE_GATE = new(714, "birch_fence_gate", true, true, true, true, false, true,
        false, true, false, true, 64, 3.0f);

    public static readonly Material JUNGLE_FENCE_GATE = new(715, "jungle_fence_gate", true, true, true, true, false,
        true, false, true, false, true, 64, 3.0f);

    public static readonly Material ACACIA_FENCE_GATE = new(716, "acacia_fence_gate", true, true, true, true, false,
        true, false, true, false, true, 64, 3.0f);

    public static readonly Material CHERRY_FENCE_GATE = new(717, "cherry_fence_gate", true, true, true, true, false,
        true, false, true, false, true, 64, 3.0f);

    public static readonly Material DARK_OAK_FENCE_GATE = new(718, "dark_oak_fence_gate", true, true, true, true, false,
        true, false, true, false, true, 64, 3.0f);

    public static readonly Material MANGROVE_FENCE_GATE = new(719, "mangrove_fence_gate", true, true, true, true, false,
        true, false, true, false, true, 64, 3.0f);

    public static readonly Material BAMBOO_FENCE_GATE = new(720, "bamboo_fence_gate", true, true, true, true, false,
        true, false, true, false, true, 64, 3.0f);

    public static readonly Material CRIMSON_FENCE_GATE = new(721, "crimson_fence_gate", true, false, false, true, false,
        false, false, true, false, true, 64, 3.0f);

    public static readonly Material WARPED_FENCE_GATE = new(722, "warped_fence_gate", true, false, false, true, false,
        false, false, true, false, true, 64, 3.0f);

    public static readonly Material POWERED_RAIL = new(723, "powered_rail", true, false, false, true, false, false,
        false, false, false, false, 64, 0.7f);

    public static readonly Material DETECTOR_RAIL = new(724, "detector_rail", true, false, false, true, false, false,
        false, false, false, false, 64, 0.7f);

    public static readonly Material RAIL = new(725, "rail", true, false, false, true, false, false, false, false, false,
        false, 64, 0.7f);

    public static readonly Material ACTIVATOR_RAIL = new(726, "activator_rail", true, false, false, true, false, false,
        false, false, false, false, 64, 0.7f);

    public static readonly Material SADDLE = new(727, "saddle", false, false, false, true, false, false, false, false,
        false, false, 1, 0.0f);

    public static readonly Material MINECART = new(728, "minecart", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material CHEST_MINECART = new(729, "chest_minecart", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material FURNACE_MINECART = new(730, "furnace_minecart", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material TNT_MINECART = new(731, "tnt_minecart", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material HOPPER_MINECART = new(732, "hopper_minecart", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material CARROT_ON_A_STICK = new(733, "carrot_on_a_stick", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material WARPED_FUNGUS_ON_A_STICK = new(734, "warped_fungus_on_a_stick", false, false, false,
        true, false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material ELYTRA = new(735, "elytra", false, false, false, true, false, false, false, false,
        false, false, 1, 0.0f);

    public static readonly Material OAK_BOAT = new(736, "oak_boat", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material OAK_CHEST_BOAT = new(737, "oak_chest_boat", false, false, true, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material SPRUCE_BOAT = new(738, "spruce_boat", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material SPRUCE_CHEST_BOAT = new(739, "spruce_chest_boat", false, false, true, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material BIRCH_BOAT = new(740, "birch_boat", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material BIRCH_CHEST_BOAT = new(741, "birch_chest_boat", false, false, true, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material JUNGLE_BOAT = new(742, "jungle_boat", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material JUNGLE_CHEST_BOAT = new(743, "jungle_chest_boat", false, false, true, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material ACACIA_BOAT = new(744, "acacia_boat", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material ACACIA_CHEST_BOAT = new(745, "acacia_chest_boat", false, false, true, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material CHERRY_BOAT = new(746, "cherry_boat", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material CHERRY_CHEST_BOAT = new(747, "cherry_chest_boat", false, false, true, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material DARK_OAK_BOAT = new(748, "dark_oak_boat", false, false, true, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material DARK_OAK_CHEST_BOAT = new(749, "dark_oak_chest_boat", false, false, true, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material MANGROVE_BOAT = new(750, "mangrove_boat", false, false, true, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material MANGROVE_CHEST_BOAT = new(751, "mangrove_chest_boat", false, false, true, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material BAMBOO_RAFT = new(752, "bamboo_raft", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material BAMBOO_CHEST_RAFT = new(753, "bamboo_chest_raft", false, false, true, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material STRUCTURE_BLOCK = new(754, "structure_block", true, false, false, true, false,
        false, true, true, false, true, 64, 3600000.0f);

    public static readonly Material JIGSAW = new(755, "jigsaw", true, false, false, true, false, false, true, true,
        false, true, 64, 3600000.0f);

    public static readonly Material TURTLE_HELMET = new(756, "turtle_helmet", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material SCUTE = new(757, "scute", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material FLINT_AND_STEEL = new(758, "flint_and_steel", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material APPLE = new(759, "apple", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material BOW = new(760, "bow", false, false, true, true, false, false, false, false, false,
        false, 1, 0.0f);

    public static readonly Material ARROW = new(761, "arrow", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material COAL = new(762, "coal", false, false, true, true, false, false, false, false, false,
        false, 64, 0.0f);

    public static readonly Material CHARCOAL = new(763, "charcoal", false, false, true, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material DIAMOND = new(764, "diamond", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material EMERALD = new(765, "emerald", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material LAPIS_LAZULI = new(766, "lapis_lazuli", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material QUARTZ = new(767, "quartz", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material AMETHYST_SHARD = new(768, "amethyst_shard", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material RAW_IRON = new(769, "raw_iron", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material IRON_INGOT = new(770, "iron_ingot", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material RAW_COPPER = new(771, "raw_copper", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material COPPER_INGOT = new(772, "copper_ingot", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material RAW_GOLD = new(773, "raw_gold", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material GOLD_INGOT = new(774, "gold_ingot", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material NETHERITE_INGOT = new(775, "netherite_ingot", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material NETHERITE_SCRAP = new(776, "netherite_scrap", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material WOODEN_SWORD = new(777, "wooden_sword", false, false, true, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material WOODEN_SHOVEL = new(778, "wooden_shovel", false, false, true, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material WOODEN_PICKAXE = new(779, "wooden_pickaxe", false, false, true, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material WOODEN_AXE = new(780, "wooden_axe", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material WOODEN_HOE = new(781, "wooden_hoe", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material STONE_SWORD = new(782, "stone_sword", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material STONE_SHOVEL = new(783, "stone_shovel", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material STONE_PICKAXE = new(784, "stone_pickaxe", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material STONE_AXE = new(785, "stone_axe", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material STONE_HOE = new(786, "stone_hoe", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_SWORD = new(787, "golden_sword", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_SHOVEL = new(788, "golden_shovel", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_PICKAXE = new(789, "golden_pickaxe", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_AXE = new(790, "golden_axe", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_HOE = new(791, "golden_hoe", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material IRON_SWORD = new(792, "iron_sword", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material IRON_SHOVEL = new(793, "iron_shovel", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material IRON_PICKAXE = new(794, "iron_pickaxe", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material IRON_AXE = new(795, "iron_axe", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material IRON_HOE = new(796, "iron_hoe", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_SWORD = new(797, "diamond_sword", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_SHOVEL = new(798, "diamond_shovel", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_PICKAXE = new(799, "diamond_pickaxe", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_AXE = new(800, "diamond_axe", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_HOE = new(801, "diamond_hoe", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material NETHERITE_SWORD = new(802, "netherite_sword", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material NETHERITE_SHOVEL = new(803, "netherite_shovel", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material NETHERITE_PICKAXE = new(804, "netherite_pickaxe", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material NETHERITE_AXE = new(805, "netherite_axe", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material NETHERITE_HOE = new(806, "netherite_hoe", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material STICK = new(807, "stick", false, false, true, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material BOWL = new(808, "bowl", false, false, true, true, false, false, false, false, false,
        false, 64, 0.0f);

    public static readonly Material MUSHROOM_STEW = new(809, "mushroom_stew", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material STRING = new(810, "string", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material FEATHER = new(811, "feather", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material GUNPOWDER = new(812, "gunpowder", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material WHEAT_SEEDS = new(813, "wheat_seeds", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material WHEAT = new(814, "wheat", true, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material BREAD = new(815, "bread", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material LEATHER_HELMET = new(816, "leather_helmet", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material LEATHER_CHESTPLATE = new(817, "leather_chestplate", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material LEATHER_LEGGINGS = new(818, "leather_leggings", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material LEATHER_BOOTS = new(819, "leather_boots", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material CHAINMAIL_HELMET = new(820, "chainmail_helmet", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material CHAINMAIL_CHESTPLATE = new(821, "chainmail_chestplate", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material CHAINMAIL_LEGGINGS = new(822, "chainmail_leggings", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material CHAINMAIL_BOOTS = new(823, "chainmail_boots", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material IRON_HELMET = new(824, "iron_helmet", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material IRON_CHESTPLATE = new(825, "iron_chestplate", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material IRON_LEGGINGS = new(826, "iron_leggings", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material IRON_BOOTS = new(827, "iron_boots", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_HELMET = new(828, "diamond_helmet", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_CHESTPLATE = new(829, "diamond_chestplate", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_LEGGINGS = new(830, "diamond_leggings", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_BOOTS = new(831, "diamond_boots", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_HELMET = new(832, "golden_helmet", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_CHESTPLATE = new(833, "golden_chestplate", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_LEGGINGS = new(834, "golden_leggings", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_BOOTS = new(835, "golden_boots", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material NETHERITE_HELMET = new(836, "netherite_helmet", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material NETHERITE_CHESTPLATE = new(837, "netherite_chestplate", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material NETHERITE_LEGGINGS = new(838, "netherite_leggings", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material NETHERITE_BOOTS = new(839, "netherite_boots", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material FLINT = new(840, "flint", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material PORKCHOP = new(841, "porkchop", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material COOKED_PORKCHOP = new(842, "cooked_porkchop", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material PAINTING = new(843, "painting", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material GOLDEN_APPLE = new(844, "golden_apple", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material ENCHANTED_GOLDEN_APPLE = new(845, "enchanted_golden_apple", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material OAK_SIGN = new(846, "oak_sign", true, false, true, true, false, true, false, true,
        false, true, 16, 1.0f);

    public static readonly Material SPRUCE_SIGN = new(847, "spruce_sign", true, false, true, true, false, true, false,
        true, false, true, 16, 1.0f);

    public static readonly Material BIRCH_SIGN = new(848, "birch_sign", true, false, true, true, false, true, false,
        true, false, true, 16, 1.0f);

    public static readonly Material JUNGLE_SIGN = new(849, "jungle_sign", true, false, true, true, false, true, false,
        true, false, true, 16, 1.0f);

    public static readonly Material ACACIA_SIGN = new(850, "acacia_sign", true, false, true, true, false, true, false,
        true, false, true, 16, 1.0f);

    public static readonly Material CHERRY_SIGN = new(851, "cherry_sign", true, false, true, true, false, true, false,
        true, false, true, 16, 1.0f);

    public static readonly Material DARK_OAK_SIGN = new(852, "dark_oak_sign", true, false, true, true, false, true,
        false, true, false, true, 16, 1.0f);

    public static readonly Material MANGROVE_SIGN = new(853, "mangrove_sign", true, false, true, true, false, true,
        false, true, false, true, 16, 1.0f);

    public static readonly Material BAMBOO_SIGN = new(854, "bamboo_sign", true, false, true, true, false, true, false,
        true, false, true, 16, 1.0f);

    public static readonly Material CRIMSON_SIGN = new(855, "crimson_sign", true, false, false, true, false, false,
        false, true, false, true, 16, 1.0f);

    public static readonly Material WARPED_SIGN = new(856, "warped_sign", true, false, false, true, false, false, false,
        true, false, true, 16, 1.0f);

    public static readonly Material OAK_HANGING_SIGN = new(857, "oak_hanging_sign", true, false, true, true, false,
        true, false, true, false, true, 16, 1.0f);

    public static readonly Material SPRUCE_HANGING_SIGN = new(858, "spruce_hanging_sign", true, false, true, true,
        false, true, false, true, false, true, 16, 1.0f);

    public static readonly Material BIRCH_HANGING_SIGN = new(859, "birch_hanging_sign", true, false, true, true, false,
        true, false, true, false, true, 16, 1.0f);

    public static readonly Material JUNGLE_HANGING_SIGN = new(860, "jungle_hanging_sign", true, false, true, true,
        false, true, false, true, false, true, 16, 1.0f);

    public static readonly Material ACACIA_HANGING_SIGN = new(861, "acacia_hanging_sign", true, false, true, true,
        false, true, false, true, false, true, 16, 1.0f);

    public static readonly Material CHERRY_HANGING_SIGN = new(862, "cherry_hanging_sign", true, false, true, true,
        false, true, false, true, false, true, 16, 1.0f);

    public static readonly Material DARK_OAK_HANGING_SIGN = new(863, "dark_oak_hanging_sign", true, false, true, true,
        false, true, false, true, false, true, 16, 1.0f);

    public static readonly Material MANGROVE_HANGING_SIGN = new(864, "mangrove_hanging_sign", true, false, true, true,
        false, true, false, true, false, true, 16, 1.0f);

    public static readonly Material BAMBOO_HANGING_SIGN = new(865, "bamboo_hanging_sign", true, false, true, true,
        false, true, false, true, false, true, 16, 1.0f);

    public static readonly Material CRIMSON_HANGING_SIGN = new(866, "crimson_hanging_sign", true, false, false, true,
        false, false, false, true, false, true, 16, 1.0f);

    public static readonly Material WARPED_HANGING_SIGN = new(867, "warped_hanging_sign", true, false, false, true,
        false, false, false, true, false, true, 16, 1.0f);

    public static readonly Material BUCKET = new(868, "bucket", false, false, false, true, false, false, false, false,
        false, false, 16, 0.0f);

    public static readonly Material WATER_BUCKET = new(869, "water_bucket", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material LAVA_BUCKET = new(870, "lava_bucket", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material POWDER_SNOW_BUCKET = new(871, "powder_snow_bucket", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material SNOWBALL = new(872, "snowball", false, false, false, true, false, false, false,
        false, false, false, 16, 0.0f);

    public static readonly Material LEATHER = new(873, "leather", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material MILK_BUCKET = new(874, "milk_bucket", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material PUFFERFISH_BUCKET = new(875, "pufferfish_bucket", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material SALMON_BUCKET = new(876, "salmon_bucket", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material COD_BUCKET = new(877, "cod_bucket", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material TROPICAL_FISH_BUCKET = new(878, "tropical_fish_bucket", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material AXOLOTL_BUCKET = new(879, "axolotl_bucket", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material TADPOLE_BUCKET = new(880, "tadpole_bucket", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material BRICK = new(881, "brick", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material CLAY_BALL = new(882, "clay_ball", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material DRIED_KELP_BLOCK = new(883, "dried_kelp_block", true, true, true, true, false,
        false, true, true, false, false, 64, 2.5f);

    public static readonly Material PAPER = new(884, "paper", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material BOOK = new(885, "book", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material SLIME_BALL = new(886, "slime_ball", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material EGG = new(887, "egg", false, false, false, true, false, false, false, false, false,
        false, 16, 0.0f);

    public static readonly Material COMPASS = new(888, "compass", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material RECOVERY_COMPASS = new(889, "recovery_compass", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material BUNDLE = new(890, "bundle", false, false, false, true, false, false, false, false,
        false, false, 1, 0.0f);

    public static readonly Material FISHING_ROD = new(891, "fishing_rod", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material CLOCK = new(892, "clock", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material SPYGLASS = new(893, "spyglass", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material GLOWSTONE_DUST = new(894, "glowstone_dust", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material COD = new(895, "cod", false, false, false, true, false, false, false, false, false,
        false, 64, 0.0f);

    public static readonly Material SALMON = new(896, "salmon", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material TROPICAL_FISH = new(897, "tropical_fish", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material PUFFERFISH = new(898, "pufferfish", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material COOKED_COD = new(899, "cooked_cod", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material COOKED_SALMON = new(900, "cooked_salmon", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material INK_SAC = new(901, "ink_sac", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material GLOW_INK_SAC = new(902, "glow_ink_sac", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material COCOA_BEANS = new(903, "cocoa_beans", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material WHITE_DYE = new(904, "white_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material ORANGE_DYE = new(905, "orange_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material MAGENTA_DYE = new(906, "magenta_dye", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material LIGHT_BLUE_DYE = new(907, "light_blue_dye", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material YELLOW_DYE = new(908, "yellow_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material LIME_DYE = new(909, "lime_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material PINK_DYE = new(910, "pink_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material GRAY_DYE = new(911, "gray_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material LIGHT_GRAY_DYE = new(912, "light_gray_dye", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material CYAN_DYE = new(913, "cyan_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material PURPLE_DYE = new(914, "purple_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BLUE_DYE = new(915, "blue_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BROWN_DYE = new(916, "brown_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material GREEN_DYE = new(917, "green_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material RED_DYE = new(918, "red_dye", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material BLACK_DYE = new(919, "black_dye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BONE_MEAL = new(920, "bone_meal", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BONE = new(921, "bone", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material SUGAR = new(922, "sugar", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material CAKE = new(923, "cake", true, false, false, true, false, false, false, true, false,
        true, 1, 0.5f);

    public static readonly Material WHITE_BED = new(924, "white_bed", true, false, false, true, false, true, false,
        true, false, true, 1, 0.2f);

    public static readonly Material ORANGE_BED = new(925, "orange_bed", true, false, false, true, false, true, false,
        true, false, true, 1, 0.2f);

    public static readonly Material MAGENTA_BED = new(926, "magenta_bed", true, false, false, true, false, true, false,
        true, false, true, 1, 0.2f);

    public static readonly Material LIGHT_BLUE_BED = new(927, "light_blue_bed", true, false, false, true, false, true,
        false, true, false, true, 1, 0.2f);

    public static readonly Material YELLOW_BED = new(928, "yellow_bed", true, false, false, true, false, true, false,
        true, false, true, 1, 0.2f);

    public static readonly Material LIME_BED = new(929, "lime_bed", true, false, false, true, false, true, false, true,
        false, true, 1, 0.2f);

    public static readonly Material PINK_BED = new(930, "pink_bed", true, false, false, true, false, true, false, true,
        false, true, 1, 0.2f);

    public static readonly Material GRAY_BED = new(931, "gray_bed", true, false, false, true, false, true, false, true,
        false, true, 1, 0.2f);

    public static readonly Material LIGHT_GRAY_BED = new(932, "light_gray_bed", true, false, false, true, false, true,
        false, true, false, true, 1, 0.2f);

    public static readonly Material CYAN_BED = new(933, "cyan_bed", true, false, false, true, false, true, false, true,
        false, true, 1, 0.2f);

    public static readonly Material PURPLE_BED = new(934, "purple_bed", true, false, false, true, false, true, false,
        true, false, true, 1, 0.2f);

    public static readonly Material BLUE_BED = new(935, "blue_bed", true, false, false, true, false, true, false, true,
        false, true, 1, 0.2f);

    public static readonly Material BROWN_BED = new(936, "brown_bed", true, false, false, true, false, true, false,
        true, false, true, 1, 0.2f);

    public static readonly Material GREEN_BED = new(937, "green_bed", true, false, false, true, false, true, false,
        true, false, true, 1, 0.2f);

    public static readonly Material RED_BED = new(938, "red_bed", true, false, false, true, false, true, false, true,
        false, true, 1, 0.2f);

    public static readonly Material BLACK_BED = new(939, "black_bed", true, false, false, true, false, true, false,
        true, false, true, 1, 0.2f);

    public static readonly Material COOKIE = new(940, "cookie", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material FILLED_MAP = new(941, "filled_map", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material SHEARS = new(942, "shears", false, false, false, true, false, false, false, false,
        false, false, 1, 0.0f);

    public static readonly Material MELON_SLICE = new(943, "melon_slice", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material DRIED_KELP = new(944, "dried_kelp", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material PUMPKIN_SEEDS = new(945, "pumpkin_seeds", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material MELON_SEEDS = new(946, "melon_seeds", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BEEF = new(947, "beef", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material COOKED_BEEF = new(948, "cooked_beef", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material CHICKEN = new(949, "chicken", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material COOKED_CHICKEN = new(950, "cooked_chicken", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material ROTTEN_FLESH = new(951, "rotten_flesh", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material ENDER_PEARL = new(952, "ender_pearl", false, false, false, true, false, false,
        false, false, false, false, 16, 0.0f);

    public static readonly Material BLAZE_ROD = new(953, "blaze_rod", false, false, true, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material GHAST_TEAR = new(954, "ghast_tear", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material GOLD_NUGGET = new(955, "gold_nugget", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material NETHER_WART = new(956, "nether_wart", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material POTION = new(957, "potion", false, false, false, true, false, false, false, false,
        false, false, 1, 0.0f);

    public static readonly Material GLASS_BOTTLE = new(958, "glass_bottle", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material SPIDER_EYE = new(959, "spider_eye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material FERMENTED_SPIDER_EYE = new(960, "fermented_spider_eye", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material BLAZE_POWDER = new(961, "blaze_powder", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material MAGMA_CREAM = new(962, "magma_cream", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BREWING_STAND = new(963, "brewing_stand", true, false, false, true, false, false,
        false, true, false, true, 64, 0.5f);

    public static readonly Material CAULDRON = new(964, "cauldron", true, false, false, true, false, false, false, true,
        false, true, 64, 2.0f);

    public static readonly Material ENDER_EYE = new(965, "ender_eye", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material GLISTERING_MELON_SLICE = new(966, "glistering_melon_slice", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ALLAY_SPAWN_EGG = new(967, "allay_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material AXOLOTL_SPAWN_EGG = new(968, "axolotl_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material BAT_SPAWN_EGG = new(969, "bat_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BEE_SPAWN_EGG = new(970, "bee_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BLAZE_SPAWN_EGG = new(971, "blaze_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material CAT_SPAWN_EGG = new(972, "cat_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material CAMEL_SPAWN_EGG = new(973, "camel_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material CAVE_SPIDER_SPAWN_EGG = new(974, "cave_spider_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material CHICKEN_SPAWN_EGG = new(975, "chicken_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material COD_SPAWN_EGG = new(976, "cod_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material COW_SPAWN_EGG = new(977, "cow_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material CREEPER_SPAWN_EGG = new(978, "creeper_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material DOLPHIN_SPAWN_EGG = new(979, "dolphin_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material DONKEY_SPAWN_EGG = new(980, "donkey_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material DROWNED_SPAWN_EGG = new(981, "drowned_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material ELDER_GUARDIAN_SPAWN_EGG = new(982, "elder_guardian_spawn_egg", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ENDER_DRAGON_SPAWN_EGG = new(983, "ender_dragon_spawn_egg", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ENDERMAN_SPAWN_EGG = new(984, "enderman_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ENDERMITE_SPAWN_EGG = new(985, "endermite_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material EVOKER_SPAWN_EGG = new(986, "evoker_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material FOX_SPAWN_EGG = new(987, "fox_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material FROG_SPAWN_EGG = new(988, "frog_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material GHAST_SPAWN_EGG = new(989, "ghast_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material GLOW_SQUID_SPAWN_EGG = new(990, "glow_squid_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material GOAT_SPAWN_EGG = new(991, "goat_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material GUARDIAN_SPAWN_EGG = new(992, "guardian_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material HOGLIN_SPAWN_EGG = new(993, "hoglin_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material HORSE_SPAWN_EGG = new(994, "horse_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material HUSK_SPAWN_EGG = new(995, "husk_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material IRON_GOLEM_SPAWN_EGG = new(996, "iron_golem_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material LLAMA_SPAWN_EGG = new(997, "llama_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material MAGMA_CUBE_SPAWN_EGG = new(998, "magma_cube_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material MOOSHROOM_SPAWN_EGG = new(999, "mooshroom_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material MULE_SPAWN_EGG = new(1000, "mule_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material OCELOT_SPAWN_EGG = new(1001, "ocelot_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material PANDA_SPAWN_EGG = new(1002, "panda_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material PARROT_SPAWN_EGG = new(1003, "parrot_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material PHANTOM_SPAWN_EGG = new(1004, "phantom_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material PIG_SPAWN_EGG = new(1005, "pig_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material PIGLIN_SPAWN_EGG = new(1006, "piglin_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material PIGLIN_BRUTE_SPAWN_EGG = new(1007, "piglin_brute_spawn_egg", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material PILLAGER_SPAWN_EGG = new(1008, "pillager_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material POLAR_BEAR_SPAWN_EGG = new(1009, "polar_bear_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material PUFFERFISH_SPAWN_EGG = new(1010, "pufferfish_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material RABBIT_SPAWN_EGG = new(1011, "rabbit_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material RAVAGER_SPAWN_EGG = new(1012, "ravager_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material SALMON_SPAWN_EGG = new(1013, "salmon_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material SHEEP_SPAWN_EGG = new(1014, "sheep_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material SHULKER_SPAWN_EGG = new(1015, "shulker_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material SILVERFISH_SPAWN_EGG = new(1016, "silverfish_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SKELETON_SPAWN_EGG = new(1017, "skeleton_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SKELETON_HORSE_SPAWN_EGG = new(1018, "skeleton_horse_spawn_egg", false, false,
        false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SLIME_SPAWN_EGG = new(1019, "slime_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material SNIFFER_SPAWN_EGG = new(1020, "sniffer_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material SNOW_GOLEM_SPAWN_EGG = new(1021, "snow_golem_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SPIDER_SPAWN_EGG = new(1022, "spider_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material SQUID_SPAWN_EGG = new(1023, "squid_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material STRAY_SPAWN_EGG = new(1024, "stray_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material STRIDER_SPAWN_EGG = new(1025, "strider_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material TADPOLE_SPAWN_EGG = new(1026, "tadpole_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material TRADER_LLAMA_SPAWN_EGG = new(1027, "trader_llama_spawn_egg", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material TROPICAL_FISH_SPAWN_EGG = new(1028, "tropical_fish_spawn_egg", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material TURTLE_SPAWN_EGG = new(1029, "turtle_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material VEX_SPAWN_EGG = new(1030, "vex_spawn_egg", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material VILLAGER_SPAWN_EGG = new(1031, "villager_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material VINDICATOR_SPAWN_EGG = new(1032, "vindicator_spawn_egg", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material WANDERING_TRADER_SPAWN_EGG = new(1033, "wandering_trader_spawn_egg", false, false,
        false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material WARDEN_SPAWN_EGG = new(1034, "warden_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material WITCH_SPAWN_EGG = new(1035, "witch_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material WITHER_SPAWN_EGG = new(1036, "wither_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material WITHER_SKELETON_SPAWN_EGG = new(1037, "wither_skeleton_spawn_egg", false, false,
        false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material WOLF_SPAWN_EGG = new(1038, "wolf_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material ZOGLIN_SPAWN_EGG = new(1039, "zoglin_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material ZOMBIE_SPAWN_EGG = new(1040, "zombie_spawn_egg", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material ZOMBIE_HORSE_SPAWN_EGG = new(1041, "zombie_horse_spawn_egg", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ZOMBIE_VILLAGER_SPAWN_EGG = new(1042, "zombie_villager_spawn_egg", false, false,
        false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ZOMBIFIED_PIGLIN_SPAWN_EGG = new(1043, "zombified_piglin_spawn_egg", false, false,
        false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material EXPERIENCE_BOTTLE = new(1044, "experience_bottle", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material FIRE_CHARGE = new(1045, "fire_charge", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material WRITABLE_BOOK = new(1046, "writable_book", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material WRITTEN_BOOK = new(1047, "written_book", false, false, false, true, false, false,
        false, false, false, false, 16, 0.0f);

    public static readonly Material ITEM_FRAME = new(1048, "item_frame", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material GLOW_ITEM_FRAME = new(1049, "glow_item_frame", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material FLOWER_POT = new(1050, "flower_pot", true, false, false, true, false, false, false,
        false, false, true, 64, 0.0f);

    public static readonly Material CARROT = new(1051, "carrot", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material POTATO = new(1052, "potato", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material BAKED_POTATO = new(1053, "baked_potato", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material POISONOUS_POTATO = new(1054, "poisonous_potato", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material MAP = new(1055, "map", false, false, false, true, false, false, false, false, false,
        false, 64, 0.0f);

    public static readonly Material GOLDEN_CARROT = new(1056, "golden_carrot", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material SKELETON_SKULL = new(1057, "skeleton_skull", true, false, false, true, false, false,
        false, false, false, false, 64, 1.0f);

    public static readonly Material WITHER_SKELETON_SKULL = new(1058, "wither_skeleton_skull", true, false, false, true,
        false, false, false, false, false, false, 64, 1.0f);

    public static readonly Material PLAYER_HEAD = new(1059, "player_head", true, false, false, true, false, false,
        false, false, false, false, 64, 1.0f);

    public static readonly Material ZOMBIE_HEAD = new(1060, "zombie_head", true, false, false, true, false, false,
        false, false, false, false, 64, 1.0f);

    public static readonly Material CREEPER_HEAD = new(1061, "creeper_head", true, false, false, true, false, false,
        false, false, false, false, 64, 1.0f);

    public static readonly Material DRAGON_HEAD = new(1062, "dragon_head", true, false, false, true, false, false,
        false, false, false, false, 64, 1.0f);

    public static readonly Material PIGLIN_HEAD = new(1063, "piglin_head", true, false, false, true, false, false,
        false, false, false, false, 64, 1.0f);

    public static readonly Material NETHER_STAR = new(1064, "nether_star", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material PUMPKIN_PIE = new(1065, "pumpkin_pie", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material FIREWORK_ROCKET = new(1066, "firework_rocket", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material FIREWORK_STAR = new(1067, "firework_star", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material ENCHANTED_BOOK = new(1068, "enchanted_book", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material NETHER_BRICK = new(1069, "nether_brick", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material PRISMARINE_SHARD = new(1070, "prismarine_shard", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material PRISMARINE_CRYSTALS = new(1071, "prismarine_crystals", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material RABBIT = new(1072, "rabbit", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material COOKED_RABBIT = new(1073, "cooked_rabbit", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material RABBIT_STEW = new(1074, "rabbit_stew", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material RABBIT_FOOT = new(1075, "rabbit_foot", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material RABBIT_HIDE = new(1076, "rabbit_hide", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material ARMOR_STAND = new(1077, "armor_stand", false, false, false, true, false, false,
        false, false, false, false, 16, 0.0f);

    public static readonly Material IRON_HORSE_ARMOR = new(1078, "iron_horse_armor", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material GOLDEN_HORSE_ARMOR = new(1079, "golden_horse_armor", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material DIAMOND_HORSE_ARMOR = new(1080, "diamond_horse_armor", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material LEATHER_HORSE_ARMOR = new(1081, "leather_horse_armor", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material LEAD = new(1082, "lead", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material NAME_TAG = new(1083, "name_tag", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material COMMAND_BLOCK_MINECART = new(1084, "command_block_minecart", false, false, false,
        true, false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material MUTTON = new(1085, "mutton", false, false, false, true, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material COOKED_MUTTON = new(1086, "cooked_mutton", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material WHITE_BANNER = new(1087, "white_banner", true, false, true, true, false, true,
        false, true, false, false, 16, 1.0f);

    public static readonly Material ORANGE_BANNER = new(1088, "orange_banner", true, false, true, true, false, true,
        false, true, false, false, 16, 1.0f);

    public static readonly Material MAGENTA_BANNER = new(1089, "magenta_banner", true, false, true, true, false, true,
        false, true, false, false, 16, 1.0f);

    public static readonly Material LIGHT_BLUE_BANNER = new(1090, "light_blue_banner", true, false, true, true, false,
        true, false, true, false, false, 16, 1.0f);

    public static readonly Material YELLOW_BANNER = new(1091, "yellow_banner", true, false, true, true, false, true,
        false, true, false, false, 16, 1.0f);

    public static readonly Material LIME_BANNER = new(1092, "lime_banner", true, false, true, true, false, true, false,
        true, false, false, 16, 1.0f);

    public static readonly Material PINK_BANNER = new(1093, "pink_banner", true, false, true, true, false, true, false,
        true, false, false, 16, 1.0f);

    public static readonly Material GRAY_BANNER = new(1094, "gray_banner", true, false, true, true, false, true, false,
        true, false, false, 16, 1.0f);

    public static readonly Material LIGHT_GRAY_BANNER = new(1095, "light_gray_banner", true, false, true, true, false,
        true, false, true, false, false, 16, 1.0f);

    public static readonly Material CYAN_BANNER = new(1096, "cyan_banner", true, false, true, true, false, true, false,
        true, false, false, 16, 1.0f);

    public static readonly Material PURPLE_BANNER = new(1097, "purple_banner", true, false, true, true, false, true,
        false, true, false, false, 16, 1.0f);

    public static readonly Material BLUE_BANNER = new(1098, "blue_banner", true, false, true, true, false, true, false,
        true, false, false, 16, 1.0f);

    public static readonly Material BROWN_BANNER = new(1099, "brown_banner", true, false, true, true, false, true,
        false, true, false, false, 16, 1.0f);

    public static readonly Material GREEN_BANNER = new(1100, "green_banner", true, false, true, true, false, true,
        false, true, false, false, 16, 1.0f);

    public static readonly Material RED_BANNER = new(1101, "red_banner", true, false, true, true, false, true, false,
        true, false, false, 16, 1.0f);

    public static readonly Material BLACK_BANNER = new(1102, "black_banner", true, false, true, true, false, true,
        false, true, false, false, 16, 1.0f);

    public static readonly Material END_CRYSTAL = new(1103, "end_crystal", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material CHORUS_FRUIT = new(1104, "chorus_fruit", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material POPPED_CHORUS_FRUIT = new(1105, "popped_chorus_fruit", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material TORCHFLOWER_SEEDS = new(1106, "torchflower_seeds", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material PITCHER_POD = new(1107, "pitcher_pod", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BEETROOT = new(1108, "beetroot", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BEETROOT_SEEDS = new(1109, "beetroot_seeds", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material BEETROOT_SOUP = new(1110, "beetroot_soup", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material DRAGON_BREATH = new(1111, "dragon_breath", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material SPLASH_POTION = new(1112, "splash_potion", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material SPECTRAL_ARROW = new(1113, "spectral_arrow", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material TIPPED_ARROW = new(1114, "tipped_arrow", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material LINGERING_POTION = new(1115, "lingering_potion", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material SHIELD = new(1116, "shield", false, false, false, true, false, false, false, false,
        false, false, 1, 0.0f);

    public static readonly Material TOTEM_OF_UNDYING = new(1117, "totem_of_undying", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material SHULKER_SHELL = new(1118, "shulker_shell", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material IRON_NUGGET = new(1119, "iron_nugget", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material KNOWLEDGE_BOOK = new(1120, "knowledge_book", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material DEBUG_STICK = new(1121, "debug_stick", false, false, false, true, false, false,
        false, false, false, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_13 = new(1122, "music_disc_13", false, false, false, true, false, false,
        false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_CAT = new(1123, "music_disc_cat", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_BLOCKS = new(1124, "music_disc_blocks", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_CHIRP = new(1125, "music_disc_chirp", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_FAR = new(1126, "music_disc_far", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_MALL = new(1127, "music_disc_mall", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_MELLOHI = new(1128, "music_disc_mellohi", false, false, false, true,
        false, false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_STAL = new(1129, "music_disc_stal", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_STRAD = new(1130, "music_disc_strad", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_WARD = new(1131, "music_disc_ward", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_11 = new(1132, "music_disc_11", false, false, false, true, false, false,
        false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_WAIT = new(1133, "music_disc_wait", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_OTHERSIDE = new(1134, "music_disc_otherside", false, false, false, true,
        false, false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_RELIC = new(1135, "music_disc_relic", false, false, false, true, false,
        false, false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_5 = new(1136, "music_disc_5", false, false, false, true, false, false,
        false, false, true, false, 1, 0.0f);

    public static readonly Material MUSIC_DISC_PIGSTEP = new(1137, "music_disc_pigstep", false, false, false, true,
        false, false, false, false, true, false, 1, 0.0f);

    public static readonly Material DISC_FRAGMENT_5 = new(1138, "disc_fragment_5", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material TRIDENT = new(1139, "trident", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material PHANTOM_MEMBRANE = new(1140, "phantom_membrane", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material NAUTILUS_SHELL = new(1141, "nautilus_shell", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material HEART_OF_THE_SEA = new(1142, "heart_of_the_sea", false, false, false, true, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material CROSSBOW = new(1143, "crossbow", false, false, true, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material SUSPICIOUS_STEW = new(1144, "suspicious_stew", false, false, false, true, false,
        false, false, false, false, false, 1, 0.0f);

    public static readonly Material LOOM = new(1145, "loom", true, false, true, true, false, true, true, true, false,
        true, 64, 2.5f);

    public static readonly Material FLOWER_BANNER_PATTERN = new(1146, "flower_banner_pattern", false, false, false,
        true, false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material CREEPER_BANNER_PATTERN = new(1147, "creeper_banner_pattern", false, false, false,
        true, false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material SKULL_BANNER_PATTERN = new(1148, "skull_banner_pattern", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material MOJANG_BANNER_PATTERN = new(1149, "mojang_banner_pattern", false, false, false,
        true, false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material GLOBE_BANNER_PATTERN = new(1150, "globe_banner_pattern", false, false, false, true,
        false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material PIGLIN_BANNER_PATTERN = new(1151, "piglin_banner_pattern", false, false, false,
        true, false, false, false, false, false, false, 1, 0.0f);

    public static readonly Material GOAT_HORN = new(1152, "goat_horn", false, false, false, true, false, false, false,
        false, false, false, 1, 0.0f);

    public static readonly Material COMPOSTER = new(1153, "composter", true, true, true, true, false, true, false, true,
        false, true, 64, 0.6f);

    public static readonly Material BARREL = new(1154, "barrel", true, false, true, true, false, true, true, true,
        false, true, 64, 2.5f);

    public static readonly Material SMOKER = new(1155, "smoker", true, false, false, true, false, false, true, true,
        false, true, 64, 3.5f);

    public static readonly Material BLAST_FURNACE = new(1156, "blast_furnace", true, false, false, true, false, false,
        true, true, false, true, 64, 3.5f);

    public static readonly Material CARTOGRAPHY_TABLE = new(1157, "cartography_table", true, false, true, true, false,
        true, true, true, false, true, 64, 2.5f);

    public static readonly Material FLETCHING_TABLE = new(1158, "fletching_table", true, false, true, true, false, true,
        true, true, false, true, 64, 2.5f);

    public static readonly Material GRINDSTONE = new(1159, "grindstone", true, false, false, true, false, false, false,
        true, false, true, 64, 6.0f);

    public static readonly Material SMITHING_TABLE = new(1160, "smithing_table", true, false, true, true, false, true,
        true, true, false, true, 64, 2.5f);

    public static readonly Material STONECUTTER = new(1161, "stonecutter", true, false, false, true, false, false,
        false, true, false, true, 64, 3.5f);

    public static readonly Material BELL = new(1162, "bell", true, false, false, true, false, false, false, true, false,
        true, 64, 5.0f);

    public static readonly Material LANTERN = new(1163, "lantern", true, false, false, true, false, false, false, true,
        false, false, 64, 3.5f);

    public static readonly Material SOUL_LANTERN = new(1164, "soul_lantern", true, false, false, true, false, false,
        false, true, false, false, 64, 3.5f);

    public static readonly Material SWEET_BERRIES = new(1165, "sweet_berries", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material GLOW_BERRIES = new(1166, "glow_berries", false, false, false, true, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material CAMPFIRE = new(1167, "campfire", true, false, false, true, false, true, false, true,
        false, true, 64, 2.0f);

    public static readonly Material SOUL_CAMPFIRE = new(1168, "soul_campfire", true, false, false, true, false, true,
        false, true, false, true, 64, 2.0f);

    public static readonly Material SHROOMLIGHT = new(1169, "shroomlight", true, false, false, true, false, false, true,
        true, false, false, 64, 1.0f);

    public static readonly Material HONEYCOMB = new(1170, "honeycomb", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BEE_NEST = new(1171, "bee_nest", true, true, false, true, false, true, true, true,
        false, true, 64, 0.3f);

    public static readonly Material BEEHIVE = new(1172, "beehive", true, true, false, true, false, true, true, true,
        false, true, 64, 0.6f);

    public static readonly Material HONEY_BOTTLE = new(1173, "honey_bottle", false, false, false, true, false, false,
        false, false, false, false, 16, 0.0f);

    public static readonly Material HONEYCOMB_BLOCK = new(1174, "honeycomb_block", true, false, false, true, false,
        false, true, true, false, false, 64, 0.6f);

    public static readonly Material LODESTONE = new(1175, "lodestone", true, false, false, true, false, false, true,
        true, false, false, 64, 3.5f);

    public static readonly Material CRYING_OBSIDIAN = new(1176, "crying_obsidian", true, false, false, true, false,
        false, true, true, false, false, 64, 1200.0f);

    public static readonly Material BLACKSTONE = new(1177, "blackstone", true, false, false, true, false, false, true,
        true, false, false, 64, 6.0f);

    public static readonly Material BLACKSTONE_SLAB = new(1178, "blackstone_slab", true, false, false, true, false,
        false, false, true, false, false, 64, 6.0f);

    public static readonly Material BLACKSTONE_STAIRS = new(1179, "blackstone_stairs", true, false, false, true, false,
        false, false, true, false, true, 64, 6.0f);

    public static readonly Material GILDED_BLACKSTONE = new(1180, "gilded_blackstone", true, false, false, true, false,
        false, true, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_BLACKSTONE = new(1181, "polished_blackstone", true, false, false, true,
        false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_BLACKSTONE_SLAB = new(1182, "polished_blackstone_slab", true, false, false,
        true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_BLACKSTONE_STAIRS = new(1183, "polished_blackstone_stairs", true, false,
        false, true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material CHISELED_POLISHED_BLACKSTONE = new(1184, "chiseled_polished_blackstone", true,
        false, false, true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_BLACKSTONE_BRICKS = new(1185, "polished_blackstone_bricks", true, false,
        false, true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_BLACKSTONE_BRICK_SLAB = new(1186, "polished_blackstone_brick_slab", true,
        false, false, true, false, false, false, true, false, false, 64, 6.0f);

    public static readonly Material POLISHED_BLACKSTONE_BRICK_STAIRS = new(1187, "polished_blackstone_brick_stairs",
        true, false, false, true, false, false, false, true, false, true, 64, 6.0f);

    public static readonly Material CRACKED_POLISHED_BLACKSTONE_BRICKS = new(1188, "cracked_polished_blackstone_bricks",
        true, false, false, true, false, false, true, true, false, false, 64, 6.0f);

    public static readonly Material RESPAWN_ANCHOR = new(1189, "respawn_anchor", true, false, false, true, false, false,
        true, true, false, true, 64, 1200.0f);

    public static readonly Material CANDLE = new(1190, "candle", true, false, false, true, false, false, false, false,
        false, true, 64, 0.1f);

    public static readonly Material WHITE_CANDLE = new(1191, "white_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material ORANGE_CANDLE = new(1192, "orange_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material MAGENTA_CANDLE = new(1193, "magenta_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material LIGHT_BLUE_CANDLE = new(1194, "light_blue_candle", true, false, false, true, false,
        false, false, false, false, true, 64, 0.1f);

    public static readonly Material YELLOW_CANDLE = new(1195, "yellow_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material LIME_CANDLE = new(1196, "lime_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material PINK_CANDLE = new(1197, "pink_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material GRAY_CANDLE = new(1198, "gray_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material LIGHT_GRAY_CANDLE = new(1199, "light_gray_candle", true, false, false, true, false,
        false, false, false, false, true, 64, 0.1f);

    public static readonly Material CYAN_CANDLE = new(1200, "cyan_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material PURPLE_CANDLE = new(1201, "purple_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material BLUE_CANDLE = new(1202, "blue_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material BROWN_CANDLE = new(1203, "brown_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material GREEN_CANDLE = new(1204, "green_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material RED_CANDLE = new(1205, "red_candle", true, false, false, true, false, false, false,
        false, false, true, 64, 0.1f);

    public static readonly Material BLACK_CANDLE = new(1206, "black_candle", true, false, false, true, false, false,
        false, false, false, true, 64, 0.1f);

    public static readonly Material SMALL_AMETHYST_BUD = new(1207, "small_amethyst_bud", true, false, false, true,
        false, false, false, true, false, false, 64, 1.5f);

    public static readonly Material MEDIUM_AMETHYST_BUD = new(1208, "medium_amethyst_bud", true, false, false, true,
        false, false, false, true, false, false, 64, 1.5f);

    public static readonly Material LARGE_AMETHYST_BUD = new(1209, "large_amethyst_bud", true, false, false, true,
        false, false, false, true, false, false, 64, 1.5f);

    public static readonly Material AMETHYST_CLUSTER = new(1210, "amethyst_cluster", true, false, false, true, false,
        false, false, true, false, false, 64, 1.5f);

    public static readonly Material POINTED_DRIPSTONE = new(1211, "pointed_dripstone", true, false, false, true, false,
        false, false, true, false, false, 64, 3.0f);

    public static readonly Material OCHRE_FROGLIGHT = new(1212, "ochre_froglight", true, false, false, true, false,
        false, true, true, false, false, 64, 0.3f);

    public static readonly Material VERDANT_FROGLIGHT = new(1213, "verdant_froglight", true, false, false, true, false,
        false, true, true, false, false, 64, 0.3f);

    public static readonly Material PEARLESCENT_FROGLIGHT = new(1214, "pearlescent_froglight", true, false, false, true,
        false, false, true, true, false, false, 64, 0.3f);

    public static readonly Material FROGSPAWN = new(1215, "frogspawn", true, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material ECHO_SHARD = new(1216, "echo_shard", false, false, false, true, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BRUSH = new(1217, "brush", false, false, false, true, false, false, false, false,
        false, false, 1, 0.0f);

    public static readonly Material NETHERITE_UPGRADE_SMITHING_TEMPLATE = new(1218,
        "netherite_upgrade_smithing_template", false, false, false, true, false, false, false, false, false, false, 64,
        0.0f);

    public static readonly Material SENTRY_ARMOR_TRIM_SMITHING_TEMPLATE = new(1219,
        "sentry_armor_trim_smithing_template", false, false, false, true, false, false, false, false, false, false, 64,
        0.0f);

    public static readonly Material DUNE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1220, "dune_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material COAST_ARMOR_TRIM_SMITHING_TEMPLATE = new(1221, "coast_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material WILD_ARMOR_TRIM_SMITHING_TEMPLATE = new(1222, "wild_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material WARD_ARMOR_TRIM_SMITHING_TEMPLATE = new(1223, "ward_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material EYE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1224, "eye_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material VEX_ARMOR_TRIM_SMITHING_TEMPLATE = new(1225, "vex_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material TIDE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1226, "tide_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SNOUT_ARMOR_TRIM_SMITHING_TEMPLATE = new(1227, "snout_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material RIB_ARMOR_TRIM_SMITHING_TEMPLATE = new(1228, "rib_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SPIRE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1229, "spire_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material WAYFINDER_ARMOR_TRIM_SMITHING_TEMPLATE = new(1230,
        "wayfinder_armor_trim_smithing_template", false, false, false, true, false, false, false, false, false, false,
        64, 0.0f);

    public static readonly Material SHAPER_ARMOR_TRIM_SMITHING_TEMPLATE = new(1231,
        "shaper_armor_trim_smithing_template", false, false, false, true, false, false, false, false, false, false, 64,
        0.0f);

    public static readonly Material SILENCE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1232,
        "silence_armor_trim_smithing_template", false, false, false, true, false, false, false, false, false, false, 64,
        0.0f);

    public static readonly Material RAISER_ARMOR_TRIM_SMITHING_TEMPLATE = new(1233,
        "raiser_armor_trim_smithing_template", false, false, false, true, false, false, false, false, false, false, 64,
        0.0f);

    public static readonly Material HOST_ARMOR_TRIM_SMITHING_TEMPLATE = new(1234, "host_armor_trim_smithing_template",
        false, false, false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ANGLER_POTTERY_SHERD = new(1235, "angler_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ARCHER_POTTERY_SHERD = new(1236, "archer_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ARMS_UP_POTTERY_SHERD = new(1237, "arms_up_pottery_sherd", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material BLADE_POTTERY_SHERD = new(1238, "blade_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material BREWER_POTTERY_SHERD = new(1239, "brewer_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material BURN_POTTERY_SHERD = new(1240, "burn_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material DANGER_POTTERY_SHERD = new(1241, "danger_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material EXPLORER_POTTERY_SHERD = new(1242, "explorer_pottery_sherd", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material FRIEND_POTTERY_SHERD = new(1243, "friend_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material HEART_POTTERY_SHERD = new(1244, "heart_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material HEARTBREAK_POTTERY_SHERD = new(1245, "heartbreak_pottery_sherd", false, false,
        false, true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material HOWL_POTTERY_SHERD = new(1246, "howl_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material MINER_POTTERY_SHERD = new(1247, "miner_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material MOURNER_POTTERY_SHERD = new(1248, "mourner_pottery_sherd", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material PLENTY_POTTERY_SHERD = new(1249, "plenty_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material PRIZE_POTTERY_SHERD = new(1250, "prize_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SHEAF_POTTERY_SHERD = new(1251, "sheaf_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SHELTER_POTTERY_SHERD = new(1252, "shelter_pottery_sherd", false, false, false,
        true, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SKULL_POTTERY_SHERD = new(1253, "skull_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SNORT_POTTERY_SHERD = new(1254, "snort_pottery_sherd", false, false, false, true,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material WATER = new(1255, "water", true, false, false, false, false, false, false, false,
        false, false, 64, 100.0f);

    public static readonly Material LAVA = new(1256, "lava", true, false, false, false, false, false, false, false,
        false, false, 64, 100.0f);

    public static readonly Material TALL_SEAGRASS = new(1257, "tall_seagrass", true, false, false, false, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material PISTON_HEAD = new(1258, "piston_head", true, false, false, false, false, false,
        false, true, false, false, 64, 1.5f);

    public static readonly Material MOVING_PISTON = new(1259, "moving_piston", true, false, false, false, false, false,
        false, true, false, true, 64, 0.0f);

    public static readonly Material WALL_TORCH = new(1260, "wall_torch", true, false, false, false, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material FIRE = new(1261, "fire", true, false, false, false, false, false, false, false,
        false, false, 64, 0.0f);

    public static readonly Material SOUL_FIRE = new(1262, "soul_fire", true, false, false, false, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material REDSTONE_WIRE = new(1263, "redstone_wire", true, false, false, false, false, false,
        false, false, false, true, 64, 0.0f);

    public static readonly Material OAK_WALL_SIGN = new(1264, "oak_wall_sign", true, false, false, false, false, true,
        false, true, false, true, 16, 1.0f);

    public static readonly Material SPRUCE_WALL_SIGN = new(1265, "spruce_wall_sign", true, false, false, false, false,
        true, false, true, false, true, 16, 1.0f);

    public static readonly Material BIRCH_WALL_SIGN = new(1266, "birch_wall_sign", true, false, false, false, false,
        true, false, true, false, true, 16, 1.0f);

    public static readonly Material ACACIA_WALL_SIGN = new(1267, "acacia_wall_sign", true, false, false, false, false,
        true, false, true, false, true, 16, 1.0f);

    public static readonly Material CHERRY_WALL_SIGN = new(1268, "cherry_wall_sign", true, false, false, false, false,
        true, false, true, false, true, 16, 1.0f);

    public static readonly Material JUNGLE_WALL_SIGN = new(1269, "jungle_wall_sign", true, false, false, false, false,
        true, false, true, false, true, 16, 1.0f);

    public static readonly Material DARK_OAK_WALL_SIGN = new(1270, "dark_oak_wall_sign", true, false, false, false,
        false, true, false, true, false, true, 16, 1.0f);

    public static readonly Material MANGROVE_WALL_SIGN = new(1271, "mangrove_wall_sign", true, false, false, false,
        false, true, false, true, false, true, 16, 1.0f);

    public static readonly Material BAMBOO_WALL_SIGN = new(1272, "bamboo_wall_sign", true, false, false, false, false,
        true, false, true, false, true, 16, 1.0f);

    public static readonly Material OAK_WALL_HANGING_SIGN = new(1273, "oak_wall_hanging_sign", true, false, false,
        false, false, true, false, true, false, true, 64, 1.0f);

    public static readonly Material SPRUCE_WALL_HANGING_SIGN = new(1274, "spruce_wall_hanging_sign", true, false, false,
        false, false, true, false, true, false, true, 64, 1.0f);

    public static readonly Material BIRCH_WALL_HANGING_SIGN = new(1275, "birch_wall_hanging_sign", true, false, false,
        false, false, true, false, true, false, true, 64, 1.0f);

    public static readonly Material ACACIA_WALL_HANGING_SIGN = new(1276, "acacia_wall_hanging_sign", true, false, false,
        false, false, true, false, true, false, true, 64, 1.0f);

    public static readonly Material CHERRY_WALL_HANGING_SIGN = new(1277, "cherry_wall_hanging_sign", true, false, false,
        false, false, true, false, true, false, true, 64, 1.0f);

    public static readonly Material JUNGLE_WALL_HANGING_SIGN = new(1278, "jungle_wall_hanging_sign", true, false, false,
        false, false, true, false, true, false, true, 64, 1.0f);

    public static readonly Material DARK_OAK_WALL_HANGING_SIGN = new(1279, "dark_oak_wall_hanging_sign", true, false,
        false, false, false, true, false, true, false, true, 64, 1.0f);

    public static readonly Material MANGROVE_WALL_HANGING_SIGN = new(1280, "mangrove_wall_hanging_sign", true, false,
        false, false, false, true, false, true, false, true, 64, 1.0f);

    public static readonly Material CRIMSON_WALL_HANGING_SIGN = new(1281, "crimson_wall_hanging_sign", true, false,
        false, false, false, false, false, true, false, true, 64, 1.0f);

    public static readonly Material WARPED_WALL_HANGING_SIGN = new(1282, "warped_wall_hanging_sign", true, false, false,
        false, false, false, false, true, false, true, 64, 1.0f);

    public static readonly Material BAMBOO_WALL_HANGING_SIGN = new(1283, "bamboo_wall_hanging_sign", true, false, false,
        false, false, true, false, true, false, true, 64, 1.0f);

    public static readonly Material REDSTONE_WALL_TORCH = new(1284, "redstone_wall_torch", true, false, false, false,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material SOUL_WALL_TORCH = new(1285, "soul_wall_torch", true, false, false, false, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material NETHER_PORTAL = new(1286, "nether_portal", true, false, false, false, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material ATTACHED_PUMPKIN_STEM = new(1287, "attached_pumpkin_stem", true, false, false,
        false, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material ATTACHED_MELON_STEM = new(1288, "attached_melon_stem", true, false, false, false,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material PUMPKIN_STEM = new(1289, "pumpkin_stem", true, false, false, false, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material MELON_STEM = new(1290, "melon_stem", true, false, false, false, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material WATER_CAULDRON = new(1291, "water_cauldron", true, false, false, false, false,
        false, false, true, false, true, 64, 2.0f);

    public static readonly Material LAVA_CAULDRON = new(1292, "lava_cauldron", true, false, false, false, false, false,
        false, true, false, true, 64, 2.0f);

    public static readonly Material POWDER_SNOW_CAULDRON = new(1293, "powder_snow_cauldron", true, false, false, false,
        false, false, false, true, false, true, 64, 2.0f);

    public static readonly Material END_PORTAL = new(1294, "end_portal", true, false, false, false, false, false, false,
        false, false, false, 64, 3600000.0f);

    public static readonly Material COCOA = new(1295, "cocoa", true, false, false, false, false, false, false, false,
        false, false, 64, 3.0f);

    public static readonly Material TRIPWIRE = new(1296, "tripwire", true, false, false, false, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material POTTED_TORCHFLOWER = new(1297, "potted_torchflower", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_OAK_SAPLING = new(1298, "potted_oak_sapling", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_SPRUCE_SAPLING = new(1299, "potted_spruce_sapling", true, false, false,
        false, false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_BIRCH_SAPLING = new(1300, "potted_birch_sapling", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_JUNGLE_SAPLING = new(1301, "potted_jungle_sapling", true, false, false,
        false, false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_ACACIA_SAPLING = new(1302, "potted_acacia_sapling", true, false, false,
        false, false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_CHERRY_SAPLING = new(1303, "potted_cherry_sapling", true, false, false,
        false, false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_DARK_OAK_SAPLING = new(1304, "potted_dark_oak_sapling", true, false, false,
        false, false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_MANGROVE_PROPAGULE = new(1305, "potted_mangrove_propagule", true, false,
        false, false, false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_FERN = new(1306, "potted_fern", true, false, false, false, false, false,
        false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_DANDELION = new(1307, "potted_dandelion", true, false, false, false, false,
        false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_POPPY = new(1308, "potted_poppy", true, false, false, false, false, false,
        false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_BLUE_ORCHID = new(1309, "potted_blue_orchid", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_ALLIUM = new(1310, "potted_allium", true, false, false, false, false, false,
        false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_AZURE_BLUET = new(1311, "potted_azure_bluet", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_RED_TULIP = new(1312, "potted_red_tulip", true, false, false, false, false,
        false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_ORANGE_TULIP = new(1313, "potted_orange_tulip", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_WHITE_TULIP = new(1314, "potted_white_tulip", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_PINK_TULIP = new(1315, "potted_pink_tulip", true, false, false, false, false,
        false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_OXEYE_DAISY = new(1316, "potted_oxeye_daisy", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_CORNFLOWER = new(1317, "potted_cornflower", true, false, false, false, false,
        false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_LILY_OF_THE_VALLEY = new(1318, "potted_lily_of_the_valley", true, false,
        false, false, false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_WITHER_ROSE = new(1319, "potted_wither_rose", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_RED_MUSHROOM = new(1320, "potted_red_mushroom", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_BROWN_MUSHROOM = new(1321, "potted_brown_mushroom", true, false, false,
        false, false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_DEAD_BUSH = new(1322, "potted_dead_bush", true, false, false, false, false,
        false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_CACTUS = new(1323, "potted_cactus", true, false, false, false, false, false,
        false, false, false, true, 64, 0.0f);

    public static readonly Material CARROTS = new(1324, "carrots", true, false, false, false, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material POTATOES = new(1325, "potatoes", true, false, false, false, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material SKELETON_WALL_SKULL = new(1326, "skeleton_wall_skull", true, false, false, false,
        false, false, false, false, false, false, 64, 1.0f);

    public static readonly Material WITHER_SKELETON_WALL_SKULL = new(1327, "wither_skeleton_wall_skull", true, false,
        false, false, false, false, false, false, false, false, 64, 1.0f);

    public static readonly Material ZOMBIE_WALL_HEAD = new(1328, "zombie_wall_head", true, false, false, false, false,
        false, false, false, false, false, 64, 1.0f);

    public static readonly Material PLAYER_WALL_HEAD = new(1329, "player_wall_head", true, false, false, false, false,
        false, false, false, false, false, 64, 1.0f);

    public static readonly Material CREEPER_WALL_HEAD = new(1330, "creeper_wall_head", true, false, false, false, false,
        false, false, false, false, false, 64, 1.0f);

    public static readonly Material DRAGON_WALL_HEAD = new(1331, "dragon_wall_head", true, false, false, false, false,
        false, false, false, false, false, 64, 1.0f);

    public static readonly Material PIGLIN_WALL_HEAD = new(1332, "piglin_wall_head", true, false, false, false, false,
        false, false, false, false, false, 64, 1.0f);

    public static readonly Material WHITE_WALL_BANNER = new(1333, "white_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material ORANGE_WALL_BANNER = new(1334, "orange_wall_banner", true, false, false, false,
        false, true, false, true, false, false, 64, 1.0f);

    public static readonly Material MAGENTA_WALL_BANNER = new(1335, "magenta_wall_banner", true, false, false, false,
        false, true, false, true, false, false, 64, 1.0f);

    public static readonly Material LIGHT_BLUE_WALL_BANNER = new(1336, "light_blue_wall_banner", true, false, false,
        false, false, true, false, true, false, false, 64, 1.0f);

    public static readonly Material YELLOW_WALL_BANNER = new(1337, "yellow_wall_banner", true, false, false, false,
        false, true, false, true, false, false, 64, 1.0f);

    public static readonly Material LIME_WALL_BANNER = new(1338, "lime_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material PINK_WALL_BANNER = new(1339, "pink_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material GRAY_WALL_BANNER = new(1340, "gray_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material LIGHT_GRAY_WALL_BANNER = new(1341, "light_gray_wall_banner", true, false, false,
        false, false, true, false, true, false, false, 64, 1.0f);

    public static readonly Material CYAN_WALL_BANNER = new(1342, "cyan_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material PURPLE_WALL_BANNER = new(1343, "purple_wall_banner", true, false, false, false,
        false, true, false, true, false, false, 64, 1.0f);

    public static readonly Material BLUE_WALL_BANNER = new(1344, "blue_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material BROWN_WALL_BANNER = new(1345, "brown_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material GREEN_WALL_BANNER = new(1346, "green_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material RED_WALL_BANNER = new(1347, "red_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material BLACK_WALL_BANNER = new(1348, "black_wall_banner", true, false, false, false, false,
        true, false, true, false, false, 64, 1.0f);

    public static readonly Material TORCHFLOWER_CROP = new(1349, "torchflower_crop", true, false, false, false, false,
        false, false, false, false, false, 64, 0.0f);

    public static readonly Material PITCHER_CROP = new(1350, "pitcher_crop", true, false, false, false, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material BEETROOTS = new(1351, "beetroots", true, false, false, false, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material END_GATEWAY = new(1352, "end_gateway", true, false, false, false, false, false,
        false, false, false, false, 64, 3600000.0f);

    public static readonly Material FROSTED_ICE = new(1353, "frosted_ice", true, false, false, false, false, false,
        false, true, false, false, 64, 0.5f);

    public static readonly Material KELP_PLANT = new(1354, "kelp_plant", true, false, false, false, false, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material DEAD_TUBE_CORAL_WALL_FAN = new(1355, "dead_tube_coral_wall_fan", true, false, false,
        false, false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_BRAIN_CORAL_WALL_FAN = new(1356, "dead_brain_coral_wall_fan", true, false,
        false, false, false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_BUBBLE_CORAL_WALL_FAN = new(1357, "dead_bubble_coral_wall_fan", true, false,
        false, false, false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_FIRE_CORAL_WALL_FAN = new(1358, "dead_fire_coral_wall_fan", true, false, false,
        false, false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material DEAD_HORN_CORAL_WALL_FAN = new(1359, "dead_horn_coral_wall_fan", true, false, false,
        false, false, false, false, true, false, false, 64, 0.0f);

    public static readonly Material TUBE_CORAL_WALL_FAN = new(1360, "tube_coral_wall_fan", true, false, false, false,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material BRAIN_CORAL_WALL_FAN = new(1361, "brain_coral_wall_fan", true, false, false, false,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material BUBBLE_CORAL_WALL_FAN = new(1362, "bubble_coral_wall_fan", true, false, false,
        false, false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material FIRE_CORAL_WALL_FAN = new(1363, "fire_coral_wall_fan", true, false, false, false,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material HORN_CORAL_WALL_FAN = new(1364, "horn_coral_wall_fan", true, false, false, false,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material BAMBOO_SAPLING = new(1365, "bamboo_sapling", true, false, false, false, false, true,
        false, false, false, false, 64, 1.0f);

    public static readonly Material POTTED_BAMBOO = new(1366, "potted_bamboo", true, false, false, false, false, false,
        false, false, false, true, 64, 0.0f);

    public static readonly Material VOID_AIR = new(1367, "void_air", true, false, false, false, true, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material CAVE_AIR = new(1368, "cave_air", true, false, false, false, true, false, false,
        false, false, false, 64, 0.0f);

    public static readonly Material BUBBLE_COLUMN = new(1369, "bubble_column", true, false, false, false, false, false,
        false, false, false, false, 64, 0.0f);

    public static readonly Material SWEET_BERRY_BUSH = new(1370, "sweet_berry_bush", true, true, false, false, false,
        false, false, false, false, true, 64, 0.0f);

    public static readonly Material WEEPING_VINES_PLANT = new(1371, "weeping_vines_plant", true, false, false, false,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material TWISTING_VINES_PLANT = new(1372, "twisting_vines_plant", true, false, false, false,
        false, false, false, false, false, false, 64, 0.0f);

    public static readonly Material CRIMSON_WALL_SIGN = new(1373, "crimson_wall_sign", true, false, false, false, false,
        false, false, true, false, true, 16, 1.0f);

    public static readonly Material WARPED_WALL_SIGN = new(1374, "warped_wall_sign", true, false, false, false, false,
        false, false, true, false, true, 16, 1.0f);

    public static readonly Material POTTED_CRIMSON_FUNGUS = new(1375, "potted_crimson_fungus", true, false, false,
        false, false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_WARPED_FUNGUS = new(1376, "potted_warped_fungus", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_CRIMSON_ROOTS = new(1377, "potted_crimson_roots", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_WARPED_ROOTS = new(1378, "potted_warped_roots", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material CANDLE_CAKE = new(1379, "candle_cake", true, false, false, false, false, false,
        false, true, false, true, 64, 0.5f);

    public static readonly Material WHITE_CANDLE_CAKE = new(1380, "white_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material ORANGE_CANDLE_CAKE = new(1381, "orange_candle_cake", true, false, false, false,
        false, false, false, true, false, true, 64, 0.5f);

    public static readonly Material MAGENTA_CANDLE_CAKE = new(1382, "magenta_candle_cake", true, false, false, false,
        false, false, false, true, false, true, 64, 0.5f);

    public static readonly Material LIGHT_BLUE_CANDLE_CAKE = new(1383, "light_blue_candle_cake", true, false, false,
        false, false, false, false, true, false, true, 64, 0.5f);

    public static readonly Material YELLOW_CANDLE_CAKE = new(1384, "yellow_candle_cake", true, false, false, false,
        false, false, false, true, false, true, 64, 0.5f);

    public static readonly Material LIME_CANDLE_CAKE = new(1385, "lime_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material PINK_CANDLE_CAKE = new(1386, "pink_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material GRAY_CANDLE_CAKE = new(1387, "gray_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material LIGHT_GRAY_CANDLE_CAKE = new(1388, "light_gray_candle_cake", true, false, false,
        false, false, false, false, true, false, true, 64, 0.5f);

    public static readonly Material CYAN_CANDLE_CAKE = new(1389, "cyan_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material PURPLE_CANDLE_CAKE = new(1390, "purple_candle_cake", true, false, false, false,
        false, false, false, true, false, true, 64, 0.5f);

    public static readonly Material BLUE_CANDLE_CAKE = new(1391, "blue_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material BROWN_CANDLE_CAKE = new(1392, "brown_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material GREEN_CANDLE_CAKE = new(1393, "green_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material RED_CANDLE_CAKE = new(1394, "red_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material BLACK_CANDLE_CAKE = new(1395, "black_candle_cake", true, false, false, false, false,
        false, false, true, false, true, 64, 0.5f);

    public static readonly Material POWDER_SNOW = new(1396, "powder_snow", true, false, false, false, false, false,
        false, false, false, false, 64, 0.25f);

    public static readonly Material CAVE_VINES = new(1397, "cave_vines", true, true, false, false, false, false, false,
        false, false, true, 64, 0.0f);

    public static readonly Material CAVE_VINES_PLANT = new(1398, "cave_vines_plant", true, true, false, false, false,
        false, false, false, false, true, 64, 0.0f);

    public static readonly Material BIG_DRIPLEAF_STEM = new(1399, "big_dripleaf_stem", true, true, false, false, false,
        false, false, false, false, false, 64, 0.1f);

    public static readonly Material POTTED_AZALEA_BUSH = new(1400, "potted_azalea_bush", true, false, false, false,
        false, false, false, false, false, true, 64, 0.0f);

    public static readonly Material POTTED_FLOWERING_AZALEA_BUSH = new(1401, "potted_flowering_azalea_bush", true,
        false, false, false, false, false, false, false, false, true, 64, 0.0f);

    #endregion
}