using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Digimon;

public class ExtraEvolutionInformation {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int IndexId { get; set; }

    [Required]
    [ForeignKey(nameof(ExtraNpc))]
    public long ExtraNpcId { get; set; }
    public virtual ExtraEvolutionNpc ExtraNpc { get; set; } = null!;

    public virtual ICollection<ExtraEvolution> ExtraEvolutions { get; set; } = new List<ExtraEvolution>();

}