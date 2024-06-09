using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Accessory;

public class AccessoryRollStatus {
    
    [Key]
    public long Id { get; private set; }

    [Required]
    [EnumDataType(typeof(AccessoryStatusType))]
    [Column(TypeName = "int")]
    public AccessoryStatusType Type { get; private set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Min Value must be a non-negative integer.")]
    public int MinValue { get; private set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Max Value must be a non-negative integer.")]
    public int MaxValue { get; private set; }

    [Required]
    [ForeignKey(nameof(AccessoryRollAssetId))]
    public long AccessoryRollAssetId { get; private set; }
    public virtual AccessoryRoll AccessoryRoll { get; private set; } = null!;
    
}