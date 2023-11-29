namespace SkyBotsApi;

public class Material
{
    public const int MATERIALS_COUNT = 1402;
    
    private static readonly Material[] Materials = new Material[MATERIALS_COUNT];
    
    public int Id { get; init; }
    public bool IsBlock { get; init; }
    public bool IsItem { get; init; }
    public bool IsBurnable { get; init; }
    public bool IsFuel { get; init; }
    public bool IsAir { get; init; }
    public bool IsFlammable { get; init; }
    public bool IsOccluding { get; init; }
    public bool IsSolid { get; init; }
    public bool IsRecord { get; init; }
    public bool IsInteractable { get; init; }
    public float BlastResistance { get; init; }
    public int MaxStackSize { get; init; }
    
    
    public Material(int id)
    {
        Id = id; 
        Materials[id] = this;
    }
    public static Material FromId(int id) => Materials[id]; 
#region POMOIKA
    public static readonly Material AIR = new(0)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = true,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 0,
        BlastResistance = 0.0f
    };

    public static readonly Material STONE = new(1)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material GRANITE = new(2)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_GRANITE = new(3)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DIORITE = new(4)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_DIORITE = new(5)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material ANDESITE = new(6)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_ANDESITE = new(7)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEEPSLATE = new(8)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material COBBLED_DEEPSLATE = new(9)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_DEEPSLATE = new(10)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CALCITE = new(11)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.75f
    };

    public static readonly Material TUFF = new(12)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DRIPSTONE_BLOCK = new(13)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material GRASS_BLOCK = new(14)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material DIRT = new(15)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material COARSE_DIRT = new(16)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material PODZOL = new(17)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material ROOTED_DIRT = new(18)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material MUD = new(19)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material CRIMSON_NYLIUM = new(20)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.4f
    };

    public static readonly Material WARPED_NYLIUM = new(21)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.4f
    };

    public static readonly Material COBBLESTONE = new(22)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material OAK_PLANKS = new(23)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material SPRUCE_PLANKS = new(24)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BIRCH_PLANKS = new(25)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material JUNGLE_PLANKS = new(26)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material ACACIA_PLANKS = new(27)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CHERRY_PLANKS = new(28)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DARK_OAK_PLANKS = new(29)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material MANGROVE_PLANKS = new(30)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_PLANKS = new(31)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CRIMSON_PLANKS = new(32)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material WARPED_PLANKS = new(33)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_MOSAIC = new(34)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material OAK_SAPLING = new(35)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SPRUCE_SAPLING = new(36)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BIRCH_SAPLING = new(37)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material JUNGLE_SAPLING = new(38)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ACACIA_SAPLING = new(39)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CHERRY_SAPLING = new(40)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DARK_OAK_SAPLING = new(41)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MANGROVE_PROPAGULE = new(42)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BEDROCK = new(43)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3600000.0f
    };

    public static readonly Material SAND = new(44)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material SUSPICIOUS_SAND = new(45)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.25f
    };

    public static readonly Material SUSPICIOUS_GRAVEL = new(46)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.25f
    };

    public static readonly Material RED_SAND = new(47)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material GRAVEL = new(48)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material COAL_ORE = new(49)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DEEPSLATE_COAL_ORE = new(50)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material IRON_ORE = new(51)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DEEPSLATE_IRON_ORE = new(52)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material COPPER_ORE = new(53)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DEEPSLATE_COPPER_ORE = new(54)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material GOLD_ORE = new(55)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DEEPSLATE_GOLD_ORE = new(56)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material REDSTONE_ORE = new(57)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DEEPSLATE_REDSTONE_ORE = new(58)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material EMERALD_ORE = new(59)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DEEPSLATE_EMERALD_ORE = new(60)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material LAPIS_ORE = new(61)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DEEPSLATE_LAPIS_ORE = new(62)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DIAMOND_ORE = new(63)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DEEPSLATE_DIAMOND_ORE = new(64)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material NETHER_GOLD_ORE = new(65)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material NETHER_QUARTZ_ORE = new(66)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material ANCIENT_DEBRIS = new(67)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material COAL_BLOCK = new(68)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material RAW_IRON_BLOCK = new(69)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material RAW_COPPER_BLOCK = new(70)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material RAW_GOLD_BLOCK = new(71)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material AMETHYST_BLOCK = new(72)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material BUDDING_AMETHYST = new(73)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material IRON_BLOCK = new(74)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material COPPER_BLOCK = new(75)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material GOLD_BLOCK = new(76)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DIAMOND_BLOCK = new(77)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material NETHERITE_BLOCK = new(78)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material EXPOSED_COPPER = new(79)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WEATHERED_COPPER = new(80)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material OXIDIZED_COPPER = new(81)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CUT_COPPER = new(82)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material EXPOSED_CUT_COPPER = new(83)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WEATHERED_CUT_COPPER = new(84)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material OXIDIZED_CUT_COPPER = new(85)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CUT_COPPER_STAIRS = new(86)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material EXPOSED_CUT_COPPER_STAIRS = new(87)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WEATHERED_CUT_COPPER_STAIRS = new(88)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material OXIDIZED_CUT_COPPER_STAIRS = new(89)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CUT_COPPER_SLAB = new(90)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material EXPOSED_CUT_COPPER_SLAB = new(91)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WEATHERED_CUT_COPPER_SLAB = new(92)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material OXIDIZED_CUT_COPPER_SLAB = new(93)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_COPPER_BLOCK = new(94)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_EXPOSED_COPPER = new(95)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_WEATHERED_COPPER = new(96)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_OXIDIZED_COPPER = new(97)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_CUT_COPPER = new(98)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_EXPOSED_CUT_COPPER = new(99)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_WEATHERED_CUT_COPPER = new(100)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_OXIDIZED_CUT_COPPER = new(101)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_CUT_COPPER_STAIRS = new(102)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_EXPOSED_CUT_COPPER_STAIRS = new(103)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_WEATHERED_CUT_COPPER_STAIRS = new(104)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_OXIDIZED_CUT_COPPER_STAIRS = new(105)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_CUT_COPPER_SLAB = new(106)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_EXPOSED_CUT_COPPER_SLAB = new(107)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_WEATHERED_CUT_COPPER_SLAB = new(108)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material WAXED_OXIDIZED_CUT_COPPER_SLAB = new(109)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material OAK_LOG = new(110)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material SPRUCE_LOG = new(111)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material BIRCH_LOG = new(112)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material JUNGLE_LOG = new(113)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material ACACIA_LOG = new(114)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material CHERRY_LOG = new(115)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material DARK_OAK_LOG = new(116)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material MANGROVE_LOG = new(117)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material MANGROVE_ROOTS = new(118)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.7f
    };

    public static readonly Material MUDDY_MANGROVE_ROOTS = new(119)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.7f
    };

    public static readonly Material CRIMSON_STEM = new(120)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material WARPED_STEM = new(121)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material BAMBOO_BLOCK = new(122)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_OAK_LOG = new(123)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_SPRUCE_LOG = new(124)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_BIRCH_LOG = new(125)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_JUNGLE_LOG = new(126)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_ACACIA_LOG = new(127)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_CHERRY_LOG = new(128)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_DARK_OAK_LOG = new(129)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_MANGROVE_LOG = new(130)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_CRIMSON_STEM = new(131)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_WARPED_STEM = new(132)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_OAK_WOOD = new(133)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_SPRUCE_WOOD = new(134)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_BIRCH_WOOD = new(135)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_JUNGLE_WOOD = new(136)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_ACACIA_WOOD = new(137)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_CHERRY_WOOD = new(138)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_DARK_OAK_WOOD = new(139)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_MANGROVE_WOOD = new(140)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_CRIMSON_HYPHAE = new(141)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_WARPED_HYPHAE = new(142)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRIPPED_BAMBOO_BLOCK = new(143)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material OAK_WOOD = new(144)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material SPRUCE_WOOD = new(145)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material BIRCH_WOOD = new(146)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material JUNGLE_WOOD = new(147)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material ACACIA_WOOD = new(148)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material CHERRY_WOOD = new(149)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material DARK_OAK_WOOD = new(150)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material MANGROVE_WOOD = new(151)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material CRIMSON_HYPHAE = new(152)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material WARPED_HYPHAE = new(153)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material OAK_LEAVES = new(154)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material SPRUCE_LEAVES = new(155)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material BIRCH_LEAVES = new(156)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material JUNGLE_LEAVES = new(157)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material ACACIA_LEAVES = new(158)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material CHERRY_LEAVES = new(159)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material DARK_OAK_LEAVES = new(160)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material MANGROVE_LEAVES = new(161)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material AZALEA_LEAVES = new(162)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material FLOWERING_AZALEA_LEAVES = new(163)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material SPONGE = new(164)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material WET_SPONGE = new(165)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material GLASS = new(166)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material TINTED_GLASS = new(167)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material LAPIS_BLOCK = new(168)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material SANDSTONE = new(169)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material CHISELED_SANDSTONE = new(170)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material CUT_SANDSTONE = new(171)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material COBWEB = new(172)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.0f
    };

    public static readonly Material GRASS = new(173)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FERN = new(174)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material AZALEA = new(175)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FLOWERING_AZALEA = new(176)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_BUSH = new(177)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SEAGRASS = new(178)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SEA_PICKLE = new(179)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WHITE_WOOL = new(180)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material ORANGE_WOOL = new(181)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material MAGENTA_WOOL = new(182)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material LIGHT_BLUE_WOOL = new(183)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material YELLOW_WOOL = new(184)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material LIME_WOOL = new(185)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material PINK_WOOL = new(186)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material GRAY_WOOL = new(187)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material LIGHT_GRAY_WOOL = new(188)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material CYAN_WOOL = new(189)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material PURPLE_WOOL = new(190)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material BLUE_WOOL = new(191)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material BROWN_WOOL = new(192)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material GREEN_WOOL = new(193)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material RED_WOOL = new(194)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material BLACK_WOOL = new(195)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material DANDELION = new(196)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POPPY = new(197)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BLUE_ORCHID = new(198)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ALLIUM = new(199)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material AZURE_BLUET = new(200)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RED_TULIP = new(201)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ORANGE_TULIP = new(202)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WHITE_TULIP = new(203)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PINK_TULIP = new(204)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material OXEYE_DAISY = new(205)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CORNFLOWER = new(206)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LILY_OF_THE_VALLEY = new(207)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WITHER_ROSE = new(208)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TORCHFLOWER = new(209)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PITCHER_PLANT = new(210)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SPORE_BLOSSOM = new(211)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BROWN_MUSHROOM = new(212)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RED_MUSHROOM = new(213)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CRIMSON_FUNGUS = new(214)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WARPED_FUNGUS = new(215)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CRIMSON_ROOTS = new(216)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WARPED_ROOTS = new(217)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHER_SPROUTS = new(218)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WEEPING_VINES = new(219)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TWISTING_VINES = new(220)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SUGAR_CANE = new(221)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material KELP = new(222)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MOSS_CARPET = new(223)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material PINK_PETALS = new(224)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MOSS_BLOCK = new(225)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material HANGING_ROOTS = new(226)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BIG_DRIPLEAF = new(227)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material SMALL_DRIPLEAF = new(228)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BAMBOO = new(229)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material OAK_SLAB = new(230)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material SPRUCE_SLAB = new(231)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BIRCH_SLAB = new(232)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material JUNGLE_SLAB = new(233)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material ACACIA_SLAB = new(234)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CHERRY_SLAB = new(235)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DARK_OAK_SLAB = new(236)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material MANGROVE_SLAB = new(237)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_SLAB = new(238)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_MOSAIC_SLAB = new(239)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CRIMSON_SLAB = new(240)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material WARPED_SLAB = new(241)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material STONE_SLAB = new(242)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_STONE_SLAB = new(243)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SANDSTONE_SLAB = new(244)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CUT_SANDSTONE_SLAB = new(245)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PETRIFIED_OAK_SLAB = new(246)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material COBBLESTONE_SLAB = new(247)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BRICK_SLAB = new(248)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material STONE_BRICK_SLAB = new(249)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material MUD_BRICK_SLAB = new(250)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material NETHER_BRICK_SLAB = new(251)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material QUARTZ_SLAB = new(252)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material RED_SANDSTONE_SLAB = new(253)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CUT_RED_SANDSTONE_SLAB = new(254)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PURPUR_SLAB = new(255)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PRISMARINE_SLAB = new(256)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PRISMARINE_BRICK_SLAB = new(257)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DARK_PRISMARINE_SLAB = new(258)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_QUARTZ = new(259)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_RED_SANDSTONE = new(260)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_SANDSTONE = new(261)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_STONE = new(262)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BRICKS = new(263)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BOOKSHELF = new(264)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material CHISELED_BOOKSHELF = new(265)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material DECORATED_POT = new(266)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MOSSY_COBBLESTONE = new(267)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material OBSIDIAN = new(268)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material TORCH = new(269)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material END_ROD = new(270)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CHORUS_PLANT = new(271)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.4f
    };

    public static readonly Material CHORUS_FLOWER = new(272)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.4f
    };

    public static readonly Material PURPUR_BLOCK = new(273)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PURPUR_PILLAR = new(274)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PURPUR_STAIRS = new(275)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SPAWNER = new(276)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 5.0f
    };

    public static readonly Material CHEST = new(277)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material CRAFTING_TABLE = new(278)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material FARMLAND = new(279)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material FURNACE = new(280)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.5f
    };

    public static readonly Material LADDER = new(281)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.4f
    };

    public static readonly Material COBBLESTONE_STAIRS = new(282)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SNOW = new(283)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material ICE = new(284)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material SNOW_BLOCK = new(285)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material CACTUS = new(286)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.4f
    };

    public static readonly Material CLAY = new(287)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material JUKEBOX = new(288)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material OAK_FENCE = new(289)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material SPRUCE_FENCE = new(290)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BIRCH_FENCE = new(291)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material JUNGLE_FENCE = new(292)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material ACACIA_FENCE = new(293)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CHERRY_FENCE = new(294)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DARK_OAK_FENCE = new(295)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material MANGROVE_FENCE = new(296)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_FENCE = new(297)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CRIMSON_FENCE = new(298)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material WARPED_FENCE = new(299)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material PUMPKIN = new(300)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material CARVED_PUMPKIN = new(301)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material JACK_O_LANTERN = new(302)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material NETHERRACK = new(303)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.4f
    };

    public static readonly Material SOUL_SAND = new(304)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material SOUL_SOIL = new(305)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BASALT = new(306)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material POLISHED_BASALT = new(307)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material SMOOTH_BASALT = new(308)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material SOUL_TORCH = new(309)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GLOWSTONE = new(310)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material INFESTED_STONE = new(311)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.75f
    };

    public static readonly Material INFESTED_COBBLESTONE = new(312)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.75f
    };

    public static readonly Material INFESTED_STONE_BRICKS = new(313)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.75f
    };

    public static readonly Material INFESTED_MOSSY_STONE_BRICKS = new(314)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.75f
    };

    public static readonly Material INFESTED_CRACKED_STONE_BRICKS = new(315)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.75f
    };

    public static readonly Material INFESTED_CHISELED_STONE_BRICKS = new(316)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.75f
    };

    public static readonly Material INFESTED_DEEPSLATE = new(317)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.75f
    };

    public static readonly Material STONE_BRICKS = new(318)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material MOSSY_STONE_BRICKS = new(319)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CRACKED_STONE_BRICKS = new(320)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CHISELED_STONE_BRICKS = new(321)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PACKED_MUD = new(322)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material MUD_BRICKS = new(323)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DEEPSLATE_BRICKS = new(324)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CRACKED_DEEPSLATE_BRICKS = new(325)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEEPSLATE_TILES = new(326)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CRACKED_DEEPSLATE_TILES = new(327)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CHISELED_DEEPSLATE = new(328)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material REINFORCED_DEEPSLATE = new(329)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material BROWN_MUSHROOM_BLOCK = new(330)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material RED_MUSHROOM_BLOCK = new(331)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material MUSHROOM_STEM = new(332)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material IRON_BARS = new(333)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CHAIN = new(334)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material GLASS_PANE = new(335)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material MELON = new(336)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material VINE = new(337)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material GLOW_LICHEN = new(338)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material BRICK_STAIRS = new(339)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material STONE_BRICK_STAIRS = new(340)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material MUD_BRICK_STAIRS = new(341)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material MYCELIUM = new(342)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material LILY_PAD = new(343)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHER_BRICKS = new(344)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CRACKED_NETHER_BRICKS = new(345)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CHISELED_NETHER_BRICKS = new(346)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material NETHER_BRICK_FENCE = new(347)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material NETHER_BRICK_STAIRS = new(348)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SCULK = new(349)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material SCULK_VEIN = new(350)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material SCULK_CATALYST = new(351)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material SCULK_SHRIEKER = new(352)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material ENCHANTING_TABLE = new(353)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material END_PORTAL_FRAME = new(354)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3600000.0f
    };

    public static readonly Material END_STONE = new(355)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 9.0f
    };

    public static readonly Material END_STONE_BRICKS = new(356)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 9.0f
    };

    public static readonly Material DRAGON_EGG = new(357)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 9.0f
    };

    public static readonly Material SANDSTONE_STAIRS = new(358)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material ENDER_CHEST = new(359)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 600.0f
    };

    public static readonly Material EMERALD_BLOCK = new(360)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material OAK_STAIRS = new(361)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material SPRUCE_STAIRS = new(362)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BIRCH_STAIRS = new(363)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material JUNGLE_STAIRS = new(364)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material ACACIA_STAIRS = new(365)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CHERRY_STAIRS = new(366)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DARK_OAK_STAIRS = new(367)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material MANGROVE_STAIRS = new(368)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_STAIRS = new(369)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_MOSAIC_STAIRS = new(370)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CRIMSON_STAIRS = new(371)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material WARPED_STAIRS = new(372)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material COMMAND_BLOCK = new(373)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3600000.0f
    };

    public static readonly Material BEACON = new(374)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material COBBLESTONE_WALL = new(375)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material MOSSY_COBBLESTONE_WALL = new(376)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BRICK_WALL = new(377)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PRISMARINE_WALL = new(378)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material RED_SANDSTONE_WALL = new(379)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material MOSSY_STONE_BRICK_WALL = new(380)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material GRANITE_WALL = new(381)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material STONE_BRICK_WALL = new(382)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material MUD_BRICK_WALL = new(383)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material NETHER_BRICK_WALL = new(384)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material ANDESITE_WALL = new(385)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material RED_NETHER_BRICK_WALL = new(386)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SANDSTONE_WALL = new(387)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material END_STONE_BRICK_WALL = new(388)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 9.0f
    };

    public static readonly Material DIORITE_WALL = new(389)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BLACKSTONE_WALL = new(390)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_BLACKSTONE_WALL = new(391)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_BLACKSTONE_BRICK_WALL = new(392)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material COBBLED_DEEPSLATE_WALL = new(393)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_DEEPSLATE_WALL = new(394)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEEPSLATE_BRICK_WALL = new(395)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEEPSLATE_TILE_WALL = new(396)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material ANVIL = new(397)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material CHIPPED_ANVIL = new(398)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material DAMAGED_ANVIL = new(399)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material CHISELED_QUARTZ_BLOCK = new(400)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material QUARTZ_BLOCK = new(401)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material QUARTZ_BRICKS = new(402)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material QUARTZ_PILLAR = new(403)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material QUARTZ_STAIRS = new(404)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material WHITE_TERRACOTTA = new(405)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material ORANGE_TERRACOTTA = new(406)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material MAGENTA_TERRACOTTA = new(407)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material LIGHT_BLUE_TERRACOTTA = new(408)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material YELLOW_TERRACOTTA = new(409)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material LIME_TERRACOTTA = new(410)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material PINK_TERRACOTTA = new(411)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material GRAY_TERRACOTTA = new(412)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material LIGHT_GRAY_TERRACOTTA = new(413)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material CYAN_TERRACOTTA = new(414)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material PURPLE_TERRACOTTA = new(415)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material BLUE_TERRACOTTA = new(416)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material BROWN_TERRACOTTA = new(417)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material GREEN_TERRACOTTA = new(418)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material RED_TERRACOTTA = new(419)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material BLACK_TERRACOTTA = new(420)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material BARRIER = new(421)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3600000.8f
    };

    public static readonly Material LIGHT = new(422)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3600000.8f
    };

    public static readonly Material HAY_BLOCK = new(423)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material WHITE_CARPET = new(424)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material ORANGE_CARPET = new(425)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material MAGENTA_CARPET = new(426)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material LIGHT_BLUE_CARPET = new(427)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material YELLOW_CARPET = new(428)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material LIME_CARPET = new(429)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material PINK_CARPET = new(430)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material GRAY_CARPET = new(431)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material LIGHT_GRAY_CARPET = new(432)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material CYAN_CARPET = new(433)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material PURPLE_CARPET = new(434)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material BLUE_CARPET = new(435)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material BROWN_CARPET = new(436)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material GREEN_CARPET = new(437)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material RED_CARPET = new(438)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material BLACK_CARPET = new(439)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material TERRACOTTA = new(440)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 4.2f
    };

    public static readonly Material PACKED_ICE = new(441)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material DIRT_PATH = new(442)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.65f
    };

    public static readonly Material SUNFLOWER = new(443)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LILAC = new(444)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ROSE_BUSH = new(445)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PEONY = new(446)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TALL_GRASS = new(447)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LARGE_FERN = new(448)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WHITE_STAINED_GLASS = new(449)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material ORANGE_STAINED_GLASS = new(450)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material MAGENTA_STAINED_GLASS = new(451)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material LIGHT_BLUE_STAINED_GLASS = new(452)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material YELLOW_STAINED_GLASS = new(453)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material LIME_STAINED_GLASS = new(454)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material PINK_STAINED_GLASS = new(455)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material GRAY_STAINED_GLASS = new(456)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material LIGHT_GRAY_STAINED_GLASS = new(457)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material CYAN_STAINED_GLASS = new(458)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material PURPLE_STAINED_GLASS = new(459)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material BLUE_STAINED_GLASS = new(460)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material BROWN_STAINED_GLASS = new(461)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material GREEN_STAINED_GLASS = new(462)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material RED_STAINED_GLASS = new(463)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material BLACK_STAINED_GLASS = new(464)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material WHITE_STAINED_GLASS_PANE = new(465)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material ORANGE_STAINED_GLASS_PANE = new(466)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material MAGENTA_STAINED_GLASS_PANE = new(467)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material LIGHT_BLUE_STAINED_GLASS_PANE = new(468)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material YELLOW_STAINED_GLASS_PANE = new(469)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material LIME_STAINED_GLASS_PANE = new(470)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material PINK_STAINED_GLASS_PANE = new(471)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material GRAY_STAINED_GLASS_PANE = new(472)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material LIGHT_GRAY_STAINED_GLASS_PANE = new(473)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material CYAN_STAINED_GLASS_PANE = new(474)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material PURPLE_STAINED_GLASS_PANE = new(475)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material BLUE_STAINED_GLASS_PANE = new(476)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material BROWN_STAINED_GLASS_PANE = new(477)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material GREEN_STAINED_GLASS_PANE = new(478)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material RED_STAINED_GLASS_PANE = new(479)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material BLACK_STAINED_GLASS_PANE = new(480)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material PRISMARINE = new(481)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PRISMARINE_BRICKS = new(482)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DARK_PRISMARINE = new(483)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PRISMARINE_STAIRS = new(484)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material PRISMARINE_BRICK_STAIRS = new(485)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DARK_PRISMARINE_STAIRS = new(486)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SEA_LANTERN = new(487)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material RED_SANDSTONE = new(488)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material CHISELED_RED_SANDSTONE = new(489)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material CUT_RED_SANDSTONE = new(490)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material RED_SANDSTONE_STAIRS = new(491)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material REPEATING_COMMAND_BLOCK = new(492)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3600000.0f
    };

    public static readonly Material CHAIN_COMMAND_BLOCK = new(493)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3600000.0f
    };

    public static readonly Material MAGMA_BLOCK = new(494)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material NETHER_WART_BLOCK = new(495)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material WARPED_WART_BLOCK = new(496)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material RED_NETHER_BRICKS = new(497)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BONE_BLOCK = new(498)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material STRUCTURE_VOID = new(499)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SHULKER_BOX = new(500)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material WHITE_SHULKER_BOX = new(501)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material ORANGE_SHULKER_BOX = new(502)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material MAGENTA_SHULKER_BOX = new(503)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material LIGHT_BLUE_SHULKER_BOX = new(504)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material YELLOW_SHULKER_BOX = new(505)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material LIME_SHULKER_BOX = new(506)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material PINK_SHULKER_BOX = new(507)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material GRAY_SHULKER_BOX = new(508)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material LIGHT_GRAY_SHULKER_BOX = new(509)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material CYAN_SHULKER_BOX = new(510)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material PURPLE_SHULKER_BOX = new(511)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material BLUE_SHULKER_BOX = new(512)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material BROWN_SHULKER_BOX = new(513)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material GREEN_SHULKER_BOX = new(514)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material RED_SHULKER_BOX = new(515)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material BLACK_SHULKER_BOX = new(516)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 2.0f
    };

    public static readonly Material WHITE_GLAZED_TERRACOTTA = new(517)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material ORANGE_GLAZED_TERRACOTTA = new(518)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material MAGENTA_GLAZED_TERRACOTTA = new(519)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material LIGHT_BLUE_GLAZED_TERRACOTTA = new(520)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material YELLOW_GLAZED_TERRACOTTA = new(521)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material LIME_GLAZED_TERRACOTTA = new(522)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material PINK_GLAZED_TERRACOTTA = new(523)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material GRAY_GLAZED_TERRACOTTA = new(524)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material LIGHT_GRAY_GLAZED_TERRACOTTA = new(525)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material CYAN_GLAZED_TERRACOTTA = new(526)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material PURPLE_GLAZED_TERRACOTTA = new(527)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material BLUE_GLAZED_TERRACOTTA = new(528)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material BROWN_GLAZED_TERRACOTTA = new(529)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material GREEN_GLAZED_TERRACOTTA = new(530)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material RED_GLAZED_TERRACOTTA = new(531)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material BLACK_GLAZED_TERRACOTTA = new(532)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.4f
    };

    public static readonly Material WHITE_CONCRETE = new(533)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material ORANGE_CONCRETE = new(534)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material MAGENTA_CONCRETE = new(535)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material LIGHT_BLUE_CONCRETE = new(536)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material YELLOW_CONCRETE = new(537)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material LIME_CONCRETE = new(538)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material PINK_CONCRETE = new(539)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material GRAY_CONCRETE = new(540)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material LIGHT_GRAY_CONCRETE = new(541)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material CYAN_CONCRETE = new(542)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material PURPLE_CONCRETE = new(543)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material BLUE_CONCRETE = new(544)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material BROWN_CONCRETE = new(545)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material GREEN_CONCRETE = new(546)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material RED_CONCRETE = new(547)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material BLACK_CONCRETE = new(548)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.8f
    };

    public static readonly Material WHITE_CONCRETE_POWDER = new(549)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material ORANGE_CONCRETE_POWDER = new(550)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material MAGENTA_CONCRETE_POWDER = new(551)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material LIGHT_BLUE_CONCRETE_POWDER = new(552)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material YELLOW_CONCRETE_POWDER = new(553)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material LIME_CONCRETE_POWDER = new(554)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material PINK_CONCRETE_POWDER = new(555)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material GRAY_CONCRETE_POWDER = new(556)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material LIGHT_GRAY_CONCRETE_POWDER = new(557)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material CYAN_CONCRETE_POWDER = new(558)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material PURPLE_CONCRETE_POWDER = new(559)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BLUE_CONCRETE_POWDER = new(560)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BROWN_CONCRETE_POWDER = new(561)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material GREEN_CONCRETE_POWDER = new(562)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material RED_CONCRETE_POWDER = new(563)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BLACK_CONCRETE_POWDER = new(564)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material TURTLE_EGG = new(565)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material SNIFFER_EGG = new(566)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material DEAD_TUBE_CORAL_BLOCK = new(567)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEAD_BRAIN_CORAL_BLOCK = new(568)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEAD_BUBBLE_CORAL_BLOCK = new(569)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEAD_FIRE_CORAL_BLOCK = new(570)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEAD_HORN_CORAL_BLOCK = new(571)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material TUBE_CORAL_BLOCK = new(572)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BRAIN_CORAL_BLOCK = new(573)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BUBBLE_CORAL_BLOCK = new(574)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material FIRE_CORAL_BLOCK = new(575)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material HORN_CORAL_BLOCK = new(576)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material TUBE_CORAL = new(577)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BRAIN_CORAL = new(578)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BUBBLE_CORAL = new(579)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FIRE_CORAL = new(580)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HORN_CORAL = new(581)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_BRAIN_CORAL = new(582)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_BUBBLE_CORAL = new(583)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_FIRE_CORAL = new(584)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_HORN_CORAL = new(585)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_TUBE_CORAL = new(586)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TUBE_CORAL_FAN = new(587)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BRAIN_CORAL_FAN = new(588)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BUBBLE_CORAL_FAN = new(589)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FIRE_CORAL_FAN = new(590)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HORN_CORAL_FAN = new(591)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_TUBE_CORAL_FAN = new(592)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_BRAIN_CORAL_FAN = new(593)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_BUBBLE_CORAL_FAN = new(594)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_FIRE_CORAL_FAN = new(595)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_HORN_CORAL_FAN = new(596)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BLUE_ICE = new(597)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.8f
    };

    public static readonly Material CONDUIT = new(598)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material POLISHED_GRANITE_STAIRS = new(599)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_RED_SANDSTONE_STAIRS = new(600)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material MOSSY_STONE_BRICK_STAIRS = new(601)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_DIORITE_STAIRS = new(602)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material MOSSY_COBBLESTONE_STAIRS = new(603)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material END_STONE_BRICK_STAIRS = new(604)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 9.0f
    };

    public static readonly Material STONE_STAIRS = new(605)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_SANDSTONE_STAIRS = new(606)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_QUARTZ_STAIRS = new(607)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material GRANITE_STAIRS = new(608)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material ANDESITE_STAIRS = new(609)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material RED_NETHER_BRICK_STAIRS = new(610)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_ANDESITE_STAIRS = new(611)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DIORITE_STAIRS = new(612)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material COBBLED_DEEPSLATE_STAIRS = new(613)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_DEEPSLATE_STAIRS = new(614)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEEPSLATE_BRICK_STAIRS = new(615)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEEPSLATE_TILE_STAIRS = new(616)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_GRANITE_SLAB = new(617)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_RED_SANDSTONE_SLAB = new(618)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material MOSSY_STONE_BRICK_SLAB = new(619)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_DIORITE_SLAB = new(620)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material MOSSY_COBBLESTONE_SLAB = new(621)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material END_STONE_BRICK_SLAB = new(622)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 9.0f
    };

    public static readonly Material SMOOTH_SANDSTONE_SLAB = new(623)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMOOTH_QUARTZ_SLAB = new(624)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material GRANITE_SLAB = new(625)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material ANDESITE_SLAB = new(626)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material RED_NETHER_BRICK_SLAB = new(627)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_ANDESITE_SLAB = new(628)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DIORITE_SLAB = new(629)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material COBBLED_DEEPSLATE_SLAB = new(630)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_DEEPSLATE_SLAB = new(631)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEEPSLATE_BRICK_SLAB = new(632)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DEEPSLATE_TILE_SLAB = new(633)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SCAFFOLDING = new(634)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material REDSTONE = new(635)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material REDSTONE_TORCH = new(636)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material REDSTONE_BLOCK = new(637)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material REPEATER = new(638)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COMPARATOR = new(639)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PISTON = new(640)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material STICKY_PISTON = new(641)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material SLIME_BLOCK = new(642)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HONEY_BLOCK = new(643)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material OBSERVER = new(644)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material HOPPER = new(645)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 4.8f
    };

    public static readonly Material DISPENSER = new(646)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.5f
    };

    public static readonly Material DROPPER = new(647)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.5f
    };

    public static readonly Material LECTERN = new(648)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material TARGET = new(649)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material LEVER = new(650)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material LIGHTNING_ROD = new(651)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material DAYLIGHT_DETECTOR = new(652)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.2f
    };

    public static readonly Material SCULK_SENSOR = new(653)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material CALIBRATED_SCULK_SENSOR = new(654)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material TRIPWIRE_HOOK = new(655)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TRAPPED_CHEST = new(656)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material TNT = new(657)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material REDSTONE_LAMP = new(658)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material NOTE_BLOCK = new(659)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.8f
    };

    public static readonly Material STONE_BUTTON = new(660)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material POLISHED_BLACKSTONE_BUTTON = new(661)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material OAK_BUTTON = new(662)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material SPRUCE_BUTTON = new(663)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BIRCH_BUTTON = new(664)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material JUNGLE_BUTTON = new(665)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material ACACIA_BUTTON = new(666)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material CHERRY_BUTTON = new(667)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material DARK_OAK_BUTTON = new(668)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material MANGROVE_BUTTON = new(669)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BAMBOO_BUTTON = new(670)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material CRIMSON_BUTTON = new(671)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material WARPED_BUTTON = new(672)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material STONE_PRESSURE_PLATE = new(673)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material POLISHED_BLACKSTONE_PRESSURE_PLATE = new(674)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material LIGHT_WEIGHTED_PRESSURE_PLATE = new(675)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material HEAVY_WEIGHTED_PRESSURE_PLATE = new(676)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material OAK_PRESSURE_PLATE = new(677)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material SPRUCE_PRESSURE_PLATE = new(678)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BIRCH_PRESSURE_PLATE = new(679)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material JUNGLE_PRESSURE_PLATE = new(680)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material ACACIA_PRESSURE_PLATE = new(681)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material CHERRY_PRESSURE_PLATE = new(682)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material DARK_OAK_PRESSURE_PLATE = new(683)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material MANGROVE_PRESSURE_PLATE = new(684)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BAMBOO_PRESSURE_PLATE = new(685)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material CRIMSON_PRESSURE_PLATE = new(686)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material WARPED_PRESSURE_PLATE = new(687)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material IRON_DOOR = new(688)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 5.0f
    };

    public static readonly Material OAK_DOOR = new(689)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material SPRUCE_DOOR = new(690)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BIRCH_DOOR = new(691)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material JUNGLE_DOOR = new(692)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material ACACIA_DOOR = new(693)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CHERRY_DOOR = new(694)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DARK_OAK_DOOR = new(695)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material MANGROVE_DOOR = new(696)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_DOOR = new(697)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CRIMSON_DOOR = new(698)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material WARPED_DOOR = new(699)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material IRON_TRAPDOOR = new(700)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 5.0f
    };

    public static readonly Material OAK_TRAPDOOR = new(701)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material SPRUCE_TRAPDOOR = new(702)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BIRCH_TRAPDOOR = new(703)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material JUNGLE_TRAPDOOR = new(704)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material ACACIA_TRAPDOOR = new(705)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CHERRY_TRAPDOOR = new(706)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DARK_OAK_TRAPDOOR = new(707)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material MANGROVE_TRAPDOOR = new(708)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_TRAPDOOR = new(709)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CRIMSON_TRAPDOOR = new(710)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material WARPED_TRAPDOOR = new(711)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material OAK_FENCE_GATE = new(712)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material SPRUCE_FENCE_GATE = new(713)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BIRCH_FENCE_GATE = new(714)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material JUNGLE_FENCE_GATE = new(715)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material ACACIA_FENCE_GATE = new(716)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CHERRY_FENCE_GATE = new(717)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material DARK_OAK_FENCE_GATE = new(718)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material MANGROVE_FENCE_GATE = new(719)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material BAMBOO_FENCE_GATE = new(720)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material CRIMSON_FENCE_GATE = new(721)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material WARPED_FENCE_GATE = new(722)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material POWERED_RAIL = new(723)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.7f
    };

    public static readonly Material DETECTOR_RAIL = new(724)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.7f
    };

    public static readonly Material RAIL = new(725)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.7f
    };

    public static readonly Material ACTIVATOR_RAIL = new(726)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.7f
    };

    public static readonly Material SADDLE = new(727)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MINECART = new(728)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CHEST_MINECART = new(729)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material FURNACE_MINECART = new(730)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material TNT_MINECART = new(731)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material HOPPER_MINECART = new(732)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CARROT_ON_A_STICK = new(733)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material WARPED_FUNGUS_ON_A_STICK = new(734)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material ELYTRA = new(735)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material OAK_BOAT = new(736)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material OAK_CHEST_BOAT = new(737)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SPRUCE_BOAT = new(738)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SPRUCE_CHEST_BOAT = new(739)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material BIRCH_BOAT = new(740)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material BIRCH_CHEST_BOAT = new(741)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material JUNGLE_BOAT = new(742)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material JUNGLE_CHEST_BOAT = new(743)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material ACACIA_BOAT = new(744)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material ACACIA_CHEST_BOAT = new(745)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CHERRY_BOAT = new(746)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CHERRY_CHEST_BOAT = new(747)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DARK_OAK_BOAT = new(748)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DARK_OAK_CHEST_BOAT = new(749)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MANGROVE_BOAT = new(750)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MANGROVE_CHEST_BOAT = new(751)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material BAMBOO_RAFT = new(752)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material BAMBOO_CHEST_RAFT = new(753)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material STRUCTURE_BLOCK = new(754)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3600000.0f
    };

    public static readonly Material JIGSAW = new(755)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3600000.0f
    };

    public static readonly Material TURTLE_HELMET = new(756)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SCUTE = new(757)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FLINT_AND_STEEL = new(758)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material APPLE = new(759)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BOW = new(760)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material ARROW = new(761)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COAL = new(762)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CHARCOAL = new(763)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND = new(764)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material EMERALD = new(765)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LAPIS_LAZULI = new(766)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material QUARTZ = new(767)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material AMETHYST_SHARD = new(768)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RAW_IRON = new(769)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_INGOT = new(770)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RAW_COPPER = new(771)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COPPER_INGOT = new(772)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RAW_GOLD = new(773)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLD_INGOT = new(774)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_INGOT = new(775)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_SCRAP = new(776)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WOODEN_SWORD = new(777)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material WOODEN_SHOVEL = new(778)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material WOODEN_PICKAXE = new(779)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material WOODEN_AXE = new(780)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material WOODEN_HOE = new(781)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material STONE_SWORD = new(782)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material STONE_SHOVEL = new(783)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material STONE_PICKAXE = new(784)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material STONE_AXE = new(785)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material STONE_HOE = new(786)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_SWORD = new(787)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_SHOVEL = new(788)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_PICKAXE = new(789)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_AXE = new(790)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_HOE = new(791)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_SWORD = new(792)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_SHOVEL = new(793)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_PICKAXE = new(794)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_AXE = new(795)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_HOE = new(796)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_SWORD = new(797)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_SHOVEL = new(798)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_PICKAXE = new(799)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_AXE = new(800)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_HOE = new(801)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_SWORD = new(802)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_SHOVEL = new(803)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_PICKAXE = new(804)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_AXE = new(805)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_HOE = new(806)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material STICK = new(807)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BOWL = new(808)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSHROOM_STEW = new(809)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material STRING = new(810)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FEATHER = new(811)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GUNPOWDER = new(812)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WHEAT_SEEDS = new(813)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WHEAT = new(814)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BREAD = new(815)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LEATHER_HELMET = new(816)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material LEATHER_CHESTPLATE = new(817)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material LEATHER_LEGGINGS = new(818)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material LEATHER_BOOTS = new(819)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CHAINMAIL_HELMET = new(820)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CHAINMAIL_CHESTPLATE = new(821)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CHAINMAIL_LEGGINGS = new(822)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CHAINMAIL_BOOTS = new(823)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_HELMET = new(824)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_CHESTPLATE = new(825)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_LEGGINGS = new(826)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_BOOTS = new(827)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_HELMET = new(828)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_CHESTPLATE = new(829)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_LEGGINGS = new(830)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_BOOTS = new(831)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_HELMET = new(832)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_CHESTPLATE = new(833)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_LEGGINGS = new(834)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_BOOTS = new(835)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_HELMET = new(836)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_CHESTPLATE = new(837)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_LEGGINGS = new(838)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_BOOTS = new(839)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material FLINT = new(840)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PORKCHOP = new(841)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COOKED_PORKCHOP = new(842)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PAINTING = new(843)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_APPLE = new(844)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ENCHANTED_GOLDEN_APPLE = new(845)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material OAK_SIGN = new(846)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material SPRUCE_SIGN = new(847)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BIRCH_SIGN = new(848)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material JUNGLE_SIGN = new(849)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material ACACIA_SIGN = new(850)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material CHERRY_SIGN = new(851)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material DARK_OAK_SIGN = new(852)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material MANGROVE_SIGN = new(853)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BAMBOO_SIGN = new(854)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material CRIMSON_SIGN = new(855)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material WARPED_SIGN = new(856)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material OAK_HANGING_SIGN = new(857)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material SPRUCE_HANGING_SIGN = new(858)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BIRCH_HANGING_SIGN = new(859)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material JUNGLE_HANGING_SIGN = new(860)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material ACACIA_HANGING_SIGN = new(861)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material CHERRY_HANGING_SIGN = new(862)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material DARK_OAK_HANGING_SIGN = new(863)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material MANGROVE_HANGING_SIGN = new(864)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BAMBOO_HANGING_SIGN = new(865)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material CRIMSON_HANGING_SIGN = new(866)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material WARPED_HANGING_SIGN = new(867)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BUCKET = new(868)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 0.0f
    };

    public static readonly Material WATER_BUCKET = new(869)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material LAVA_BUCKET = new(870)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material POWDER_SNOW_BUCKET = new(871)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SNOWBALL = new(872)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 0.0f
    };

    public static readonly Material LEATHER = new(873)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MILK_BUCKET = new(874)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material PUFFERFISH_BUCKET = new(875)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SALMON_BUCKET = new(876)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material COD_BUCKET = new(877)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material TROPICAL_FISH_BUCKET = new(878)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material AXOLOTL_BUCKET = new(879)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material TADPOLE_BUCKET = new(880)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material BRICK = new(881)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CLAY_BALL = new(882)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DRIED_KELP_BLOCK = new(883)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material PAPER = new(884)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BOOK = new(885)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SLIME_BALL = new(886)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material EGG = new(887)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 0.0f
    };

    public static readonly Material COMPASS = new(888)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RECOVERY_COMPASS = new(889)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BUNDLE = new(890)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material FISHING_ROD = new(891)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CLOCK = new(892)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SPYGLASS = new(893)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GLOWSTONE_DUST = new(894)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COD = new(895)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SALMON = new(896)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TROPICAL_FISH = new(897)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PUFFERFISH = new(898)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COOKED_COD = new(899)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COOKED_SALMON = new(900)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material INK_SAC = new(901)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GLOW_INK_SAC = new(902)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COCOA_BEANS = new(903)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WHITE_DYE = new(904)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ORANGE_DYE = new(905)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MAGENTA_DYE = new(906)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LIGHT_BLUE_DYE = new(907)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material YELLOW_DYE = new(908)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LIME_DYE = new(909)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PINK_DYE = new(910)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GRAY_DYE = new(911)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LIGHT_GRAY_DYE = new(912)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CYAN_DYE = new(913)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PURPLE_DYE = new(914)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BLUE_DYE = new(915)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BROWN_DYE = new(916)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GREEN_DYE = new(917)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RED_DYE = new(918)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BLACK_DYE = new(919)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BONE_MEAL = new(920)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BONE = new(921)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SUGAR = new(922)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CAKE = new(923)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.5f
    };

    public static readonly Material WHITE_BED = new(924)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material ORANGE_BED = new(925)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material MAGENTA_BED = new(926)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material LIGHT_BLUE_BED = new(927)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material YELLOW_BED = new(928)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material LIME_BED = new(929)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material PINK_BED = new(930)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material GRAY_BED = new(931)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material LIGHT_GRAY_BED = new(932)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material CYAN_BED = new(933)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material PURPLE_BED = new(934)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material BLUE_BED = new(935)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material BROWN_BED = new(936)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material GREEN_BED = new(937)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material RED_BED = new(938)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material BLACK_BED = new(939)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 1,
        BlastResistance = 0.2f
    };

    public static readonly Material COOKIE = new(940)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FILLED_MAP = new(941)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SHEARS = new(942)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MELON_SLICE = new(943)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DRIED_KELP = new(944)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PUMPKIN_SEEDS = new(945)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MELON_SEEDS = new(946)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BEEF = new(947)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COOKED_BEEF = new(948)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CHICKEN = new(949)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COOKED_CHICKEN = new(950)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ROTTEN_FLESH = new(951)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ENDER_PEARL = new(952)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 0.0f
    };

    public static readonly Material BLAZE_ROD = new(953)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GHAST_TEAR = new(954)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLD_NUGGET = new(955)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHER_WART = new(956)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTION = new(957)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GLASS_BOTTLE = new(958)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SPIDER_EYE = new(959)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FERMENTED_SPIDER_EYE = new(960)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BLAZE_POWDER = new(961)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MAGMA_CREAM = new(962)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BREWING_STAND = new(963)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material CAULDRON = new(964)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material ENDER_EYE = new(965)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GLISTERING_MELON_SLICE = new(966)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ALLAY_SPAWN_EGG = new(967)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material AXOLOTL_SPAWN_EGG = new(968)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BAT_SPAWN_EGG = new(969)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BEE_SPAWN_EGG = new(970)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BLAZE_SPAWN_EGG = new(971)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CAT_SPAWN_EGG = new(972)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CAMEL_SPAWN_EGG = new(973)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CAVE_SPIDER_SPAWN_EGG = new(974)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CHICKEN_SPAWN_EGG = new(975)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COD_SPAWN_EGG = new(976)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COW_SPAWN_EGG = new(977)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CREEPER_SPAWN_EGG = new(978)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DOLPHIN_SPAWN_EGG = new(979)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DONKEY_SPAWN_EGG = new(980)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DROWNED_SPAWN_EGG = new(981)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ELDER_GUARDIAN_SPAWN_EGG = new(982)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ENDER_DRAGON_SPAWN_EGG = new(983)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ENDERMAN_SPAWN_EGG = new(984)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ENDERMITE_SPAWN_EGG = new(985)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material EVOKER_SPAWN_EGG = new(986)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FOX_SPAWN_EGG = new(987)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FROG_SPAWN_EGG = new(988)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GHAST_SPAWN_EGG = new(989)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GLOW_SQUID_SPAWN_EGG = new(990)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GOAT_SPAWN_EGG = new(991)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GUARDIAN_SPAWN_EGG = new(992)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HOGLIN_SPAWN_EGG = new(993)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HORSE_SPAWN_EGG = new(994)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HUSK_SPAWN_EGG = new(995)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_GOLEM_SPAWN_EGG = new(996)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LLAMA_SPAWN_EGG = new(997)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MAGMA_CUBE_SPAWN_EGG = new(998)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MOOSHROOM_SPAWN_EGG = new(999)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MULE_SPAWN_EGG = new(1000)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material OCELOT_SPAWN_EGG = new(1001)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PANDA_SPAWN_EGG = new(1002)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PARROT_SPAWN_EGG = new(1003)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PHANTOM_SPAWN_EGG = new(1004)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PIG_SPAWN_EGG = new(1005)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PIGLIN_SPAWN_EGG = new(1006)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PIGLIN_BRUTE_SPAWN_EGG = new(1007)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PILLAGER_SPAWN_EGG = new(1008)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POLAR_BEAR_SPAWN_EGG = new(1009)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PUFFERFISH_SPAWN_EGG = new(1010)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RABBIT_SPAWN_EGG = new(1011)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RAVAGER_SPAWN_EGG = new(1012)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SALMON_SPAWN_EGG = new(1013)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SHEEP_SPAWN_EGG = new(1014)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SHULKER_SPAWN_EGG = new(1015)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SILVERFISH_SPAWN_EGG = new(1016)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SKELETON_SPAWN_EGG = new(1017)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SKELETON_HORSE_SPAWN_EGG = new(1018)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SLIME_SPAWN_EGG = new(1019)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SNIFFER_SPAWN_EGG = new(1020)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SNOW_GOLEM_SPAWN_EGG = new(1021)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SPIDER_SPAWN_EGG = new(1022)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SQUID_SPAWN_EGG = new(1023)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material STRAY_SPAWN_EGG = new(1024)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material STRIDER_SPAWN_EGG = new(1025)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TADPOLE_SPAWN_EGG = new(1026)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TRADER_LLAMA_SPAWN_EGG = new(1027)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TROPICAL_FISH_SPAWN_EGG = new(1028)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TURTLE_SPAWN_EGG = new(1029)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material VEX_SPAWN_EGG = new(1030)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material VILLAGER_SPAWN_EGG = new(1031)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material VINDICATOR_SPAWN_EGG = new(1032)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WANDERING_TRADER_SPAWN_EGG = new(1033)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WARDEN_SPAWN_EGG = new(1034)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WITCH_SPAWN_EGG = new(1035)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WITHER_SPAWN_EGG = new(1036)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WITHER_SKELETON_SPAWN_EGG = new(1037)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WOLF_SPAWN_EGG = new(1038)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ZOGLIN_SPAWN_EGG = new(1039)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ZOMBIE_SPAWN_EGG = new(1040)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ZOMBIE_HORSE_SPAWN_EGG = new(1041)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ZOMBIE_VILLAGER_SPAWN_EGG = new(1042)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ZOMBIFIED_PIGLIN_SPAWN_EGG = new(1043)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material EXPERIENCE_BOTTLE = new(1044)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FIRE_CHARGE = new(1045)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WRITABLE_BOOK = new(1046)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material WRITTEN_BOOK = new(1047)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 0.0f
    };

    public static readonly Material ITEM_FRAME = new(1048)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GLOW_ITEM_FRAME = new(1049)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FLOWER_POT = new(1050)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CARROT = new(1051)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTATO = new(1052)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BAKED_POTATO = new(1053)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POISONOUS_POTATO = new(1054)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MAP = new(1055)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_CARROT = new(1056)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SKELETON_SKULL = new(1057)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material WITHER_SKELETON_SKULL = new(1058)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material PLAYER_HEAD = new(1059)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material ZOMBIE_HEAD = new(1060)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material CREEPER_HEAD = new(1061)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material DRAGON_HEAD = new(1062)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material PIGLIN_HEAD = new(1063)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material NETHER_STAR = new(1064)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PUMPKIN_PIE = new(1065)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FIREWORK_ROCKET = new(1066)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FIREWORK_STAR = new(1067)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ENCHANTED_BOOK = new(1068)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHER_BRICK = new(1069)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PRISMARINE_SHARD = new(1070)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PRISMARINE_CRYSTALS = new(1071)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RABBIT = new(1072)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COOKED_RABBIT = new(1073)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RABBIT_STEW = new(1074)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material RABBIT_FOOT = new(1075)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RABBIT_HIDE = new(1076)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ARMOR_STAND = new(1077)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_HORSE_ARMOR = new(1078)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOLDEN_HORSE_ARMOR = new(1079)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DIAMOND_HORSE_ARMOR = new(1080)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material LEATHER_HORSE_ARMOR = new(1081)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material LEAD = new(1082)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material NAME_TAG = new(1083)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COMMAND_BLOCK_MINECART = new(1084)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUTTON = new(1085)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COOKED_MUTTON = new(1086)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WHITE_BANNER = new(1087)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material ORANGE_BANNER = new(1088)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material MAGENTA_BANNER = new(1089)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material LIGHT_BLUE_BANNER = new(1090)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material YELLOW_BANNER = new(1091)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material LIME_BANNER = new(1092)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material PINK_BANNER = new(1093)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material GRAY_BANNER = new(1094)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material LIGHT_GRAY_BANNER = new(1095)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material CYAN_BANNER = new(1096)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material PURPLE_BANNER = new(1097)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BLUE_BANNER = new(1098)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BROWN_BANNER = new(1099)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material GREEN_BANNER = new(1100)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material RED_BANNER = new(1101)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BLACK_BANNER = new(1102)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material END_CRYSTAL = new(1103)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CHORUS_FRUIT = new(1104)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POPPED_CHORUS_FRUIT = new(1105)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TORCHFLOWER_SEEDS = new(1106)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PITCHER_POD = new(1107)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BEETROOT = new(1108)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BEETROOT_SEEDS = new(1109)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BEETROOT_SOUP = new(1110)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DRAGON_BREATH = new(1111)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SPLASH_POTION = new(1112)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SPECTRAL_ARROW = new(1113)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TIPPED_ARROW = new(1114)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material LINGERING_POTION = new(1115)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SHIELD = new(1116)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material TOTEM_OF_UNDYING = new(1117)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SHULKER_SHELL = new(1118)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material IRON_NUGGET = new(1119)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material KNOWLEDGE_BOOK = new(1120)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DEBUG_STICK = new(1121)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_13 = new(1122)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_CAT = new(1123)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_BLOCKS = new(1124)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_CHIRP = new(1125)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_FAR = new(1126)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_MALL = new(1127)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_MELLOHI = new(1128)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_STAL = new(1129)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_STRAD = new(1130)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_WARD = new(1131)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_11 = new(1132)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_WAIT = new(1133)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_OTHERSIDE = new(1134)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_RELIC = new(1135)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_5 = new(1136)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MUSIC_DISC_PIGSTEP = new(1137)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = true,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material DISC_FRAGMENT_5 = new(1138)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TRIDENT = new(1139)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material PHANTOM_MEMBRANE = new(1140)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material NAUTILUS_SHELL = new(1141)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HEART_OF_THE_SEA = new(1142)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CROSSBOW = new(1143)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SUSPICIOUS_STEW = new(1144)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material LOOM = new(1145)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material FLOWER_BANNER_PATTERN = new(1146)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material CREEPER_BANNER_PATTERN = new(1147)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material SKULL_BANNER_PATTERN = new(1148)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material MOJANG_BANNER_PATTERN = new(1149)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GLOBE_BANNER_PATTERN = new(1150)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material PIGLIN_BANNER_PATTERN = new(1151)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material GOAT_HORN = new(1152)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material COMPOSTER = new(1153)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material BARREL = new(1154)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material SMOKER = new(1155)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.5f
    };

    public static readonly Material BLAST_FURNACE = new(1156)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.5f
    };

    public static readonly Material CARTOGRAPHY_TABLE = new(1157)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material FLETCHING_TABLE = new(1158)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material GRINDSTONE = new(1159)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material SMITHING_TABLE = new(1160)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = true,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.5f
    };

    public static readonly Material STONECUTTER = new(1161)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 3.5f
    };

    public static readonly Material BELL = new(1162)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 5.0f
    };

    public static readonly Material LANTERN = new(1163)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.5f
    };

    public static readonly Material SOUL_LANTERN = new(1164)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.5f
    };

    public static readonly Material SWEET_BERRIES = new(1165)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material GLOW_BERRIES = new(1166)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CAMPFIRE = new(1167)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material SOUL_CAMPFIRE = new(1168)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material SHROOMLIGHT = new(1169)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material HONEYCOMB = new(1170)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BEE_NEST = new(1171)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material BEEHIVE = new(1172)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material HONEY_BOTTLE = new(1173)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 16,
        BlastResistance = 0.0f
    };

    public static readonly Material HONEYCOMB_BLOCK = new(1174)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.6f
    };

    public static readonly Material LODESTONE = new(1175)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.5f
    };

    public static readonly Material CRYING_OBSIDIAN = new(1176)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material BLACKSTONE = new(1177)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BLACKSTONE_SLAB = new(1178)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material BLACKSTONE_STAIRS = new(1179)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material GILDED_BLACKSTONE = new(1180)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_BLACKSTONE = new(1181)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_BLACKSTONE_SLAB = new(1182)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_BLACKSTONE_STAIRS = new(1183)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CHISELED_POLISHED_BLACKSTONE = new(1184)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_BLACKSTONE_BRICKS = new(1185)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_BLACKSTONE_BRICK_SLAB = new(1186)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material POLISHED_BLACKSTONE_BRICK_STAIRS = new(1187)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material CRACKED_POLISHED_BLACKSTONE_BRICKS = new(1188)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 6.0f
    };

    public static readonly Material RESPAWN_ANCHOR = new(1189)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1200.0f
    };

    public static readonly Material CANDLE = new(1190)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material WHITE_CANDLE = new(1191)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material ORANGE_CANDLE = new(1192)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material MAGENTA_CANDLE = new(1193)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material LIGHT_BLUE_CANDLE = new(1194)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material YELLOW_CANDLE = new(1195)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material LIME_CANDLE = new(1196)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material PINK_CANDLE = new(1197)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material GRAY_CANDLE = new(1198)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material LIGHT_GRAY_CANDLE = new(1199)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material CYAN_CANDLE = new(1200)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material PURPLE_CANDLE = new(1201)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material BLUE_CANDLE = new(1202)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material BROWN_CANDLE = new(1203)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material GREEN_CANDLE = new(1204)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material RED_CANDLE = new(1205)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material BLACK_CANDLE = new(1206)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material SMALL_AMETHYST_BUD = new(1207)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material MEDIUM_AMETHYST_BUD = new(1208)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material LARGE_AMETHYST_BUD = new(1209)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material AMETHYST_CLUSTER = new(1210)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material POINTED_DRIPSTONE = new(1211)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material OCHRE_FROGLIGHT = new(1212)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material VERDANT_FROGLIGHT = new(1213)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material PEARLESCENT_FROGLIGHT = new(1214)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = true,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.3f
    };

    public static readonly Material FROGSPAWN = new(1215)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ECHO_SHARD = new(1216)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BRUSH = new(1217)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 1,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHERITE_UPGRADE_SMITHING_TEMPLATE = new(1218)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SENTRY_ARMOR_TRIM_SMITHING_TEMPLATE = new(1219)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DUNE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1220)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material COAST_ARMOR_TRIM_SMITHING_TEMPLATE = new(1221)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WILD_ARMOR_TRIM_SMITHING_TEMPLATE = new(1222)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WARD_ARMOR_TRIM_SMITHING_TEMPLATE = new(1223)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material EYE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1224)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material VEX_ARMOR_TRIM_SMITHING_TEMPLATE = new(1225)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TIDE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1226)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SNOUT_ARMOR_TRIM_SMITHING_TEMPLATE = new(1227)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RIB_ARMOR_TRIM_SMITHING_TEMPLATE = new(1228)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SPIRE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1229)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WAYFINDER_ARMOR_TRIM_SMITHING_TEMPLATE = new(1230)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SHAPER_ARMOR_TRIM_SMITHING_TEMPLATE = new(1231)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SILENCE_ARMOR_TRIM_SMITHING_TEMPLATE = new(1232)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material RAISER_ARMOR_TRIM_SMITHING_TEMPLATE = new(1233)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HOST_ARMOR_TRIM_SMITHING_TEMPLATE = new(1234)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ANGLER_POTTERY_SHERD = new(1235)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ARCHER_POTTERY_SHERD = new(1236)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ARMS_UP_POTTERY_SHERD = new(1237)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BLADE_POTTERY_SHERD = new(1238)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BREWER_POTTERY_SHERD = new(1239)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BURN_POTTERY_SHERD = new(1240)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DANGER_POTTERY_SHERD = new(1241)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material EXPLORER_POTTERY_SHERD = new(1242)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FRIEND_POTTERY_SHERD = new(1243)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HEART_POTTERY_SHERD = new(1244)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HEARTBREAK_POTTERY_SHERD = new(1245)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HOWL_POTTERY_SHERD = new(1246)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MINER_POTTERY_SHERD = new(1247)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MOURNER_POTTERY_SHERD = new(1248)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PLENTY_POTTERY_SHERD = new(1249)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PRIZE_POTTERY_SHERD = new(1250)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SHEAF_POTTERY_SHERD = new(1251)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SHELTER_POTTERY_SHERD = new(1252)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SKULL_POTTERY_SHERD = new(1253)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SNORT_POTTERY_SHERD = new(1254)
    {
        IsBlock = false,
        IsBurnable = false,
        IsFuel = false,
        IsItem = true,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WATER = new(1255)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 100.0f
    };

    public static readonly Material LAVA = new(1256)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 100.0f
    };

    public static readonly Material TALL_SEAGRASS = new(1257)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PISTON_HEAD = new(1258)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.5f
    };

    public static readonly Material MOVING_PISTON = new(1259)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WALL_TORCH = new(1260)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FIRE = new(1261)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SOUL_FIRE = new(1262)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material REDSTONE_WIRE = new(1263)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material OAK_WALL_SIGN = new(1264)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material SPRUCE_WALL_SIGN = new(1265)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BIRCH_WALL_SIGN = new(1266)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material ACACIA_WALL_SIGN = new(1267)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material CHERRY_WALL_SIGN = new(1268)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material JUNGLE_WALL_SIGN = new(1269)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material DARK_OAK_WALL_SIGN = new(1270)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material MANGROVE_WALL_SIGN = new(1271)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material BAMBOO_WALL_SIGN = new(1272)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material OAK_WALL_HANGING_SIGN = new(1273)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material SPRUCE_WALL_HANGING_SIGN = new(1274)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material BIRCH_WALL_HANGING_SIGN = new(1275)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material ACACIA_WALL_HANGING_SIGN = new(1276)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material CHERRY_WALL_HANGING_SIGN = new(1277)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material JUNGLE_WALL_HANGING_SIGN = new(1278)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material DARK_OAK_WALL_HANGING_SIGN = new(1279)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material MANGROVE_WALL_HANGING_SIGN = new(1280)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material CRIMSON_WALL_HANGING_SIGN = new(1281)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material WARPED_WALL_HANGING_SIGN = new(1282)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material BAMBOO_WALL_HANGING_SIGN = new(1283)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material REDSTONE_WALL_TORCH = new(1284)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SOUL_WALL_TORCH = new(1285)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material NETHER_PORTAL = new(1286)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ATTACHED_PUMPKIN_STEM = new(1287)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material ATTACHED_MELON_STEM = new(1288)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PUMPKIN_STEM = new(1289)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material MELON_STEM = new(1290)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WATER_CAULDRON = new(1291)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material LAVA_CAULDRON = new(1292)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material POWDER_SNOW_CAULDRON = new(1293)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 2.0f
    };

    public static readonly Material END_PORTAL = new(1294)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3600000.0f
    };

    public static readonly Material COCOA = new(1295)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3.0f
    };

    public static readonly Material TRIPWIRE = new(1296)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_TORCHFLOWER = new(1297)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_OAK_SAPLING = new(1298)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_SPRUCE_SAPLING = new(1299)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_BIRCH_SAPLING = new(1300)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_JUNGLE_SAPLING = new(1301)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_ACACIA_SAPLING = new(1302)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_CHERRY_SAPLING = new(1303)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_DARK_OAK_SAPLING = new(1304)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_MANGROVE_PROPAGULE = new(1305)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_FERN = new(1306)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_DANDELION = new(1307)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_POPPY = new(1308)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_BLUE_ORCHID = new(1309)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_ALLIUM = new(1310)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_AZURE_BLUET = new(1311)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_RED_TULIP = new(1312)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_ORANGE_TULIP = new(1313)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_WHITE_TULIP = new(1314)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_PINK_TULIP = new(1315)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_OXEYE_DAISY = new(1316)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_CORNFLOWER = new(1317)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_LILY_OF_THE_VALLEY = new(1318)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_WITHER_ROSE = new(1319)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_RED_MUSHROOM = new(1320)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_BROWN_MUSHROOM = new(1321)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_DEAD_BUSH = new(1322)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_CACTUS = new(1323)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CARROTS = new(1324)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTATOES = new(1325)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SKELETON_WALL_SKULL = new(1326)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material WITHER_SKELETON_WALL_SKULL = new(1327)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material ZOMBIE_WALL_HEAD = new(1328)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material PLAYER_WALL_HEAD = new(1329)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material CREEPER_WALL_HEAD = new(1330)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material DRAGON_WALL_HEAD = new(1331)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material PIGLIN_WALL_HEAD = new(1332)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material WHITE_WALL_BANNER = new(1333)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material ORANGE_WALL_BANNER = new(1334)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material MAGENTA_WALL_BANNER = new(1335)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material LIGHT_BLUE_WALL_BANNER = new(1336)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material YELLOW_WALL_BANNER = new(1337)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material LIME_WALL_BANNER = new(1338)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material PINK_WALL_BANNER = new(1339)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material GRAY_WALL_BANNER = new(1340)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material LIGHT_GRAY_WALL_BANNER = new(1341)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material CYAN_WALL_BANNER = new(1342)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material PURPLE_WALL_BANNER = new(1343)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material BLUE_WALL_BANNER = new(1344)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material BROWN_WALL_BANNER = new(1345)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material GREEN_WALL_BANNER = new(1346)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material RED_WALL_BANNER = new(1347)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material BLACK_WALL_BANNER = new(1348)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material TORCHFLOWER_CROP = new(1349)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material PITCHER_CROP = new(1350)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BEETROOTS = new(1351)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material END_GATEWAY = new(1352)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 3600000.0f
    };

    public static readonly Material FROSTED_ICE = new(1353)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material KELP_PLANT = new(1354)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_TUBE_CORAL_WALL_FAN = new(1355)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_BRAIN_CORAL_WALL_FAN = new(1356)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_BUBBLE_CORAL_WALL_FAN = new(1357)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_FIRE_CORAL_WALL_FAN = new(1358)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material DEAD_HORN_CORAL_WALL_FAN = new(1359)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TUBE_CORAL_WALL_FAN = new(1360)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BRAIN_CORAL_WALL_FAN = new(1361)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BUBBLE_CORAL_WALL_FAN = new(1362)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material FIRE_CORAL_WALL_FAN = new(1363)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material HORN_CORAL_WALL_FAN = new(1364)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BAMBOO_SAPLING = new(1365)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = true,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 1.0f
    };

    public static readonly Material POTTED_BAMBOO = new(1366)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material VOID_AIR = new(1367)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = true,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CAVE_AIR = new(1368)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = true,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BUBBLE_COLUMN = new(1369)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material SWEET_BERRY_BUSH = new(1370)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material WEEPING_VINES_PLANT = new(1371)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material TWISTING_VINES_PLANT = new(1372)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CRIMSON_WALL_SIGN = new(1373)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material WARPED_WALL_SIGN = new(1374)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 16,
        BlastResistance = 1.0f
    };

    public static readonly Material POTTED_CRIMSON_FUNGUS = new(1375)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_WARPED_FUNGUS = new(1376)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_CRIMSON_ROOTS = new(1377)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_WARPED_ROOTS = new(1378)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CANDLE_CAKE = new(1379)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material WHITE_CANDLE_CAKE = new(1380)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material ORANGE_CANDLE_CAKE = new(1381)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material MAGENTA_CANDLE_CAKE = new(1382)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material LIGHT_BLUE_CANDLE_CAKE = new(1383)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material YELLOW_CANDLE_CAKE = new(1384)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material LIME_CANDLE_CAKE = new(1385)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material PINK_CANDLE_CAKE = new(1386)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material GRAY_CANDLE_CAKE = new(1387)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material LIGHT_GRAY_CANDLE_CAKE = new(1388)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material CYAN_CANDLE_CAKE = new(1389)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material PURPLE_CANDLE_CAKE = new(1390)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BLUE_CANDLE_CAKE = new(1391)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BROWN_CANDLE_CAKE = new(1392)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material GREEN_CANDLE_CAKE = new(1393)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material RED_CANDLE_CAKE = new(1394)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material BLACK_CANDLE_CAKE = new(1395)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = true,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.5f
    };

    public static readonly Material POWDER_SNOW = new(1396)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.25f
    };

    public static readonly Material CAVE_VINES = new(1397)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material CAVE_VINES_PLANT = new(1398)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material BIG_DRIPLEAF_STEM = new(1399)
    {
        IsBlock = true,
        IsBurnable = true,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = false,
        MaxStackSize = 64,
        BlastResistance = 0.1f
    };

    public static readonly Material POTTED_AZALEA_BUSH = new(1400)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };

    public static readonly Material POTTED_FLOWERING_AZALEA_BUSH = new(1401)
    {
        IsBlock = true,
        IsBurnable = false,
        IsFuel = false,
        IsItem = false,
        IsAir = false,
        IsFlammable = false,
        IsOccluding = false,
        IsSolid = false,
        IsRecord = false,
        IsInteractable = true,
        MaxStackSize = 64,
        BlastResistance = 0.0f
    };
#endregion
}