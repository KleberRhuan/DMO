using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Accessory;

public class AccessoryRoll {
    [Key]
    public long Id { get; private set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Item ID must be a positive integer.")]
    [ForeignKey(nameof(ItemId))]
    public int ItemId { get; private set; }
    public virtual Item Item { get; private set; }

    [Required]
    [Range(0, byte.MaxValue, ErrorMessage = "StatusAbstract Quantity must be a non-negative integer. Less than 255.")]
    public byte StatusQuantity { get; private set; }

    [Required]
    [Range(0, byte.MaxValue, ErrorMessage = "Reroll Quantity must be a non-negative integer. Less than 255.")]
    public byte ReRollQuantity{ get; private set; }
    
    public virtual ICollection<AccessoryRollStatus> AccessoryRollStatuses { get; private set; } = new List<AccessoryRollStatus>();
}