using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Digimon;

public class ExtraEvolutionRequired {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; } = null!;

    [Required]
    [Range(1, int.MaxValue)]
    public int Amount { get; set; }

    [Required]
    [ForeignKey(nameof(ExtraEvolution))]
    public long ExtraEvolutionId { get; set; }
    public virtual ExtraEvolution ExtraEvolution { get; set; } = null!;
}