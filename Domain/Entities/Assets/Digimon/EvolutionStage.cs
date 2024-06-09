using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Digimon;

public class EvolutionStage {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Type { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Value { get; set; }

    [Required]
    [ForeignKey(nameof(EvolutionLine))]
    public long EvolutionLineId { get; set; }
    public virtual EvolutionLine EvolutionLine { get; set; } = null!;
}