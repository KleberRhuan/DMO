using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Assets.Digimon;

public class Evolution {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Type { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int EvolutionRank { get; set; }

    public virtual ICollection<EvolutionLine> EvolutionLines { get; set; } = new List<EvolutionLine>();
}