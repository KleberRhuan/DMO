using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums.Item;

namespace Domain.Entities.Assets.Item;

public class ItemInfo {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; } = null!;

    [Required]
    public string Name { get; set; } = null!;
    
    [Required]
    [EnumDataType(typeof(ItemClass))]
    public ItemClass Class { get; set; }
    
    // TODO: Determine The types and Create a new Enum
    [Required]
    public int Type { get; set; }

    // TODO: Determine The Section and Create a new Enum
    [Required]
    public int Section { get; set; }

    // TODO: Determine The SellType and Create a new Enum
    [Required]
    public int SellType { get; set; }

    [Required]
    [EnumDataType(typeof(BoundType))]
    public BoundType BoundType { get; set; }

    // TODO: Determine The UseTimeType and Create a new Enum
    [Required]
    public int UseTimeType { get; set; }

    // TODO: Make this Relactional
    [Required]
    public long SkillCode { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "TamerMinLevel must be between 1 and {MaxValue}")]
    public byte TamerMinLevel { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "TamerMaxLevel must be between 1 and {MaxValue}")]
    public byte TamerMaxLevel { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "DigimonMinLevel must be between 1 and {MaxValue}")]
    public byte DigimonMinLevel { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "DigimonMaxLevel must be between 1 and {MaxValue}")]
    public byte DigimonMaxLevel { get; set; }

    [DefaultValue(0)]
    public long SellPrice { get; set; }

    [DefaultValue(0)]
    public int ScanPrice { get; set; }

    [DefaultValue(0)]
    public int DigicorePrice { get; set; }

    [DefaultValue(0)]
    public int UsageTimeMinutes { get; set; }
    
    public short Overlap { get; set; }

    [Required]
    [EnumDataType(typeof(ItemTarget))]
    public ItemTarget Target { get; set; }

    [DefaultValue(0)]
    public int EventPriceAmount { get; set; }

    [DefaultValue(0)]
    public int EventPriceId { get; set; }

    // TODO: Determine The TypeN and Create a new Enum
    public int TypeN { get; set; }
    
    public short ApplyValueMax { get; set; }

    public short ApplyValueMin { get; set; }

    public short ApplyElement { get; set; }
}