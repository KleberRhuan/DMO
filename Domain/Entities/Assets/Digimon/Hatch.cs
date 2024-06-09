using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Digimon;

public class Hatch {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; } = null!;

    [Required]
    [Range(1, int.MaxValue)]
    public int HatchType { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int LowClassDataSection { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int MidClassDataSection { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int LowClassDataAmount { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int MidClassDataAmount { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int LowClassBreakPoint { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int MidClassBreakPoint { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int EggType { get; set; }
}