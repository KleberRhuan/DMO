using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Digimon;

public class EvolutionArmor {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; }

    [Required]
    [Range(1, 100)]
    public int Chance { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte Amount { get; set; }
}