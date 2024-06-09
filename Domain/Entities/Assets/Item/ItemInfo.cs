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
    
    [Required]
    public int Type { get; set; }

    public int Section { get; set; }

    public int SellType { get; set; }

    public int BoundType { get; set; }

    public int UseTimeType { get; set; }

    public long SkillCode { get; set; }

    public byte TamerMinLevel { get; set; }

    public byte TamerMaxLevel { get; set; }

    public byte DigimonMinLevel { get; set; }

    public byte DigimonMaxLevel { get; set; }

    public long SellPrice { get; set; }

    public int ScanPrice { get; set; }

    public int DigicorePrice { get; set; }

    public int UsageTimeMinutes { get; set; }

    public short Overlap { get; set; }

    public int Target { get; set; }

    public int EventPriceAmount { get; set; }

    public int EventPriceId { get; set; }

    public int TypeN { get; set; }

    public short ApplyValueMax { get; set; }

    public short ApplyValueMin { get; set; }

    public short ApplyElement { get; set; }
}